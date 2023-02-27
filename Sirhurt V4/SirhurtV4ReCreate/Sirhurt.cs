using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using SirhurtV4ReCreate.Classes;
using SirhurtV4ReCreate.Controls;
using SirhurtV4ReCreate.Properties;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace SirhurtV4ReCreate
{
    public partial class Sirhurt : Form
    {
        public int A1;
        public bool attached;
        public uint attachedID;

        private Point lastLocation;

        //public int Settings.Default.A2 = Settings.Default.Settings.Default.A2;
        private bool mouseDown;
        private FindReplace MyFindReplace = new FindReplace();
        private IniFile MyIni;
        private string randomNameLog;

        public Sirhurt()
        {
            InitializeComponent();

            InitSetup();
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipe(string name, int timeout);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("SirHurtInjector.dll")]
        private static extern int Inject();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public void TranslateLanguage(string Language)
        {
            if (Language == "English")
            {
                fileToolStripMenuItem.Text = "File";
                editToolStripMenuItem.Text = "Edit";
                viewToolStripMenuItem.Text = "View";
                debugToolStripMenuItem.Text = "Debug";
                extensionsToolStripMenuItem.Text = "Extensions";
                helpToolStripMenuItem.Text = "Help";
                runScriptToolStripMenuItem.Text = "Run Script";
                label1.Text = "Not Injected";

                newScriptToolStripMenuItem1.Text = "New Script";
                openFileToolStripMenuItem1.Text = "Open File";
                openRecentToolStripMenuItem1.Text = "Open Recent";
                saveToolStripMenuItem1.Text = "Save";
                saveAsToolStripMenuItem1.Text = "Save As";
                saveAllToolStripMenuItem1.Text = "Save All";
                autoSaveToolStripMenuItem1.Text = "Auto Save";
                closeEditorToolStripMenuItem1.Text = "Close Editor";
                exitToolStripMenuItem1.Text = "Exit";

                undoToolStripMenuItem.Text = "Undo";
                redoToolStripMenuItem.Text = "Redo";

                commandPaletteToolStripMenuItem.Text = "Command Palette";
                appearanceToolStripMenuItem.Text = "Appearance";
                loadSettingsIntoEditorToolStripMenuItem.Text = "Load Settings Into Editor";
                scriptHubToolStripMenuItem.Text = "Script Hub";
                hydeToolStripMenuItem.Text = "Hyde";

                runScriptToolStripMenuItem1.Text = "Run Script";

                autoInjectToolStripMenuItem.Text = "Auto Inject";
                killRobloxToolStripMenuItem.Text = "Kill ROBLOX";
                topMostToolStripMenuItem.Text = "Top Most";
                gameExplorerToolStripMenuItem.Text = "Game Explorer";

                sirhurtDiscordToolStripMenuItem.Text = "SirHurt Discord";
                languageToolStripMenuItem.Text = "Credits";
                languageToolStripMenuItem.Text = "Language";
            }

            if (Language == "Russian")
            {
                fileToolStripMenuItem.Text = "файл"; //File
                editToolStripMenuItem.Text = "редактировать"; //Edit
                viewToolStripMenuItem.Text = "Посмотреть"; //View
                debugToolStripMenuItem.Text = "отлаживать"; //Debug
                extensionsToolStripMenuItem.Text = "расширения"; //Extensions
                helpToolStripMenuItem.Text = "Помогите"; //Help
                runScriptToolStripMenuItem.Text = "Бегать"; //Run
                label1.Text = "Не вводится"; //Not Injected

                newScriptToolStripMenuItem1.Text = "Новый скрипт"; //New Script
                openFileToolStripMenuItem1.Text = "Открыть файл"; //Open File
                openRecentToolStripMenuItem1.Text = "Открыть недавние"; //Open Recent
                saveToolStripMenuItem1.Text = "Сохранить"; //Save
                saveAsToolStripMenuItem1.Text = "Сохранить как"; //Save As
                saveAllToolStripMenuItem1.Text = "Сохранить все"; //Save All
                autoSaveToolStripMenuItem1.Text = "Автосохранение"; //Auto Save
                closeEditorToolStripMenuItem1.Text = "Закрыть редактор"; //Close Editor
                exitToolStripMenuItem1.Text = "Выход"; //Exit

                undoToolStripMenuItem.Text = "Отменить"; //Undo
                redoToolStripMenuItem.Text = "Redo"; //Redo

                commandPaletteToolStripMenuItem.Text = "Палитра команд"; //Command Palette
                appearanceToolStripMenuItem.Text = "Внешность"; //Appearance
                loadSettingsIntoEditorToolStripMenuItem.Text = "Загрузить настройки в редактор"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub
                hydeToolStripMenuItem.Text = "Hyde"; //Hyde

                runScriptToolStripMenuItem1.Text = "Бегать"; //Run

                autoInjectToolStripMenuItem.Text = "Авто впрыск"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Убить ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Топ Мост"; //Top Most
                gameExplorerToolStripMenuItem.Text = "Game Explorer"; //Game Explorer

                sirhurtDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                languageToolStripMenuItem.Text = "кредиты"; //Credits
                languageToolStripMenuItem.Text = "язык"; //Language
            }

            if (Language == "French")
            {
                fileToolStripMenuItem.Text = "Fichier"; //File
                editToolStripMenuItem.Text = "Éditer"; //Edit
                viewToolStripMenuItem.Text = "Vue"; //View
                debugToolStripMenuItem.Text = "Déboguer"; //Debug
                extensionsToolStripMenuItem.Text = "Extensions"; //Extensions
                helpToolStripMenuItem.Text = "Aidez-moi"; //Help
                runScriptToolStripMenuItem.Text = "Courir"; //Run
                label1.Text = "Non injecté"; //Not Injected

                newScriptToolStripMenuItem1.Text = "Nouveau script"; //New Script
                openFileToolStripMenuItem1.Text = "Fichier ouvert"; //Open File
                openRecentToolStripMenuItem1.Text = "Ouverte récente"; //Open Recent
                saveToolStripMenuItem1.Text = "sauvegarder"; //Save
                saveAsToolStripMenuItem1.Text = "Enregistrer sous"; //Save As
                saveAllToolStripMenuItem1.Text = "Sauver tous"; //Save All
                autoSaveToolStripMenuItem1.Text = "Sauvegarde automatique"; //Auto Save
                closeEditorToolStripMenuItem1.Text = "Fermer l'éditeur"; //Close Editor
                exitToolStripMenuItem1.Text = "Sortie"; //Exit

                undoToolStripMenuItem.Text = "annuler"; //Undo
                redoToolStripMenuItem.Text = "Refaire"; //Redo

                commandPaletteToolStripMenuItem.Text = "Palette de commandes"; //Command Palette
                appearanceToolStripMenuItem.Text = "Apparence"; //Appearance
                loadSettingsIntoEditorToolStripMenuItem.Text = "Charger les paramètres dans l'éditeur"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub
                hydeToolStripMenuItem.Text = "Hyde"; //Hyde

                runScriptToolStripMenuItem1.Text = "Courir"; //Run

                autoInjectToolStripMenuItem.Text = "Injection automatique"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Tuez ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Top plus"; //Top Most
                gameExplorerToolStripMenuItem.Text = "Game Explorer"; //Game Explorer

                sirhurtDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                languageToolStripMenuItem.Text = "Crédits"; //Credits
                languageToolStripMenuItem.Text = "Langue"; //Language
            }

            if (Language == "Portuguese")
            {
                fileToolStripMenuItem.Text = "Arquivo"; //File
                editToolStripMenuItem.Text = "Editar"; //Edit
                viewToolStripMenuItem.Text = "Visão"; //View
                debugToolStripMenuItem.Text = "Depurar"; //Debug
                extensionsToolStripMenuItem.Text = "Extensões"; //Extensions
                helpToolStripMenuItem.Text = "Socorro"; //Help
                runScriptToolStripMenuItem.Text = "Corre"; //Run
                label1.Text = "Não injetado"; //Not Injected

                newScriptToolStripMenuItem1.Text = "Novo Script"; //New Script
                openFileToolStripMenuItem1.Text = "Abrir arquivo"; //Open File
                openRecentToolStripMenuItem1.Text = "Aberto recentemente"; //Open Recent
                saveToolStripMenuItem1.Text = "Salve"; //Save
                saveAsToolStripMenuItem1.Text = "Salvar como"; //Save As
                saveAllToolStripMenuItem1.Text = "Salvar tudo"; //Save All
                autoSaveToolStripMenuItem1.Text = "Salvamento automático"; //Auto Save
                closeEditorToolStripMenuItem1.Text = "Fechar Editor"; //Close Editor
                exitToolStripMenuItem1.Text = "Saída"; //Exit

                undoToolStripMenuItem.Text = "Desfazer"; //Undo
                redoToolStripMenuItem.Text = "Refazer"; //Redo

                commandPaletteToolStripMenuItem.Text = "Paleta de comandos"; //Command Palette
                appearanceToolStripMenuItem.Text = "Aparência"; //Appearance
                loadSettingsIntoEditorToolStripMenuItem.Text = "Carregar configurações no editor"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub
                hydeToolStripMenuItem.Text = "Hyde"; //Hyde

                runScriptToolStripMenuItem1.Text = "Corre"; //Run

                autoInjectToolStripMenuItem.Text = "Injeção Automática"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Kill ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Top Most"; //Top Most
                gameExplorerToolStripMenuItem.Text = "Game Explorer"; //Game Explorer

                sirhurtDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                languageToolStripMenuItem.Text = "Créditos"; //Credits
                languageToolStripMenuItem.Text = "Língua"; //Language
            }

            if (Language == "German")
            {
                fileToolStripMenuItem.Text = "Datei"; //File
                editToolStripMenuItem.Text = "Bearbeiten"; //Edit
                viewToolStripMenuItem.Text = "Aussicht"; //View
                debugToolStripMenuItem.Text = "Debuggen"; //Debug
                extensionsToolStripMenuItem.Text = "Erweiterungen"; //Extensions
                helpToolStripMenuItem.Text = "Hilfe"; //Help
                runScriptToolStripMenuItem.Text = "Lauf"; //Run
                label1.Text = "Nicht eingespritzt"; //Not Injected

                newScriptToolStripMenuItem1.Text = "Neues Skript"; //New Script
                openFileToolStripMenuItem1.Text = "Datei öffnen"; //Open File
                openRecentToolStripMenuItem1.Text = "Zuletzt geöffnet"; //Open Recent
                saveToolStripMenuItem1.Text = "speichern"; //Save
                saveAsToolStripMenuItem1.Text = "Speichern als"; //Save As
                saveAllToolStripMenuItem1.Text = "Rette alle"; //Save All
                autoSaveToolStripMenuItem1.Text = "Automatisch speichern"; //Auto Save
                closeEditorToolStripMenuItem1.Text = "Schließen Sie den Editor"; //Close Editor
                exitToolStripMenuItem1.Text = "Ausgang"; //Exit

                undoToolStripMenuItem.Text = "Rückgängig machen"; //Undo
                redoToolStripMenuItem.Text = "Wiederholen"; //Redo

                commandPaletteToolStripMenuItem.Text = "Befehlspalette"; //Command Palette
                appearanceToolStripMenuItem.Text = "Aussehen"; //Appearance
                loadSettingsIntoEditorToolStripMenuItem.Text = "Laden Sie die Einstellungen in den Editor"; //Load Settings Into Editor
                scriptHubToolStripMenuItem.Text = "Script Hub"; //Script Hub
                hydeToolStripMenuItem.Text = "Hyde"; //Hyde

                runScriptToolStripMenuItem1.Text = "Lauf"; //Run

                autoInjectToolStripMenuItem.Text = "Auto Inject"; //Auto Inject
                killRobloxToolStripMenuItem.Text = "Töte ROBLOX"; //Kill ROBLOX
                topMostToolStripMenuItem.Text = "Oben am meisten"; //Top Most
                gameExplorerToolStripMenuItem.Text = "Spiel Explorer"; //Game Explorer

                sirhurtDiscordToolStripMenuItem.Text = "SirHurt Discord"; //SirHurt Discord
                languageToolStripMenuItem.Text = "Credits"; //Credits
                languageToolStripMenuItem.Text = "Sprache"; //Language
            }
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                using (var sr =
                    new StreamReader(Environment.CurrentDirectory + $"\\Scripts\\{treeView1.SelectedNode.Text}"))
                {
                    AddEvent(treeView1.SelectedNode.Text, sr.ReadToEnd());
                    //new TabControlX().UpdateButtons();
                }
            }
            catch
            {
            }
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var scintilla = (Scintilla)sender;
            var lineCount = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 2;
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

        public bool ToBool(string Item)
        {
            Item = Item.ToLower();
            if (Item == "true")
                return true;
            if (Item == "false")
                return false;
            return false;
        }

        public void InitSetup()
        {
            try
            {
                if (!File.Exists($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini") ||
                    File.ReadLines($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini").Count() != 28)
                {
                    File.Create($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini").Dispose();
                    MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
                    MyIni.Write("headerBackColor",
                        $"{tabControlX1.SelTabBackColor.R},{tabControlX1.SelTabBackColor.G},{tabControlX1.SelTabBackColor.B}",
                        "main");
                    MyIni.Write("bottomBarBackColor",
                        $"{ButtomPanel.BackColor.R},{ButtomPanel.BackColor.G},{ButtomPanel.BackColor.B}", "main");
                    MyIni.Write("mainTextColor", $"{label4.ForeColor.R},{label4.ForeColor.G},{label4.ForeColor.B}",
                        "main");

                    MyIni.Write("topMost", "false", "extra");
                    MyIni.Write("autoInject", "false", "extra");

                    MyIni.Write("load-intellisense", "false", "debug");
                    MyIni.Write("linter", "false", "debug");
                    MyIni.Write("border-shadow", "false", "debug");
                    MyIni.Write("remove-tracebans", "true", "debug");
                    MyIni.Write("unban-merle", "false", "debug");

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
                    MyIni.Write("keyword1(\"warn print decompile\")", "66,156,195", "scintilla");
                    MyIni.Write("keyword2(\"if then else\")", "69,180,152", "scintilla");
                    MyIni.Write("keyword3(\"getgenv setclipboard getupvalue\")", "103,216,218", "scintilla");
                    // MessageBox.Show(File.ReadLines($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini")
                    //      .Count().ToString());
                    return;
                }

                MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
                ButtomPanel.BackColor = Color.FromArgb(ButtomPanel.BackColor.A,
                    ToColor(MyIni.Read("bottomBarBackColor", "main")));
                treeView1.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                tabControlX1.SelTabBackColor = Color.FromArgb(ButtomPanel.BackColor.A,
                    ToColor(MyIni.Read("headerBackColor ", "main")));
                tabControlX1.SelTabForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                tabControlX1.UnSelTabForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                TopMost = ToBool(MyIni.Read("topMost", "extra"));
                topMostToolStripMenuItem.Checked = ToBool(MyIni.Read("topMost", "extra"));
                if (ToBool(MyIni.Read("autoInjeect", "extra")))
                {
                    AutoAttachFunc();
                    autoInjectToolStripMenuItem.Checked = true;
                }

                if (ToColor(MyIni.Read("mainTextColor", "main")) != Color.FromArgb(158, 158, 158))
                {
                    foreach (Control control in TopPannel.Controls)
                        if (control is Label || control is TreeView || control is ToolStripMenuItem)
                            UpdateColorControls(control, ToColor(MyIni.Read("mainTextColor", "main")));
                    foreach (Control control in ButtomPanel.Controls)
                        if (control is Label || control is TreeView || control is ToolStripMenuItem)
                            UpdateColorControls(control, ToColor(MyIni.Read("mainTextColor", "main")));
                    foreach (ToolStripMenuItem item in menuStrip1.Items)
                    {
                        item.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                        foreach (var children in item.DropDownItems)
                        {
                            var Child = children as ToolStripMenuItem;
                            if (!(Child is CustomToolStripSeparator) && Child != null)
                                Child.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                        }
                    }

                    loadSettingsIntoEditorToolStripMenuItem.ForeColor = ToColor(MyIni.Read("mainTextColor", "main"));
                }
            }
            catch
            {
            }

            if (!ToBool(MyIni.Read("unban-merle")))
            {
                if (!File.Exists($"{Environment.CurrentDirectory}\\autoexe\\loaded.lua"))
                    File.Create($"{Environment.CurrentDirectory}\\autoexe\\loaded.lua").Dispose();
                using (var writer = new StreamWriter($"{Environment.CurrentDirectory}\\autoexe\\loaded.lua"))
                {
                    writer.Write(
                        "game:GetService(\"StarterGui\"):SetCore(\"SendNotification\", {Title = RandomString(7);Text = RandomString(7);Duration = 5;}); \nif game.GetService(game, \"Players\").LocalPlayer.UserId == 1135554559 then game.GetService(game, \"Players\").LocalPlayer:Kick('Me_rle is banned ~Iris') end");
                }

                var registryKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);
                if (registryKey != null && registryKey.GetValue("authkey") == "12345678ABDHJNOQRSTUVWacghkmnopruvz")
                {
                    MessageBox.Show("merle banned lmao");
                    Process.GetCurrentProcess().Kill();
                }
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

        private void Sirhurt_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists($"{Environment.CurrentDirectory}\\bin") ||
                !File.Exists($"{Environment.CurrentDirectory}\\SirHurtInjector.dll"))
            {
                MessageBox.Show("Missing required directories and files, opening bootstrapper...", "Sirhurt V4",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    Process.Start($"{Environment.CurrentDirectory}\\SirHurt_V4_Bootstrapper.exe");
                    foreach (var process in Process.GetProcessesByName("SirHurt V4"))
                        process.Kill();
                }
                catch
                {
                    MessageBox.Show("Could not open bootstrapper, closing process...", "Sirhurt V4",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                }
            }

            TopMost = true;

            Settings.Default.A2 = 0;

            TranslateLanguage(Properties.Settings.Default.Language);

            treeView1.Nodes.Clear();
            menuStrip1.Renderer = new BrowserMenuRenderer();
            contextMenuStrip1.Renderer = new BrowserMenuRenderer();
            randomNameLog = RandomString(6);
            Name = randomNameLog;
            Text = randomNameLog;
            SirhurtLabel.Text = randomNameLog;
            var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);
            if (wtKey != null)
            {
                wtKey.SetValue("WNT", randomNameLog, RegistryValueKind.String);
                wtKey.Close();
            }

            treeView1.Hide();
            AddEvent("Welcome");
        }

        public void AddEvent(string name = "New Script", string content = "-- Sirhurt V4 Lua Script")
        {
            MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
            if (Settings.Default.A2 == 5) return;
            var TPC = new TabPanelControl();
            TPC.Dock = DockStyle.Fill;

            var scintilla = new Scintilla();
            scintilla.AllowDrop = true;
            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click
                                                         | AutomaticFold.Change;
            scintilla.BackColor = Color.Black;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Lexer = Lexer.Lua;
            scintilla.Name = "scintilla";
            scintilla.Dock = DockStyle.Fill;
            scintilla.ScrollWidth = 1;
            scintilla.TabIndex = 0;
            scintilla.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
            scintilla.SetSelectionForeColor(true, Color.Black);
            scintilla.Margins[1].Width = 0;
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.Styles[Style.Default].BackColor = ToColor(MyIni.Read("textEditorColor", "scintilla"));
            scintilla.Styles[Style.Default].ForeColor = ToColor(MyIni.Read("textColor", "scintilla"));
            scintilla.StyleClearAll();
            scintilla.Styles[Style.Lua.Identifier].ForeColor = ToColor(MyIni.Read("identifier", "scintilla"));
            scintilla.Styles[Style.Lua.Comment].ForeColor = ToColor(MyIni.Read("blockComment", "scintilla"));
            scintilla.Styles[Style.Lua.CommentLine].ForeColor = ToColor(MyIni.Read("commentLine", "scintilla"));
            scintilla.Styles[Style.Lua.CommentDoc].ForeColor = ToColor(MyIni.Read("commentDoc", "scintilla"));
            scintilla.Styles[Style.Lua.Number].ForeColor = ToColor(MyIni.Read("integer", "scintilla"));
            scintilla.Styles[Style.Lua.String].ForeColor = ToColor(MyIni.Read("string", "scintilla"));
            scintilla.Styles[Style.Lua.Character].ForeColor = ToColor(MyIni.Read("character", "scintilla"));
            scintilla.Styles[Style.Lua.LiteralString].ForeColor = ToColor(MyIni.Read("literalString", "scintilla"));
            scintilla.Styles[Style.Lua.Operator].ForeColor = ToColor(MyIni.Read("operator", "scintilla"));
            scintilla.Styles[Style.Lua.Word].ForeColor =
                ToColor(MyIni.Read("keyword1(\"warn print decompile\")", "scintilla"));
            scintilla.Styles[Style.Lua.Word2].ForeColor =
                ToColor(MyIni.Read("keyword2(\"if then else\")", "scintilla"));
            scintilla.Styles[Style.Lua.Word3].ForeColor =
                ToColor(MyIni.Read("keyword3(\"getgenv setclipboard getupvalue\")", "scintilla"));
            scintilla.Lexer = Lexer.Lua;
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");
            scintilla.Margins[0].Width = 15;
            scintilla.Margins[0].Type = MarginType.Number;
            scintilla.Margins[1].Type = MarginType.Symbol;
            scintilla.Margins[1].Mask = 4261412864u;
            scintilla.Margins[1].Sensitive = true;
            scintilla.Margins[1].Width = 8;
            for (var i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(Color.White);
                scintilla.Markers[i].SetBackColor(Color.White);
            }

            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;
            scintilla.Styles[Style.LineNumber].BackColor = ToColor(MyIni.Read("textEditorColor", "scintilla"));
            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;
            scintilla.SetFoldMarginColor(true, ToColor(MyIni.Read("textEditorColor", "scintilla")));
            scintilla.SetFoldMarginHighlightColor(true, ToColor(MyIni.Read("textEditorColor", "scintilla")));
            scintilla.SetKeywords(0,
               "and break do else elseif end false for function if in local nil not or repeat return then true until while continue [nonamecall]");
            scintilla.SetKeywords(1,
                "table.lock table.unlock warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle isrbxactive leftpress rightpress leftrelease setconstant setconstants debug.setconstant debug.setconstants debug.getconstants getconstants getconstant debug.getconstant debug.getupvalue debug.getupvalues Drawing.new rightrelease get_hidden_gui CFrame.new RandomString gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable debug.setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
            scintilla.SetKeywords(2,
                "syn_clipboard_get getloadedmodules syn_getloadedmodules syn_clipboard_set getinfo debug.getinfo debug.getregistry gethwid getnilinstances getrenv getgc checkcaller getloadedmodules getconnections firesignal hookfunction hookfunc newcclosure islclosure fireclickdetector firetouchinterest http_request is_sirhurt_closure compare_c_functions  is_protected_closure  dofile getgenv keypress keyrelease mousemove mousemoverel mousescroll  getreg endscript changereadonly setclipboard clipboard.set toclipboard setupvalue getupvalue LUAPROTECT XPROTECT game:GetObjects game:HttpGet GetObjects luaformat HttpGet Get ReplaceString  proto get_nil_instances setreadonly isreadonly  getrawmetatable get_thread_context getscriptfunc test getregistry getrenv _G setlp getlocal special console_print lproto readfile bctolua getscintillaects is_protosmasher_closure create_ebc getupvalues getlocals checkreadonly decompile is_protosmasher_func loadstring load_ebc dumpfunc shared copystr writefile bcloadstring loadfile ");
            scintilla.ScrollWidth = 1;
            scintilla.ScrollWidthTracking = true;
            scintilla.CaretForeColor = Color.White;
            scintilla.BackColor = Color.White;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.TextChanged += scintilla1_TextChanged;
            scintilla.WrapIndentMode = WrapIndentMode.Indent;
            scintilla.WrapMode = WrapMode.None;
            scintilla.WrapVisualFlagLocation = WrapVisualFlagLocation.EndByText;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Text = content;
            scintilla.ContextMenuStrip = contextMenuStrip1;


            TPC.Controls.Add(scintilla);
            if (Settings.Default.A2 == 0)
            {
                tabControlX1.AddTab(name, TPC);
                scintilla.Name = name;
            }
            else
            {
                tabControlX1.AddTab(name + $" ({Settings.Default.A2})", TPC);
                scintilla.Name = name + $" ({Settings.Default.A2})";
            }

            Settings.Default.A2++;

            MyFindReplace = new FindReplace(GetScintilla());
            MyFindReplace.KeyPressed += MyFindReplace_KeyPressed1;
            var owo = scintilla;
            owo.KeyDown += scintilla1_KeyDown;

            new TabControlX().UpdateButtons();
        }

        /* 
        * Love you 0x59 ;) <3 
        */
        public void TraceBanRemoval()
        {
            MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
            if (!ToBool(MyIni.Read("remove-tracebans", "debug"))) return;
            dynamic environmentVariable = Environment.GetEnvironmentVariable("LocalAppData");
          
            dynamic xmlDocument = new XmlDocument();
            xmlDocument.Load(environmentVariable + "\\Roblox\\GlobalBasicSettings_13.xml");
            dynamic xmlNode = xmlDocument.SelectSingleNode("roblox/Item/Properties");
            if (xmlNode != null)
                foreach (var obj in xmlNode)
                {
                    dynamic xmlNode2 = (XmlNode)obj;
                    if (!(xmlNode2.Name != "int") && xmlNode2.Attributes != null &&
                        xmlNode2.Attributes["name"].Value == "RCCProfilerRecordFrameRate") xmlNode2.InnerXml = "1";
                }

            xmlDocument.Save(environmentVariable + "\\Roblox\\GlobalBasicSettings_13.xml");
        }

        private void MyFindReplace_KeyPressed1(object sender, KeyEventArgs e)
        {
            scintilla1_KeyDown(sender, e);
        }

        private void scintilla1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                MyFindReplace.ShowFind();
                e.SuppressKeyPress = true;
            }
            else if (e.Shift && e.KeyCode == Keys.F3)
            {
                MyFindReplace.Window.FindPrevious();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                MyFindReplace.Window.FindNext();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                MyFindReplace.ShowReplace();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                MyFindReplace.ShowIncrementalSearch();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                var MyGoTo = new GoTo((Scintilla)sender);
                MyGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (GetTabName().Contains("Settings.ini"))
                    using (var reader = new StreamWriter($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"))
                    {
                        reader.Write(GetEditorText());
                    }

                if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts"))
                {
                    Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts");
                    using (var sr = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{GetTabName()}.lua"))
                    {
                        sr.WriteLine(GetEditorText());
                        sr.Close();
                    }
                }
                else
                {
                    using (var sr = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{GetTabName()}.lua"))
                    {
                        sr.WriteLine(GetEditorText());
                        sr.Close();
                    }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void InjectSirHurt()
        {
            try
            {
                var AutoAttach = autoInjectToolStripMenuItem.Checked;
                RbxDetecc();
                var intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");
                if (!attached && intPtr != IntPtr.Zero)
                {
                    var num = 0;
                    if (AutoAttach) Thread.Sleep(3000);
                    try
                    {
                        num = Inject();
                    }
                    catch (Exception ex)
                    {
                        attached = false;
                        label1.Invoke(new Action(() => { label1.Text = "Not Injected"; }));
                        menuStrip1.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                        MessageBox.Show($"An error occured with injecting SirHurt: {ex.Message}", "SirHurt V4");
                    }

                    if (num != 0)
                    {
                        attached = true;
                        label1.Invoke(new Action(() => { label1.Text = "Ready"; }));
                        menuStrip1.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.green; }));
                        return;
                    }

                    attached = false;
                    label1.Invoke(new Action(() => { label1.Text = "Not Injected"; }));
                    menuStrip1.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                }
            }
            catch
            {
            }
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
                        label1.Invoke(new Action(() => { label1.Text = "Not Injected"; }));
                        menuStrip1.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                    }
                }
            });
            t2.Start();
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
                    else treeView1.Nodes.Add(t);
                    PopulateTree(d.FullName, t);
                }

                foreach (var f in directory.GetFiles())
                {
                    var t = new TreeNode(f.Name);
                    if (node != null) node.Nodes.Add(t);
                    else treeView1.Nodes.Add(t);
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
                var flag = Directory.Exists(Environment.CurrentDirectory + "\\Scripts");
                if (!flag) Directory.CreateDirectory(Environment.CurrentDirectory + "\\Scripts");
            }
            catch
            {
            }

            PopulateTree(Environment.CurrentDirectory + "\\Scripts", null);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (A1 == 0)
            {
                panel1.BackgroundImage = Resources.explorer1_white;
                panel4.Visible = true;
                A1 = 1;
                treeView1.Show();

                ScriptLoading();
            }
            else if (A1 == 1)
            {
                panel1.BackgroundImage = Resources.explorer1;
                panel4.Visible = false;
                A1 = 0;
                treeView1.Hide();
                treeView1.Nodes.Clear();
            }

            new TabControlX().UpdateButtons();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.BackgroundImage = Resources.bitmap_white;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.BackgroundImage = Resources.bitmap;
            InjectSirHurt();
        }


        private void SirhurtLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
                for (var i = 0; i < Process.GetProcessesByName("RobloxPlayerBeta").Length; i++)
                    Process.GetProcessesByName("RobloxPlayerBeta")[i].Kill();
            for (var i = 0; i < Process.GetProcessesByName("SirhurtV4").Length; i++)
                Process.GetProcessesByName("Sirhurt V4")[i].Kill(); */

            Process.GetCurrentProcess().Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Resources.explorer1_white;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (A1 == 0) panel1.BackgroundImage = Resources.explorer1;
        }

        private void saveAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var scintilla in tabControlX1.Scintillas)
                {
                    var scintilla1 = scintilla.Value;
                    if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts"))
                    {
                        Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts");
                        using (var sr =
                            new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{scintilla1.Name}.lua"))
                        {
                            sr.WriteLine(scintilla1.Text);
                            sr.Close();
                        }
                    }
                    else
                    {
                        using (var sr =
                            new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{scintilla1.Name}.lua"))
                        {
                            sr.WriteLine(scintilla1.Text);
                            sr.Close();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private async void runScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runScriptToolStripMenuItem.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            await Task.Delay(25);
            runScriptToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            TraceBanRemoval();
            SirHurtPipe(GetEditorText());
        }

        private void openFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var sfd = new OpenFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                    AddEvent(Path.GetFileName(sfd.FileName), File.ReadAllText(sfd.FileName));
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (GetTabName().Contains("Settings.ini"))
                using (var reader = new StreamWriter($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"))
                {
                    reader.Write(GetEditorText());
                }

            if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts"))
            {
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts");
                using (var sr = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{GetTabName()}.lua"))
                {
                    sr.WriteLine(GetEditorText());
                    sr.Close();
                }
            }
            else
            {
                using (var sr = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{GetTabName()}.lua"))
                {
                    sr.WriteLine(GetEditorText());
                    sr.Close();
                }
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        public string GetEditorText()
        {
            return tabControlX1.Controls[0].Controls[0].Controls[0].Text;
        }

        public string GetTabName()
        {
            return tabControlX1.buttonlist[tabControlX1.selected_index].Text;
        }

        public Control GetTabPage()
        {
            return tabControlX1.Controls[0].Controls[0];
        }

        public Scintilla GetScintilla()
        {
            return tabControlX1.Controls[0].Controls[0].Controls[0] as Scintilla;
        }

        private void autoSaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($"{Environment.CurrentDirectory}\\Scripts"))
            {
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Scripts");
                using (var sr = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{GetTabName()}.lua"))
                {
                    sr.WriteLine(GetEditorText());
                    sr.Close();
                }
            }

            Invoke(new MethodInvoker(async delegate
            {
                for (; ; )
                {
                    await Task.Delay(100);
                    if (autoSaveToolStripMenuItem1.Checked)
                    {
                        await Task.Delay(2000);
                        try
                        {
                            using (var sr =
                                new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{GetTabName()}.lua"))
                            {
                                await sr.WriteLineAsync(tabControlX1.Controls[0].Text);
                                sr.Close();
                            }
                        }
                        catch
                        {
                            autoSaveToolStripMenuItem1.Checked = false;
                            await Task.Delay(500);
                            autoSaveToolStripMenuItem1.Checked = true;
                        }
                    }
                }
            }));
        }

        private void newScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetScintilla().Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetScintilla().Redo();
        }

        private void hydeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hyde is unavailable for this version of V4 UI", "Hyde");
        }

        private void commandPalleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyFindReplace.ShowFind();
        }

        private void scriptHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ScriptHub().Show();
        }

        private void loadSettingsIntoEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent("Settings.ini", File.ReadAllText($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"));
        }

        private void tabControlX1_Load_1(object sender, EventArgs e)
        {
        }

        private void sirhurtDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discordapp.com/invite/k7MsK8w");
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var credits = new Credits();
            credits.StartPosition = FormStartPosition.CenterParent;
            credits.ShowDialog(this);
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyFindReplace.ShowReplace();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetScintilla().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetScintilla().Copy();
        }

        private void commandPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyFindReplace.ShowFind();
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void closeEditorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
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

        private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
                process.Kill();
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
                        label1.Invoke(new Action(() => { label1.Text = "Not Injected"; }));
                        menuStrip1.Invoke(new Action(() => { runScriptToolStripMenuItem.Image = Resources.red; }));
                    }
                }
            });
            t2.Start();
        }

        private void autoInjectToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
            MyIni.Write("autoInject", autoInjectToolStripMenuItem.Checked.ToString().ToLower(), "extra");
            AutoAttachFunc();
        }

        private void topMostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
            MyIni.Write("topMost", topMostToolStripMenuItem.Checked.ToString().ToLower(), "extra");
            TopMost = topMostToolStripMenuItem.Checked;
        }

        private void Sirhurt_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("SirhurtV4ReCreate"))
                    process.Kill();
            }
            catch
            {
            }
        }

        private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LanguageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var language = new Language();
            language.StartPosition = FormStartPosition.CenterParent;
            language.ShowDialog();

            TranslateLanguage(Properties.Settings.Default.Language);
        }

        private void TopPannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}