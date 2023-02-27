using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
using ScintillaNET;
using IrisFramework.Controls;

namespace IrisFramework
{

    [ToolboxItem(true)]
    public partial class IrisScriptTabs : UserControl
    {
        /* Get Sets */
        private Color color = Color.FromArgb(45, 45, 45);
        private Color hovercolor = Color.FromArgb(0, 0, 140);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private Color textcolor = Color.FromArgb(158, 158, 158);
        private Color buttonbackcolor = Color.FromArgb(40, 40, 40);
        private Color ribbon = Color.FromArgb(10, 132, 255);
        private Color TabBColor = Color.FromArgb(60, 60, 60);

        private DockStyle dockmethod = DockStyle.Bottom;
        private Point contextpoint;

        private int TabIndexImpl = 0;
        private int ribbonheight = 3;

        public static Guna2Button TBBb = new Guna2Button();
        public static Guna2Button SelectedTab { get { return TBBb; } set { TBBb = value; } }
        public static Guna2Button TBBbd = new Guna2Button();
        public static Guna2Button BackupSelectedTab { get { return TBBbd; } set { TBBbd = value; } }

        public Color TopPannelColor { get { return color; } set { color = value; Invalidate(); } }
        public Color TopHpverColor { get { return hovercolor; } set { hovercolor = value; Invalidate(); } }
        public Color TopClickColor { get { return clickcolor; } set { clickcolor = value; Invalidate(); } }
        public Color TextColor { get { return textcolor; } set { textcolor = value; Invalidate(); } }
        public Color ButtonBackColor { get { return buttonbackcolor; } set { buttonbackcolor = value; Invalidate(); } }
        public Color RibbonColor { get { return ribbon; } set { ribbon = value; Invalidate(); } }
        public Color TabBackColor { get { return TabBColor; } set { TabBColor = value; Invalidate(); } }
        public int RibbonHeight { get { return ribbonheight; } set { ribbonheight = value; Invalidate(); } }
        public DockStyle RibbonDock { get { return dockmethod; } set { dockmethod = value; Invalidate(); } }


        public IrisScriptTabs()
        {
            InitializeComponent();
        }

        public static List<Button> closeButtons = new List<Button> { };

        public static Dictionary<Guna2Button, Panel> Tabs = new Dictionary<Guna2Button, Panel>();

        private Editor editor = new Editor();

        public Guna2Button CreateTab(string Name = "Script", string Script = "")
        {
            IrisScintillaFindReplace FindReplace = new IrisScintillaFindReplace();
            if (Name == "Script")
            {
                Name = $"{Name} {TabIndexImpl}.lua";
            }
            else if (!Name.Contains(".lua") && !Name.Contains(".ini"))
            {
                Name = $"{Name}.lua";
            }
            else
            {
                Name = $"{Name}";
            }

            Guna2Button NewButton = new Guna2Button();
            NewButton.Animated = true;
            NewButton.BackColor = Color.Transparent;
            NewButton.BorderRadius = 0;
            NewButton.CheckedState.Parent = NewButton;
            NewButton.CustomImages.Parent = NewButton;
            NewButton.CustomizableEdges.BottomLeft = false;
            NewButton.CustomizableEdges.BottomRight = false;
            NewButton.FillColor = buttonbackcolor;
            NewButton.Font = new Font("Segoe UI", 9F);
            NewButton.ForeColor = Color.White;
            NewButton.HoverState.Parent = NewButton;
            NewButton.Location = new Point(527, 331);
            NewButton.Name = "NewButton";
            NewButton.ShadowDecoration.Parent = NewButton;
            NewButton.Size = new Size(107, 30);
            NewButton.TabIndex = TabIndexImpl++;
            NewButton.Text = Name;
            NewButton.TextAlign = HorizontalAlignment.Center;
            NewButton.UseTransparentBackground = true;
            NewButton.Dock = DockStyle.Left;
            NewButton.AutoSize = true;
            NewButton.Padding = new Padding(0, 0, 4, 0);
            NewButton.SizeChanged += NewButton_SizeChanged;
            NewButton.MouseUp += NewButton_MouseUp;
            NewButton.Click += NewButton_Click;
            NewButton.MouseDown += NewButton_MouseDown;
            NewButton.MouseClick += NewButton_MouseClick;
            NewButton.KeyDown += NewButton_KeyDown;

            Button CloseButton = new Button();
            CloseButton.Size = new Size(0, 0);
            NewButton.Controls.Add(CloseButton);

            Panel Ribbon = new Panel();
            NewButton.Controls.Add(Ribbon);
            Ribbon.BackColor = ribbon;
            Ribbon.Location = new Point(635, 365);
            Ribbon.Name = "Ribbon";
            Ribbon.Size = new Size(NewButton.Width, ribbonheight);
            Ribbon.Dock = dockmethod;

            Panel Tab = new Panel();
            Container.Controls.Add(Tab);
            Tab.Dock = DockStyle.Fill;
            Tab.BackColor = TabBColor;

            Tab.Controls.Add(editor.NewScintilla(Script));

            ButtonHolder.Controls.Add(NewButton);
            ButtonHolder.Controls.SetChildIndex(NewButton, 0);
            ButtonHolder.Controls.SetChildIndex(AddTab, 0);

            Tabs.Add(NewButton, Tab);

            closeButtons.Add(CloseButton);

            NewButton.PerformClick();
            Tab.Visible = true;

            var scintilla = GetWorkingEditor();
            var lineCount = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 1;

            FindReplace.SetupTextBox(scintilla);
            scintilla.Controls.Add(FindReplace);
            FindReplace.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            FindReplace.Location = new Point(GetWorkingEditor().Right - FindReplace.Size.Width, 0);
            FindReplace.Visible = false;
            FindReplace.Cursor = Cursors.Default;
            FindReplace.TabC = this;

            scintilla.SizeChanged += (e, r) =>
            {
                if (scintilla.Width > scintilla.ClientRectangle.Width)
                {
                    FindReplace.Location = new Point(GetWorkingEditor().Right - FindReplace.Size.Width - 20, 0);
                }
                else
                {
                    FindReplace.Location = new Point(GetWorkingEditor().Right - FindReplace.Size.Width, 0);
                }
            };

            scintilla.TextChanged += (e, r) =>
            {
                var Scint = GetWorkingEditor();
                lineCount = Scint.Lines.Count.ToString().Length;
                Scint.Margins[0].Width = Scint.TextWidth(10, new string('9', lineCount + 1)) + 1;
            };

            return NewButton;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Guna2Button ButtonClicked = (Guna2Button)sender;
            SelectedTab = ButtonClicked as Guna2Button;


            foreach (Panel Page in Tabs.Values)
            {
                Page.Visible = false;
            }

            foreach (Guna2Button TabButton in Tabs.Keys)
            {
                if (TabButton != ButtonClicked)
                {
                    TabButton.Controls[1].Visible = false;
                    TabButton.BackColor = buttonbackcolor;

                    Button CB = TabButton.Controls[0] as Button;
                    CB.BackColor = buttonbackcolor;

                    Tabs[ButtonClicked].Visible = true;
                }
                else
                {
                    TabButton.Controls[1].Visible = true;
                    TabButton.BackColor = clickcolor;

                    Button CB = TabButton.Controls[0] as Button;
                    CB.BackColor = clickcolor;
                }
            }

            //Backup incase the other one doesnt work
            foreach (Panel Page in Tabs.Values)
            {
                int Index = Tabs.Values.ToList().IndexOf(Tabs[ButtonClicked]);

                Tabs.Values.ElementAt(Index).Visible = true;
            }
        }

        private void NewButton_SizeChanged(object sender, EventArgs e)
        {
            int ButtonHeight = (sender as Guna2Button).Height;

            if (ButtonHeight == 13)
            {
                ButtonHolder.Size = new Size(ButtonHolder.Width, 50);
            }
            else if (ButtonHeight == 50)
            {
                ButtonHolder.Size = new Size(ButtonHolder.Width, 30);
                foreach (Control Curr in ButtonHolder.Controls)
                {
                    Curr.Height = ButtonHolder.Height;
                }

            }

            if (AddTab.Height == 50)
            {
                AddTab.Size = new Size(30, 30);
            }
        }

        private void NewButton_MouseUp(object sender, MouseEventArgs e)
        {
            NewButton_Click(sender, e);
            SelectedTab = (Guna2Button)sender;

            if (e.Button == MouseButtons.Right)
            {
                if (MainStrip != null)
                {
                    MainStrip.Show(Cursor.Position);
                }
            }
        }

        private void NewButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackupSelectedTab = (Guna2Button)sender;
        }

        public void Debug(params object[] Data)
        {
            string ToWrite = string.Join(" ", Data);
            Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss") + "] " + ToWrite);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int indexofbutton = ButtonHolder.Controls.IndexOf(SelectedTab);
                TabIndexImpl--;
                Tabs[SelectedTab].Dispose();
                Tabs.Remove(SelectedTab);
                SelectedTab.Dispose();

                if (ButtonHolder.Controls.Count > 1)
                {
                    if (ButtonHolder.Controls[indexofbutton] != null)
                    {
                        (ButtonHolder.Controls[indexofbutton] as Guna2Button).PerformClick();
                    }
                }
                else
                {
                    CreateTab();
                }
            }
            catch { }
        }

        public void ReName(string Text)
        {
            SelectedTab.Text = Text + "   ";
        }

        public Scintilla GetWorkingEditor()
        {
            Scintilla Editor = new Scintilla();

            foreach (Panel TabPage in Tabs.Values)
            {
                if (TabPage.Visible)
                {


                    Editor = TabPage.Controls[0] as Scintilla;
                    break;
                }
            }

            return Editor;
        }

        private void NewButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {
                try
                {
                    int indexofbutton = ButtonHolder.Controls.IndexOf(SelectedTab);
                    TabIndexImpl--;
                    Tabs[SelectedTab].Dispose();
                    Tabs.Remove(SelectedTab);
                    SelectedTab.Dispose();

                    if (ButtonHolder.Controls.Count > 1)
                    {
                        if (ButtonHolder.Controls[indexofbutton] != null)
                        {
                            (ButtonHolder.Controls[indexofbutton] as Guna2Button).PerformClick();
                        }
                    }
                    else
                    {
                        CreateTab();
                    }
                }
                catch { }
            }
        }

        public void SavePointedTab()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                string selection = SelectedTab.Text.Replace("   ", "");
                saveFileDialog.FileName = selection;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, GetWorkingEditor().Text);
                }
            }
        }

        public string GetTabName()
        {
            return SelectedTab.Text;
        }

        public void OpenFile()
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                open.RestoreDirectory = true;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader Reader = new StreamReader(open.FileName))
                    {
                        Guna2Button Tab = CreateTab(open.SafeFileName, Reader.ReadToEnd());
                        Tab.PerformClick();
                        SelectedTab = Tab;

                    }
                }
            }
        }

        public void SaveAllTabs(string Dir)
        {
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);

            try
            {
                foreach (string File in Directory.GetFiles(Dir))
                {
                    System.IO.File.Delete(File);
                }
            }
            catch { }

            foreach (Guna2Button Tab in Tabs.Keys)
            {
                using (StreamWriter writer = new StreamWriter($"{Dir}\\{Tab.Text}"))
                {
                    writer.Write(Tabs[Tab].Controls[0].Text);
                }
            }
        }

        private void AddTabClicked(object sender, EventArgs e)
        {
            Guna2Button Button = CreateTab();
            SelectedTab = Button;
            BackupSelectedTab = Button;
            Button.PerformClick();
        }

        private void NewButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedTab = (sender as Guna2Button);
                BackupSelectedTab = SelectedTab;
                MainStrip.Show(Cursor.Position);
                contextpoint = Cursor.Position;
            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseButton_Click(sender, e);
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renameToolStripMenuItem.Visible = false;
            RenameBox.Visible = true;
            MainStrip.Show(contextpoint);
        }

        private void RenameBox_TextChanged(object sender, EventArgs e)
        {
            if (RenameBox.Text != string.Empty)
                SelectedTab.Text = RenameBox.Text + ".lua";
        }

        private void RenameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                renameToolStripMenuItem.Visible = true;
                RenameBox.Visible = false;
                RenameBox.Text = "";
            }
        }

        private void RenameBox_Click(object sender, EventArgs e)
        {

        }
    }


    public class Editor
    {

        public Scintilla NewScintilla(string Content)
        {
            var scintilla = new Scintilla();
            scintilla.AllowDrop = true;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Lexer = Lexer.Lua;
            scintilla.Dock = DockStyle.Fill;
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.Styles[Style.Default].BackColor = Color.FromArgb(30, 30, 30);
            scintilla.Styles[Style.Default].ForeColor = Color.FromArgb(255, 255, 255);
            scintilla.StyleClearAll();

            scintilla.Styles[Style.Lua.Identifier].ForeColor = Color.FromArgb(255, 255, 255);
            scintilla.Styles[Style.Lua.Comment].ForeColor = Color.FromArgb(74, 139, 69);
            scintilla.Styles[Style.Lua.CommentLine].ForeColor = Color.FromArgb(74, 139, 69);
            scintilla.Styles[Style.Lua.CommentDoc].ForeColor = Color.FromArgb(58, 64, 34);
            scintilla.Styles[Style.Lua.Number].ForeColor = Color.FromArgb(181, 206, 168);
            scintilla.Styles[Style.Lua.String].ForeColor = Color.FromArgb(193, 118, 76);
            scintilla.Styles[Style.Lua.Character].ForeColor = Color.FromArgb(193, 118, 76);
            scintilla.Styles[Style.Lua.LiteralString].ForeColor = Color.FromArgb(193, 118, 76);
            scintilla.Styles[Style.Lua.Operator].ForeColor = Color.FromArgb(255, 255, 255);
            scintilla.Styles[Style.Lua.Word].ForeColor = Color.FromArgb(66, 156, 195);
            scintilla.Styles[Style.Lua.Word2].ForeColor = Color.FromArgb(69, 180, 152);
            scintilla.Styles[Style.Lua.Word3].ForeColor = Color.FromArgb(103, 216, 218);
            scintilla.Styles[Style.Lua.Word4].ForeColor = Color.FromArgb(103, 216, 218);
            scintilla.Styles[Style.LineNumber].BackColor = Color.FromArgb(30, 30, 30);

            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "0");

            scintilla.Margins[0].Width = 19;
            scintilla.Margins[0].Type = MarginType.Number;
            scintilla.Margins[1].Type = MarginType.Symbol;
            scintilla.Margins[1].Mask = 4261412864u;
            scintilla.Margins[1].Sensitive = true;
            scintilla.Margins[1].Width = 8;

            for (var i = 0; i <= 31; i++)
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


            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;
            scintilla.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
            scintilla.SetSelectionForeColor(true, Color.Black);
            scintilla.SetFoldMarginColor(true, Color.FromArgb(30, 30, 30));
            scintilla.SetFoldMarginHighlightColor(true, Color.FromArgb(30, 30, 30));
            scintilla.SetKeywords(0, "and break do else elseif end false for function if in local nil not or repeat return then true until while continue [nonamecall]");
            scintilla.SetKeywords(1,
                "table.lock table.unlock warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle isrbxactive leftpress rightpress leftrelease setconstant setconstants debug.setconstant debug.setconstants debug.getconstants getconstants getconstant debug.getconstant debug.getupvalue debug.getupvalues Drawing.new rightrelease get_hidden_gui CFrame.new RandomString gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable debug.setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
            scintilla.SetKeywords(2,
                "syn_clipboard_get getloadedmodules syn_getloadedmodules syn_clipboard_set decompile write getinfo debug.getinfo debug.getregistry gethwid getnilinstances getrenv getgc checkcaller getloadedmodules getconnections firesignal hookfunction hookfunc newcclosure islclosure fireclickdetector firetouchinterest http_request is_sirhurt_closure compare_c_functions  is_protected_closure  dofile getgenv keypress keyrelease mousemove mousemoverel mousescroll  getreg endscript changereadonly setclipboard clipboard.set toclipboard setupvalue getupvalue LUAPROTECT XPROTECT game:GetObjects game:GetService GetService game:GetService(\"Players\") game:GetService(\"ReplicatedStorage\") game:GetService(\"workspace\") game:GetService(\"ReplicatedFirst\") game:GetService(\"Lighting\") game:GetService(\"CoreGui\") game:HttpGet GetObjects luaformat HttpGet Get ReplaceString  proto get_nil_instances setreadonly isreadonly  getrawmetatable get_thread_context getscriptfunc test getregistry getrenv _G setlp getlocal special console_print lproto readfile bctolua getscintillaects is_protosmasher_closure create_ebc getupvalues getlocals checkreadonly decompile is_protosmasher_func loadstring load_ebc dumpfunc shared copystr writefile bcloadstring loadfile ");
            //scintilla.SetKeywords(3, "Other Keywords");
            scintilla.CaretForeColor = Color.White;

            scintilla.BackColor = Color.White;
            scintilla.Text = Content ?? "";
            return scintilla;
        }
    }
}
