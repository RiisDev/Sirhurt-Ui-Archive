using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SirhurtNewUI.Properties;
using SirhurtNewUI.RandomStuff;

namespace SirhurtNewUI.ExtraForms
{
    public partial class ScriptHubForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ScriptHubForm()
        {
            InitializeComponent();
            InitSetup();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }
        private Point lastLocation;
        public List<JToken> LoadedScripts;
        private bool mouseDown;
        private Editor.IniFile MyIni = new Editor().MyIni;


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipe(string name, int timeout);

        public static string RandomString(int maxSize)
        {
            var array = new char[62];
            array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            var array2 = new byte[1];
            using (var rngcryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngcryptoServiceProvider.GetNonZeroBytes(array2);
                array2 = new byte[maxSize];
                rngcryptoServiceProvider.GetNonZeroBytes(array2);
            }

            var stringBuilder = new StringBuilder(maxSize);
            foreach (var b in array2) stringBuilder.Append(array[b % array.Length]);
            return stringBuilder.ToString();
        }

        private JObject JsonDecode(string Json)
        {
            return JObject.Parse(Json);
        }

        public string httpGet(string link)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            string result;
            using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (var responseStream = httpWebResponse.GetResponseStream())
                {
                    using (var streamReader = new StreamReader(responseStream))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
            }

            return result;
        }

        private static Color ToColor(string color)
        {
            var arrColorFragments = color?.Split(',').Select(sFragment =>
            {
                int.TryParse(sFragment, out var fragment);
                return fragment;
            }).ToArray();

            switch (arrColorFragments?.Length)
            {
                case 3:
                    return Color.FromArgb(arrColorFragments[0], arrColorFragments[1], arrColorFragments[2]);
                case 4:
                    return Color.FromArgb(arrColorFragments[0], arrColorFragments[1], arrColorFragments[2],
                        arrColorFragments[3]);
                default:
                    return Color.Transparent;
            }
        }

        public void UpdateColorControls(Control myControl, Color color)
        {
            myControl.ForeColor = color;
            foreach (Control subC in myControl.Controls)
            {
                Console.WriteLine($"{myControl.Name} is valid");
                UpdateColorControls(subC, ToColor(MyIni.Read("mainTextColor", "main")));
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.MacHover;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.MacClose;
        }

        public void InitSetup()
        {
            try
            {
                MyIni = new Editor.IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
                if (ToColor(MyIni.Read("mainTextColor", "main")) != Color.FromArgb(158, 158, 158))
                {
                    listBox1.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                    button1.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                    button5.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                    SirhurtLabel.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                }
            }
            catch
            {
            }
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {
            try
            {
                Text = RandomString(6);
                Name = RandomString(6);
                var json = httpGet("https://sirhurt.net/upl/UIScriptHub/fetch.php");
                var list2 = JsonDecode(json)["scripts"].Children().Children().ToList();
                LoadedScripts = list2;
                foreach (var jtoken in list2) listBox1.Items.Add(jtoken["Name"].ToString());
                listBox1.SetSelected(0, true); 
            }
            catch
            {
                MessageBox.Show("Something failed to start, is the Sirhurt website online?", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopPannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y);

                Update();
            }
        }

        private void TopPannel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TopPannel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public static void SirHurtPipe(string script)
        {
            try
            {
                File.WriteAllText("sirhurt.dat", script);
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var text = listBox1.SelectedItem.ToString();
            foreach (var jtoken in LoadedScripts)
                if (jtoken["Name"].ToString() == text)
                    text = jtoken["FileName"].ToString();
            SirHurtPipe("loadstring(HttpGet('https://sirhurt.net/upl/UIScriptHub/Scripts/script.php?script=" +
                        text + "'))()");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var b = listBox1.SelectedItem.ToString();
            foreach (var jtoken in LoadedScripts)
                if (jtoken["Name"].ToString() == b)
                {
                    richTextBox1.Text = jtoken["Desc"].ToString();
                    pictureBox1.LoadAsync(jtoken["Picture"].ToString());
                }
        }
    }
}
