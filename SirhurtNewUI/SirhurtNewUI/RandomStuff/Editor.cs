using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ScintillaNET;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET_FindReplaceDialog;
using SirhurtNewUI.Properties;
using SirhurtUI.Controls;
using WrapMode = ScintillaNET.WrapMode;
using AutocompleteMenuNS;

namespace SirhurtNewUI.RandomStuff
{
    class Editor
    {
        string[] WordoBois = {"GetChildren()", "GetDescendants()", "end", "if", "then", "else", "GetService(\"Players\")", "GetService(\"ReplicatedStorage\")", "GetService(\"workspace\")", "GetService(\"ReplicatedFirst\")", "GetService(\"Lighting\")", "GetService(\"CoreGui\")",  "syn_clipboard_get", "getloadedmodules", "syn_clipboard_set", "decompile", "getinfo", "debug.getinfo", "debug.getregistry", "gethwid", "getnilinstances", "getrenv", "getgc", "checkcaller", "getconnections", "firesignal", "hookfunction", "hookfunc", "newcclosure", "islclosure", "fireclickdetector", "firetouchinterest", "http_request", "is_sirhurt_closure", "compare_c_functions", "", "is_protected_closure", "dofile", "getgenv", "keypress", "keyrelease", "mousemove", "mousemoverel", "mousescroll", "", "getreg", "changereadonly", "setclipboard", "game:GetService(\"Players\")", "game:GetService(\"ReplicatedStorage\")", "game:GetService(\"workspace\")", "game:GetService(\"ReplicatedFirst\")", "game:GetService(\"Lighting\")", "game:GetService(\"CoreGui\")", "clipboard.set", "toclipboard", "setupvalue", "getupvalue", "LUAPROTECT", "XPROTECT", "game:GetObjects", "game:GetService", "game:HttpGet", "GetObjects", "luaformat", "HttpGet", "Get", "ReplaceString", "", "proto", "get_nil_instances", "setreadonly", "isreadonly", "", "getrawmetatable", "get_thread_context", "getscriptfunc", "test", "getregistry", "_G", "setlp", "getlocal", "special", "console_print", "lproto", "readfile", "bctolua", "getscintillaects", "is_protosmasher_closure", "create_ebc", "getupvalues", "getlocals", "checkreadonly", "is_protosmasher_func", "loadstring", "load_ebc", "dumpfunc", "shared", "copystr", "writefile", "bcloadstring", "loadfile", "table.lock", "table.unlock", "warn", "CFrame", "CFrame.fromEulerAnglesXYZ", "Copy", "CFrame.Angles", "CFrame.fromAxisAngle", "isrbxactive", "leftpress", "rightpress", "leftrelease", "setconstant", "setconstants", "debug.setconstant", "debug.setconstants", "debug.getconstants", "getconstants", "getconstant", "debug.getconstant", "debug.getupvalue", "debug.getupvalues", "Drawing.new", "rightrelease", "get_hidden_gui", "CFrame.new", "RandomString", "gcinfo", "os", "os.difftime", "os.time", "tick", "UDim", "UDim.new", "Instance", "Instance.Lock", "Instance.Unlock", "Instance.new", "pairs", "NumberSequence", "NumberSequence.new", "assert", "tonumber", "getmetatable", "Color3", "Color3.fromHSV", "Color3.toHSV", "Color3.fromRGB", "Color3.new", "load", "Stats", "_G", "UserSettings", "Ray", "Ray.new", "coroutine", "coroutine.resume", "coroutine.yield", "coroutine.status", "coroutine.wrap", "coroutine.create", "coroutine.running", "NumberRange", "NumberRange.new", "PhysicalProperties", "Physicalnew", "printidentity", "PluginManager", "NumberSequenceKeypoint", "NumberSequenceKeypoint.new", "Version", "Vector2", "Vector2.new", "wait", "game.", "game.Players", "game.ReplicatedStorage", "game", "delay", "spawn", "string", "string.sub", "string.upper", "string.len", "string.gfind", "string.rep", "string.find", "string.match", "string.char", "string.dump", "string.gmatch", "string.reverse", "string.byte", "string.format", "string.gsub", "string.lower", "CellId", "CellId.new", "Delay", "version", "stats", "typeof", "UDim2", "UDim2.new", "table", "table.setn", "table.insert", "table.getn", "table.foreachi", "table.maxn", "table.foreach", "table.concat", "table.sort", "table.remove", "settings", "LoadLibrary", "require", "Vector3", "Vector3.FromNormalId", "Vector3.FromAxis", "Vector3.new", "Vector3int16", "Vector3int16.new", "setmetatable", "debug.setmetatable", "next", "ypcall", "ipairs", "Wait", "rawequal", "Region3int16", "Region3int16.new", "collectgarbage", "game", "newproxy", "Spawn", "elapsedTime", "Region3", "Region3.new", "time", "xpcall", "rawset", "tostring", "print", "Workspace", "Vector2int16", "Vector2int16.new", "workspace", "unpack", "math", "math.log", "math.noise", "math.acos", "math.huge", "math.ldexp", "math.pi", "math.cos", "math.tanh", "math.pow", "math.deg", "math.tan", "math.cosh", "math.sinh", "math.random", "math.randomseed", "math.frexp", "math.ceil", "math.floor", "math.rad", "math.abs", "math.sqrt", "math.modf", "math.asin", "math.min", "math.max", "math.fmod", "math.log10", "math.atan2", "math.exp", "math.sin", "math.atan", "ColorSequenceKeypoint", "ColorSequenceKeypoint.new", "pcall", "getfenv", "ColorSequence", "ColorSequence.new", "type", "ElapsedTime", "select", "Faces", "Faces.new", "rawget", "debug", "debug.traceback", "debug.profileend", "debug.profilebeginsetfenv", "error" };


        public IniFile MyIni = new IniFile($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini");
        private FindReplace MyFindReplace = new FindReplace();
        GoTo MyGoTo;// = new GoTo(Settings.Default.FuckAllOfYou);
        Main Main;//= new Main();
        public bool ToBool(string Item)
        {
            Item = Item.ToLower();
            if (Item == "true")
                return true;
            if (Item == "false")
                return false;
            return false;
        }
        public Color ToColor(string color)
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

        internal class IniFile // revision 11
        {
            private readonly string EXE = Assembly.GetExecutingAssembly().GetName().Name;

            // Ty stackoverflow
            private readonly string Path;

            public IniFile(string IniPath = null)
            {
                Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
            }

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern int GetPrivateProfileString(string Section, string Key, string Default,
                StringBuilder RetVal, int Size, string FilePath);

            public string Read(string Key, string Section = null)
            {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                return RetVal.ToString();
            }

            public void Write(string Key, string Value, string Section = null)
            {
                WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            }

            public void DeleteKey(string Key, string Section = null)
            {
                Write(Key, null, Section ?? EXE);
            }

            public void DeleteSection(string Section = null)
            {
                Write(null, null, Section ?? EXE);
            }

            public bool KeyExists(string Key, string Section = null)
            {
                return Read(Key, Section).Length > 0;
            }
        }

        private void BuildAutocompleteMenu(AutocompleteMenu autocompleteMenu1)
        {
            var items = new List<AutocompleteItem>();

            foreach (var item in WordoBois)
                items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });
            autocompleteMenu1.SetAutocompleteItems(items);
        }
        public Scintilla NewScintilla(string Content)
        {
            var scintilla = new Scintilla();
            scintilla.AllowDrop = true;
            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click
                                                         | AutomaticFold.Change;
            scintilla.BackColor = Color.Black;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Lexer = Lexer.Lua;
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
                ToColor(MyIni.Read("keyword1 Color(\"warn print decompile\")", "scintilla"));
            scintilla.Styles[Style.Lua.Word2].ForeColor =
                ToColor(MyIni.Read("keyword2 Color(\"if then else\")", "scintilla"));
            scintilla.Styles[Style.Lua.Word3].ForeColor =
                ToColor(MyIni.Read("keyword3 Color(\"getgenv setclipboard getupvalue\")", "scintilla"));
            scintilla.Styles[Style.Lua.Word4].ForeColor =
                ToColor(MyIni.Read("Custom Keyword Color", "scintilla"));
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
                "syn_clipboard_get getloadedmodules syn_getloadedmodules syn_clipboard_set decompile write getinfo debug.getinfo debug.getregistry gethwid getnilinstances getrenv getgc checkcaller getloadedmodules getconnections firesignal hookfunction hookfunc newcclosure islclosure fireclickdetector firetouchinterest http_request is_sirhurt_closure compare_c_functions  is_protected_closure  dofile getgenv keypress keyrelease mousemove mousemoverel mousescroll  getreg endscript changereadonly setclipboard clipboard.set toclipboard setupvalue getupvalue LUAPROTECT XPROTECT game:GetObjects game:GetService GetService game:GetService(\"Players\") game:GetService(\"ReplicatedStorage\") game:GetService(\"workspace\") game:GetService(\"ReplicatedFirst\") game:GetService(\"Lighting\") game:GetService(\"CoreGui\") game:HttpGet GetObjects luaformat HttpGet Get ReplaceString  proto get_nil_instances setreadonly isreadonly  getrawmetatable get_thread_context getscriptfunc test getregistry getrenv _G setlp getlocal special console_print lproto readfile bctolua getscintillaects is_protosmasher_closure create_ebc getupvalues getlocals checkreadonly decompile is_protosmasher_func loadstring load_ebc dumpfunc shared copystr writefile bcloadstring loadfile ");
            scintilla.SetKeywords(3, MyIni.Read("Custom Keywords", "scintilla"));
            scintilla.ScrollWidth = 1;
            scintilla.ScrollWidthTracking = true;
            scintilla.CaretForeColor = Color.White;
            scintilla.BackColor = Color.White;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.WrapIndentMode = WrapIndentMode.Indent;
            scintilla.WrapMode = WrapMode.None;
            scintilla.WrapVisualFlagLocation = WrapVisualFlagLocation.EndByText;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Text = Content ?? "";

            if (Settings.Default.yesnoornoplease)
            {
                AutocompleteMenu autocompleteMenu = new AutocompleteMenu();
                autocompleteMenu.AllowsTabKey = true;
                autocompleteMenu.AutoPopup = true;
                autocompleteMenu.AppearInterval = 1;
                autocompleteMenu.Colors.BackColor = Color.FromArgb(35, 35, 35);
                autocompleteMenu.Colors.ForeColor = Color.FromArgb(158, 158, 158);
                autocompleteMenu.Colors.SelectedBackColor = Color.FromArgb(9, 73, 110);
                autocompleteMenu.Colors.SelectedBackColor2 = Color.FromArgb(9, 73, 110);
                autocompleteMenu.Colors.SelectedForeColor = Color.FromArgb(255, 255, 255);
                autocompleteMenu.TargetControlWrapper = new ScintillaWrapper(scintilla);
                BuildAutocompleteMenu(autocompleteMenu);
            }

            MyFindReplace = new FindReplace(scintilla);
            MyFindReplace.KeyPressed += MyFindReplace_KeyPressed1;
            scintilla.KeyDown += scintilla1_KeyDown;
            scintilla.TextChanged += scintilla1_TextChanged;
            MyGoTo = new GoTo(scintilla);
            Main = new Main();
            return scintilla;
        }

        private string GetText(string path)
        {
            return File.ReadAllText($"{Environment.CurrentDirectory}\\Scripts\\{path}");
        }

        private void MyFindReplace_KeyPressed1(object sender, KeyEventArgs e)
        {
            scintilla1_KeyDown(sender, e);
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var scintilla = (Scintilla)sender;
            var lineCount = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 2;
            Settings.Default.KillMyself = scintilla.Text;
            Settings.Default.FuckAllOfYou = scintilla;
            string FName = Settings.Default.GodDamnBitch.Text.Replace("*", "");

            if (File.Exists($"{Environment.CurrentDirectory}\\Scripts\\{FName}"))
            { 
                if (GetText(FName) != scintilla.Text && !Settings.Default.GodDamnBitch.Text.Contains("*"))
                {
                    Settings.Default.GodDamnBitch.Text = Settings.Default.GodDamnBitch.Text + "*";
                }
                else if (GetText(FName) == scintilla.Text)
                {
                    Settings.Default.GodDamnBitch.Text = Settings.Default.GodDamnBitch.Text.Replace("*", "");
                }
            }
            else
            {
                if (!Settings.Default.GodDamnBitch.Text.Contains("*"))
                {
                    Settings.Default.GodDamnBitch.Text = Settings.Default.GodDamnBitch.Text + "*";
                }
            }
        }

        private void scintilla1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                return;
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                MyFindReplace.ShowFind();
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                using (OpenFileDialog sfd = new OpenFileDialog())
                {
                    sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    sfd.RestoreDirectory = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        (Settings.Default.Oop as CustomTabControl).AddEvent(Path.GetFileName(sfd.FileName), File.ReadAllText(sfd.FileName));
                    }
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.Enter)
            {
                Main.SirHurtPipe(Settings.Default.FuckAllOfYou.Text);
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                MyFindReplace.ShowReplace();
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                MyGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                (Settings.Default.Oop as CustomTabControl).AddEvent("", "");
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                (Settings.Default.Oop as CustomTabControl).CloseTab(Settings.Default.GodDamnBitch);
                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {

                    sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    sfd.RestoreDirectory = true;
                    sfd.FileName = Settings.Default.GodDamnBitch.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string FName = sfd.FileName.Replace("*", "");
                        File.WriteAllText(FName, Settings.Default.KillMyself);
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                Console.WriteLine(Settings.Default.GodDamnBitch.Text);
                if (Settings.Default.GodDamnBitch.Text.Contains(".ini"))
                {
                    using (var reader = new StreamWriter($"{Environment.CurrentDirectory}\\bin\\schemes\\Settings.ini"))
                    {
                        reader.Write(Settings.Default.KillMyself);
                        Settings.Default.GodDamnBitch.Text = Settings.Default.GodDamnBitch.Text.Replace("*", "");
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true;
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
                        sfd.FileName = Settings.Default.GodDamnBitch.Text;

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            string FName = sfd.FileName.Replace("*", "");
                            File.WriteAllText(FName, Settings.Default.KillMyself);
                            Settings.Default.GodDamnBitch.Text = Settings.Default.GodDamnBitch.Text.Replace("*", "");
                            e.SuppressKeyPress = true;
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                        }
                    }
                }
                else
                {
                    using (StreamWriter Writer = new StreamWriter($"{Environment.CurrentDirectory}\\Scripts\\{Settings.Default.GodDamnBitch.Text.Replace("*", "")}"))
                    {

                        Writer.Write(Settings.Default.KillMyself);
                        Settings.Default.GodDamnBitch.Text = Settings.Default.GodDamnBitch.Text.Replace("*", "");
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }

                e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
