using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ScintillaNET;
using SirhurtV4ReCreate.Properties;

namespace SirhurtV4ReCreate.Classes
{
    public class BrowserMenuRenderer : ToolStripProfessionalRenderer
    {
        public BrowserMenuRenderer() : base(new BrowserColors())
        {
        }
    }

    public class BrowserColors : ProfessionalColorTable
    {
        private readonly Color BarColour = Color.FromArgb(59, 59, 59);

        private readonly Color DropDownBackColor = Color.FromArgb(35, 35, 36);
        private readonly Color MenuButtonPress = Color.FromArgb(45, 45, 46);
        private readonly Color MenuItemHover = Color.FromArgb(59, 59, 59);


        public override Color ToolStripDropDownBackground => DropDownBackColor; // DropDown items back colour


        public override Color ImageMarginGradientBegin => DropDownBackColor; // Image Location Back Colour

        public override Color ImageMarginGradientMiddle => DropDownBackColor; // Image Location Back Colour

        public override Color ImageMarginGradientEnd => DropDownBackColor; // Image Location Back Colour

        public override Color MenuBorder => DropDownBackColor; // Whole Drop Down Holder Border Colour

        public override Color MenuItemBorder { get; } = Color.FromArgb(59, 59, 59);
        // Hover Border

        public override Color MenuItemSelected { get; } = Color.FromArgb(9, 73, 110);
        // Menu Drop Down Hover Colour

        public override Color MenuStripGradientBegin => BarColour; // Main Bar

        public override Color MenuStripGradientEnd => BarColour; // Main Bar

        public override Color MenuItemSelectedGradientBegin => MenuItemHover; // Hover Behind Colour

        public override Color MenuItemSelectedGradientEnd => MenuItemHover; // Hover Behind Colour

        public override Color MenuItemPressedGradientBegin => MenuButtonPress; // Press back colour

        public override Color MenuItemPressedGradientEnd => MenuButtonPress; // Press back colour
    }

    public class CustomToolStripSeparator : ToolStripSeparator
    {
        public CustomToolStripSeparator()
        {
            Paint += CustomToolStripSeparator_Paint;
        }

        private void CustomToolStripSeparator_Paint(object sender, PaintEventArgs e)
        {
            var toolStripSeparator = (ToolStripSeparator) sender;
            var width = toolStripSeparator.Width;
            var height = toolStripSeparator.Height;
            var backColor = Color.FromArgb(92, 92, 93);
            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0 + 3, width, height - 5);
            // Ty Rashedul.Rubel on stackoverflow
        }
    }

    public class CustomContextMenu : ContextMenuStrip
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            BackColor = Color.FromArgb(35, 35, 35);
        }
    }

    public class CustomTabControl : TabControl
    {
        private readonly StringFormat CenterSringFormat = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        };

        public Color activeColor = Color.FromArgb(30, 30, 30); // The color of the selected page
        public Color backTabColor = Color.FromArgb(30, 30, 30); // The color of the background of the tab
        public Color borderColor = Color.FromArgb(30, 30, 30); // The color of the border of the control
        public Color closingButtonColor = Color.White; // The color of the closing button
        public string closingMessage;
        public TabPage ContextTab;

        public int Count;
        public Color headerColor = Color.FromArgb(35, 35, 35); // The color of the header.

        public Color
            horizLineColor =
                Color.FromArgb(30, 30,
                    30); // The color of the horizontal line which is located under the headers of the pages.

        public TabPage PreDraggedTab;

        public Color selectedTextColor = Color.FromArgb(255, 255, 255); // Text Colour
        public Color textColor = Color.FromArgb(255, 255, 255); // Text Colour

        public CustomTabControl()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(240, 30);
            AllowDrop = true;

            Selecting += TabChanging;
        }

        public bool ShowClosingButton { get; set; }
        public bool ShowClosingMessage { get; set; }

        public Color ActiveColor
        {
            get => activeColor;
            set => activeColor = value;
        }

        public Color BackTabColor
        {
            get => backTabColor;
            set => backTabColor = value;
        }

        public Color BorderColor
        {
            get => borderColor;
            set => borderColor = value;
        }

        public Color ClosingButtonColor
        {
            get => closingButtonColor;
            set => closingButtonColor = value;
        }

        public string ClosingMessage
        {
            get => closingMessage;
            set => closingMessage = value;
        }

        public Color HeaderColor
        {
            get => headerColor;
            set => headerColor = value;
        }

        public Color HorizontalLineColor
        {
            get => horizLineColor;
            set => horizLineColor = value;
        }

        public Color SelectedTextColor
        {
            get => selectedTextColor;
            set => selectedTextColor = value;
        }

        public Color TextColor
        {
            get => textColor;
            set => textColor = value;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Top;

            SendMessage(Handle, 0x1331, IntPtr.Zero, (IntPtr) 16);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            if (PreDraggedTab != null)
            {
                var draggedTab = (TabPage) drgevent.Data.GetData(typeof(TabPage));
                var pointedTab = GetPointedTab();

                var selectedIdx = TabPages.IndexOf(draggedTab);
                if (draggedTab != null && selectedIdx != TabCount)
                {
                    var addTab = TabPages[TabCount - 1];
                    if (!ReferenceEquals(draggedTab, addTab) &&
                        ReferenceEquals(draggedTab, PreDraggedTab) && pointedTab != null)
                    {
                        drgevent.Effect = DragDropEffects.Move;

                        if (!ReferenceEquals(pointedTab, addTab) && !ReferenceEquals(pointedTab, draggedTab))
                            ReplaceTabPages(draggedTab, pointedTab);
                    }
                }
            }

            base.OnDragOver(drgevent);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            PreDraggedTab = GetPointedTab();
            var p = e.Location;
            for (var i = 0; i < TabCount; i++)
            {
                var r = GetTabRect(i);
                r.Offset(r.Width - 15, 8);
                r.Width = 10;
                r.Height = 10;

                if (!r.Contains(p)) continue;

                if (e.Button == MouseButtons.Left)
                {
                    if (i != TabCount - 1)
                    {
                        PreDraggedTab = null;
                        var tab = TabPages[i];

                        if (ShowClosingMessage && TabCount > 2)
                        {
                            CloseTab(tab);
                        }
                        else
                        {
                            if (TabCount > 2)
                            {
                                if (tab.Controls.Count > 0) tab.Controls[0].Dispose();

                                TabPages.RemoveAt(i);
                            }

                            break;
                        }
                    }
                    else
                    {
                        if (GetTabRect(TabCount - 1).Contains(e.Location))
                        {
                            AddEvent();
                            PreDraggedTab = null;
                            break;
                        }
                    }
                }
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var Drawer = g;

            Drawer.SmoothingMode = SmoothingMode.HighQuality;
            Drawer.PixelOffsetMode = PixelOffsetMode.HighQuality;
            Drawer.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            Drawer.Clear(headerColor);
            try
            {
                SelectedTab.BackColor = backTabColor;
            }
            catch
            {
                // ignored
            }

            try
            {
                SelectedTab.BorderStyle = BorderStyle.None;
            }
            catch
            {
                // ignored
            }


            for (var i = 0; i <= TabCount - 1; i++)
            {
                var curPage = TabPages[i];

                var tabWidth = (int) e.Graphics.MeasureString(curPage.Text, Font).Width + 16;
                curPage.Width = tabWidth;

                var Header = new Rectangle(
                    new Point(GetTabRect(i).Location.X, GetTabRect(i).Location.Y),
                    new Size(GetTabRect(i).Width, 30));
                var HeaderSize = new Rectangle(Header.Location, new Size(Header.Width, Header.Height));
                Brush ColorBrush = new SolidBrush(closingButtonColor);

                if (i == SelectedIndex)
                {
                    // Draws the back of the header 
                    Drawer.FillRectangle(new SolidBrush(headerColor), HeaderSize);

                    // Draws the back of the color when it is selected
                    Drawer.FillRectangle(
                        new SolidBrush(Color.FromArgb(30, 30, 30)),
                        new Rectangle(Header.X - 5, Header.Y - 3, Header.Width, Header.Height + 5));

                    // Draws the title of the page
                    Drawer.DrawString(
                        "    " + curPage.Text + "   ",
                        Font,
                        new SolidBrush(selectedTextColor),
                        HeaderSize,
                        CenterSringFormat);
                    curPage.Width = (int) e.Graphics.MeasureString(curPage.Text, Font).Width + 16;
                    ;
                }
                else
                {
                    // Simply draws the header when it is not selected
                    Drawer.DrawString(
                        curPage.Text,
                        Font,
                        new SolidBrush(textColor),
                        HeaderSize,
                        CenterSringFormat);
                }

                if (i != TabCount - 1)
                    // Draws the closing button
                    if (ShowClosingButton)
                        e.Graphics.DrawImage(Resources.Close_WhiteNoHalo_16x, HeaderSize.Right - 20, 7);

                ColorBrush.Dispose();
            }

            // Draws the background of the tab control
            Drawer.FillRectangle(new SolidBrush(backTabColor), new Rectangle(0, 30, Width, Height));

            // Draws the border of the TabControl
            Drawer.DrawRectangle(new Pen(borderColor, 2), new Rectangle(0, 0, Width, Height));
            Drawer.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        public TabPage GetPointedTab()
        {
            for (var i = 0; i <= TabPages.Count - 1; i++)
                if (GetTabRect(i).Contains(PointToClient(Cursor.Position)))
                    return TabPages[i];
            return null;
        }

        private void ReplaceTabPages(TabPage Source, TabPage Destination)
        {
            var SourceIndex = TabPages.IndexOf(Source);
            var DestinationIndex = TabPages.IndexOf(Destination);

            if (SourceIndex == -1 || DestinationIndex == -1)
                return;

            TabPages[DestinationIndex] = Source;
            TabPages[SourceIndex] = Destination;

            if (SelectedIndex == SourceIndex)
                SelectedIndex = DestinationIndex;
            else if (SelectedIndex == DestinationIndex) SelectedIndex = SourceIndex;

            Refresh();
        }

        public void CloseTab(TabPage tab)
        {
            var editor = tab.Controls[0] as Scintilla;

            var selectedIdx = TabPages.IndexOf(tab);

            if (selectedIdx != 0 || TabCount > 2)
            {
                TabPages.RemoveAt(selectedIdx);
                Count--;
            }
            else
            {
                var firstTab = TabPages[0];

                tab.Text = "New Script";
                editor.Text = "";
                editor.Refresh();
                Count = 0;
            }
        }

        private void DragOverEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DragDropHandler(object sender, DragEventArgs e)
        {
            var files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            foreach (var file in files)
                AddEvent(Path.GetFileNameWithoutExtension(file), File.ReadAllText(file));
        }

        public Scintilla NewEditor(string script)
        {
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
            scintilla.Styles[32].Size = 15;
            scintilla.Styles[32].Size = 15;
            scintilla.Styles[32].Size = 15;
            scintilla.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
            scintilla.SetSelectionForeColor(true, Color.Black);
            scintilla.Margins[1].Width = 0;
            scintilla.StyleResetDefault();
            scintilla.Styles[32].Font = "Consolas";
            scintilla.Styles[32].Size = 11;
            scintilla.Styles[32].BackColor = Color.FromArgb(40, 40, 40);
            scintilla.Styles[32].ForeColor = Color.White;
            scintilla.StyleClearAll();
            scintilla.Styles[11].ForeColor = Color.White;
            scintilla.Styles[1].ForeColor = Color.FromArgb(96, 139, 69); // block comment
            scintilla.Styles[2].ForeColor = Color.FromArgb(96, 139, 69); // Comment color
            scintilla.Styles[3].ForeColor = Color.FromArgb(58, 64, 34); // Not sure
            scintilla.Styles[4].ForeColor = Color.FromArgb(181, 206, 144); // "Nuumbers"
            scintilla.Styles[6].ForeColor = Color.FromArgb(206, 110, 66); // "Brackets"
            scintilla.Styles[7].ForeColor = Color.FromArgb(206, 110, 66); // thewse things ' '
            scintilla.Styles[8].ForeColor = Color.FromArgb(206, 110, 66); // Block String
            scintilla.Styles[9].ForeColor = Color.FromArgb(138, 5, 8);
            scintilla.Styles[10].ForeColor = Color.White;
            scintilla.Styles[5].ForeColor = Color.FromArgb(75, 156, 214); // Keywords if then else
            scintilla.Styles[13].ForeColor = Color.FromArgb(103, 216, 239); // Keyowrds 2
            scintilla.Styles[13].Bold = true;
            scintilla.Styles[14].ForeColor = Color.FromArgb(231, 219, 116);
            scintilla.Styles[14].Bold = true;
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

            scintilla.Markers[30].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[31].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[25].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[27].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[26].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[29].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[28].Symbol = MarkerSymbol.LCorner;
            scintilla.Styles[33].BackColor = Color.FromArgb(40, 40, 40);
            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;
            scintilla.SetFoldMarginColor(true, Color.FromArgb(40, 40, 40));
            scintilla.SetFoldMarginHighlightColor(true, Color.FromArgb(40, 40, 40));
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
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Text = script;
            return scintilla;
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var scintilla = (Scintilla) sender;
            var lineCount = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 2;
        }


        public Scintilla GetWorkingTextEditor()
        {
            return SelectedTab.Controls[0] as Scintilla;
        }

        public void AddEvent(string name = "New Script", string content = "-- Sirhurt V4 Lua Script")
        {
            if (string.IsNullOrEmpty(GetWorkingTextEditor().Text) && !string.IsNullOrEmpty(content))
            {
                SelectedTab.Text = $"New Script {Count.ToString()}";
                SelectedTab.Controls[0].Text = content;
                SelectedTab.Controls[0].Refresh();
            }
            else
            {
                var lastTab = TabCount - 1;

                TabPages.Insert(lastTab, name);
                TabPages[lastTab].Controls.Add(NewEditor(content));

                SelectedIndex = lastTab;

                if (name.Contains($"New Script {Count.ToString()}"))
                    SelectedTab.Text = $"New Script {Count.ToString()}";
            }

            Count++;
        }

        public void TabChanging(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == TabCount - 1)
                e.Cancel = true;
        }

        public string OpenSaveDialog(TabPage tab, string text)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;
                sfd.FileName = tab.Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, text);
                    return new FileInfo(sfd.FileName).Name;
                }

                return tab.Text;
            }
        }

        public bool OpenFileDialog(TabPage tab)
        {
            using (var sfd = new OpenFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    AddEvent(Path.GetFileName(sfd.FileName), File.ReadAllText(sfd.FileName));
                    return true;
                }

                return false;
            }
        }
    }
}