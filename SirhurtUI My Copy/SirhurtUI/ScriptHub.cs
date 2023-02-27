using Newtonsoft.Json.Linq;
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

namespace SirhurtUI
{
    public partial class ScriptHub : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipe(string name, int timeout);
        public List<JToken> LoadedScripts;

        public static string RandomString(int maxSize)
        {
            char[] array = new char[62];
            array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] array2 = new byte[1];
            using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngcryptoServiceProvider.GetNonZeroBytes(array2);
                array2 = new byte[maxSize];
                rngcryptoServiceProvider.GetNonZeroBytes(array2);
            }
            StringBuilder stringBuilder = new StringBuilder(maxSize);
            foreach (byte b in array2)
            {
                stringBuilder.Append(array[(int)b % array.Length]);
            }
            return stringBuilder.ToString();
        }

        private JObject JsonDecode(string Json)
        {
            return JObject.Parse(Json);
        }

        public string httpGet(string link)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
            string result;
            using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream responseStream = httpWebResponse.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
            }
            return result;
        }

        public static void SirHurtPipe(string script)
        {
            try
            {
                File.WriteAllText("sirhurt.dat", script);
            }
            catch (Exception)
            {
            }
        }

        public ScriptHub()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {
            Text = ScriptHub.RandomString(6);
            Name = ScriptHub.RandomString(6);
            string json = httpGet("https://asshurthosting.pw/upl/UIScriptHub/fetch.php");
            List<JToken> list2 = Extensions.Children<JToken>(JsonDecode(json)["scripts"].Children()).ToList<JToken>();
            LoadedScripts = list2;
            foreach (JToken jtoken in list2)
            {
                listBox1.Items.Add(jtoken["Name"].ToString());
            }
            listBox1.SetSelected(0, true);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string text = listBox1.SelectedItem.ToString();
            foreach (JToken jtoken in LoadedScripts)
            {
                if (jtoken["Name"].ToString() == text)
                {
                    text = jtoken["FileName"].ToString();
                }
            }
            SirHurtPipe("loadstring(HttpGet('https://asshurthosting.pw/upl/UIScriptHub/Scripts/script.php?script=" + text + "'))()");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string b = listBox1.SelectedItem.ToString();
            foreach (JToken jtoken in LoadedScripts)
            {
                if (jtoken["Name"].ToString() == b)
                {
                    richTextBox1.Text = jtoken["Desc"].ToString();
                    pictureBox1.LoadAsync(jtoken["Picture"].ToString());
                }
            }
        }
    }
}
