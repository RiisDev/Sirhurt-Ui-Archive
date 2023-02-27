using ScintillaNET;
using SirhurtU.Controls;
using SirhurtUI.Classes;
using SirhurtUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.TabControl;

namespace SirhurtUI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("SirHurtInjector.dll")]
        private static extern int Inject();

        public uint attachedID;
        public bool attached = false;
        private bool resizing = false;
        public TabPanelControl tpc = new TabPanelControl();
        string ScriptPath = Properties.Settings.Default.ScriptPath;
        public void print(string str)
        {
            Console.WriteLine(str);
        }

        public void InjectSirHurt()
        {
            bool AutoAttach = autoAttachToolStripMenuItem.Checked;
            IntPtr intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");
            if (!attached && intPtr != IntPtr.Zero)
            {
                if (AutoAttach)
                {
                    Thread.Sleep(3000);
                }
                int num = 0;
                try
                {
                    num = Inject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An error occured with injecting SirHurt: %s", ex.Message), "SirHurt V2");
                }
                if (num != 0)
                {
                    attached = true;
                    InjectUwU.Text = "Online";
                    InjectUwU.ForeColor = Color.LimeGreen;
                    return;
                }
                GetWindowThreadProcessId(intPtr, out attachedID);
                attached = true;
                InjectUwU.Text = "Online";
                InjectUwU.ForeColor = Color.LimeGreen;
            }
        }

        public void AutoAttachFunc()
        {
            Thread t2 = new Thread(delegate ()
            {
                for (; ; )
                {
                    Thread.Sleep(100);
                    if (autoAttachToolStripMenuItem.Checked)
                    {
                        Thread.Sleep(2000);
                        InjectSirHurt();
                    }
                    IntPtr intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");
                    uint num = 0u;
                    GetWindowThreadProcessId(intPtr, out num);
                    if ((intPtr == IntPtr.Zero && attached) || (attachedID != 0u && num != attachedID))
                    {
                        attached = false;
                        InjectUwU.Text = "Offline";
                        InjectUwU.ForeColor = Color.Red;
                    }
                }
            });
            t2.Start();
        }

        public void SetupMenu()
        {
            menuStrip1.Renderer = new BrowserMenuRenderer();
            menuStrip1.BackColor = Color.FromArgb(45, 45, 45);
        }
      

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var scintilla = (Scintilla)sender;
            var lineCount = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 2;
        }
        public Form1()
        {
            InitializeComponent();
            CustomTabControl.Form1 = this;
            SetupMenu();
            customTabControl1.TabPages[0].Controls.Add(customTabControl1.NewEditor(""));
        }   

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void SizeDown_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                int w = Size.Width;
                int h = Size.Height;

                if (Cursor.Current.ToString() == "[Cursor: PanSouth]")
                {
                    Size = new Size(w, h + (e.Location.Y));
                }
                else if (Cursor.Current.ToString() == "[Cursor: PanEast]")
                {
                    Size = new Size(w + (e.Location.X), h);
                    InjectUwU.Location = new Point(panel1.Size.Width / 2);
                }
                else if (Cursor.Current.ToString() == "[Cursor: NoMove2D]")
                {
                    Size = new Size(w + (e.Location.X), h + (e.Location.Y));
                    InjectUwU.Location = new Point(panel1.Size.Width / 2);
                }
            }
        }

        private void SizeDown_MouseDown(object sender, MouseEventArgs e)
        {
            resizing = true;
        }

        private void SizeDown_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Environment.Exit(Environment.ExitCode);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TabContextMenuOpening(object sender, CancelEventArgs e)
        {
            TabPage curTab = null;
            TabPageCollection pages = customTabControl1.TabPages;

            Point cursorPos = customTabControl1.PointToClient(Cursor.Position);
            for (int i = 0; i < pages.Count - 1; i++)
            {
                Rectangle rect = customTabControl1.GetTabRect(i);
                if (rect.Contains(cursorPos))
                {
                    curTab = pages[i];
                    break;
                }
            }

            if (curTab == null)
            {
                e.Cancel = true;
                return;
            }

            customTabControl1.contextTab = curTab;

            newTabName.Text = curTab.Text;
        }
        private void NewTabNameClosed(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newTabName.Text))
            {
                customTabControl1.contextTab.Text = "Untitled.lua";
            }
        }

        private void NewTabNameTextChanged(object sender, EventArgs e)
        {
            customTabControl1.contextTab.Text = newTabName.Text.Trim();
        }

        private void CloseToolStripMenuItemHandler(object sender, EventArgs e)
        {
            TabPage selected = customTabControl1.contextTab;
            customTabControl1.CloseTab(selected);
        }

        private void ClearToolStripMenuItemHandler(object sender, EventArgs e)
        {
            Scintilla editor = customTabControl1.contextTab.Controls[0] as Scintilla;
            editor.Text = "";
            editor.Refresh();
        }

        private void OpenIntoToolStripMenuItemHandler(object sender, EventArgs e)
        {
            TabPage selected = customTabControl1.contextTab;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.CheckFileExists = true;

                ofd.Filter = "Script Files (*.txt, *.lua)|*.txt;*.lua|All Files (*.*)|*.*";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selected.Text = Path.GetFileNameWithoutExtension(ofd.SafeFileName);
                    string fileText = File.ReadAllText(ofd.FileName);

                    Scintilla editor = selected.Controls[0] as Scintilla;
                    editor.Text = fileText;
                    editor.Refresh();
                }
            }
        }

        private void SaveToolStripMenuItemHandler(object sender, EventArgs e)
        {
            TabPage selected = customTabControl1.contextTab;

            selected.Text = customTabControl1.OpenSaveDialog(selected, selected.Controls[0].Text);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = ScriptHub.RandomString(6);
            Name = ScriptHub.RandomString(6);

            if (!Directory.Exists(Properties.Settings.Default.ScriptPath))
            {
                Properties.Settings.Default.ScriptPath = Environment.CurrentDirectory + "\\scripts";
            }

            customTabControl1.AddEvent();
            AutoAttachFunc();
            ScriptLoading();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            customTabControl1.AddEvent();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ScriptView.Nodes.Clear();
            ScriptLoading();
            customTabControl1.OpenSaveDialog(customTabControl1.SelectedTab, customTabControl1.GetWorkingTextEditor().Text);
        }

        private void PluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptHub frm = new ScriptHub();
            frm.ShowDialog();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe(customTabControl1.GetWorkingTextEditor().Text);
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd.exe", "/C taskkill /IM RobloxPlayerBeta.exe /F")
            {
                CreateNoWindow = true,
                UseShellExecute = true
            });
        }

        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = topMostToolStripMenuItem.Checked;
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            InjectSirHurt();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Environment.Exit(Environment.ExitCode);
            Process.Start(new ProcessStartInfo("cmd.exe", "/C taskkill /IM RobloxPlayerBeta.exe /F")
            {
                CreateNoWindow = true,
                UseShellExecute = true
            });
        }

        private void OwOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InjectSirHurt();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Current Use", "Sirhurt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abo = new About();
            abo.ShowDialog();
        }

        private void ChangeScriptFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    var flag = folderBrowserDialog.ShowDialog() == DialogResult.OK &&
                               !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
                    var flag2 = flag;
                    if (flag2)
                    {
                        ScriptPath = folderBrowserDialog.SelectedPath;
                        Properties.Settings.Default.ScriptPath = folderBrowserDialog.SelectedPath;
                        Properties.Settings.Default.Save();
                    }
                }

                ScriptView.Nodes.Clear();
                ScriptLoading();
            }
            catch
            {
            }
        }

        public void PopulateTree(string dir, TreeNode node)
        {
            try
            {
                var directory = new DirectoryInfo(dir);
                foreach (var d in directory.GetDirectories())
                {
                    var t = new TreeNode(d.Name);
                    if (node != null) node.Nodes.Add(t);
                    else ScriptView.Nodes.Add(t);
                    PopulateTree(d.FullName, t);
                }

                foreach (var f in directory.GetFiles())
                {
                    var t = new TreeNode(f.Name);
                    if (node != null) node.Nodes.Add(t);
                    else ScriptView.Nodes.Add(t);
                }
            }
            catch (Exception er)
            {
            }
        }

        private void ScriptLoading()
        {
            try
            {
                var flag = Directory.Exists(Properties.Settings.Default.ScriptPath);
                if (!flag) Directory.CreateDirectory(Properties.Settings.Default.ScriptPath);
            }
            catch (Exception er)
            {
            }

            PopulateTree(Properties.Settings.Default.ScriptPath, null);
        }

        private void ChangePathToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    var flag = folderBrowserDialog.ShowDialog() == DialogResult.OK &&
                               !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
                    var flag2 = flag;
                    if (flag2)
                    {
                        ScriptPath = folderBrowserDialog.SelectedPath;
                        Properties.Settings.Default.ScriptPath = folderBrowserDialog.SelectedPath;
                        Properties.Settings.Default.Save();
                    }
                }

                ScriptView.Nodes.Clear();
                ScriptLoading();
            }
            catch
            {
            }
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poth = ScriptView.SelectedNode.FullPath;
            File.Delete(Properties.Settings.Default.ScriptPath + "//" + poth);
        }

        private void ChangePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poth = ScriptView.SelectedNode.FullPath;
            var text = File.ReadAllText(Properties.Settings.Default.ScriptPath + "//" + poth);
            ScriptHub.SirHurtPipe(text);
        }

        private void ExecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poth = ScriptView.SelectedNode.FullPath;
            var text = File.ReadAllText(Properties.Settings.Default.ScriptPath + "//" + poth);
            customTabControl1.GetWorkingTextEditor().Text = text;
        }

        private void ScriptView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.ScriptPath + "//" + ScriptView.SelectedNode.FullPath))
            {
                var text = File.ReadAllText(Properties.Settings.Default.ScriptPath + "//" + ScriptView.SelectedNode.FullPath);
                customTabControl1.AddEvent(ScriptView.SelectedNode.Text, text);
            }
        }

        private void SizeDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            customTabControl1.OpenFileDialog(customTabControl1.SelectedTab);
        }

        private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptView.Nodes.Clear();
            ScriptLoading();
        }

        private void Dex_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(HttpGet('https://asshurthosting.pw/test/Asshurt7Scripts/script.php?script=EXPLORERER2'))()");
        }

        private void ESP_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(HttpGet('https://asshurthosting.pw/test/Asshurt7Scripts/script.php?script=AsshurtESP'))()");
        }

        private void InfiniteYield_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(game:HttpGet(('https://pastebin.com/raw/tzTXmYf2'),true))()");
        }

        private void RemoteSpy_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(game:HttpGet('https://mrspyv2source.000webhostapp.com/'))()");
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(HttpGet('https://asshurthosting.pw/test/Asshurt7Scripts/script.php?script=savegame'))()");
        }

        private void SirhurtHub_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(HttpGet('https://asshurthosting.pw/test/Asshurt7Scripts/script.php?script=ScriptHub'))()");
        }

        private void Noclip_Click(object sender, EventArgs e)
        {
            ScriptHub.SirHurtPipe("loadstring(game:HttpGet('https://irishost.xyz/FileUploader/Iris/Noclip.lua'))()");
        }

        private void InfinityHub_Click(object sender, EventArgs e)
        {
            var Hi_Skids_Pls_leave = "";
            ScriptHub.SirHurtPipe("loadstring(game:HttpGet('https://irishost.xyz/InfinityHosting/Whitelist/SuckMyFuckingAss.lua'))() ");
        }
    }
}
