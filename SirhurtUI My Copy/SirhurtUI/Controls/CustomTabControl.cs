using Microsoft.Win32;
using ScintillaNET;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SirhurtUI.Controls
{
    public class CustomTabControl : TabControl
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        ///     Format of the title of the TabPage
        /// </summary>
        private readonly StringFormat CenterSringFormat = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        };

        /// <summary>
        ///     The color of the active tab header
        /// </summary>
        private Color activeColor = Color.FromArgb(0, 122, 204);

        /// <summary>
        ///     The color of the background of the Tab
        /// </summary>
        private Color backTabColor = Color.FromArgb(0, 0, 0);

        /// <summary>
        ///     The color of the border of the control
        /// </summary>
        private Color borderColor = Color.FromArgb(30, 30, 30);

        /// <summary>
        ///     Color of the closing button
        /// </summary>
        private Color closingButtonColor = Color.WhiteSmoke;

        /// <summary>
        ///     Message for the user before losing
        /// </summary>
        private string closingMessage;

        /// <summary>
        ///     The color of the tab header
        /// </summary>
        private Color headerColor = Color.FromArgb(45, 45, 48);

        /// <summary>
        ///     The color of the horizontal line which is under the headers of the tab pages
        /// </summary>
        private Color horizLineColor = Color.FromArgb(0, 122, 204);

        /// <summary>
        ///     A random page will be used to store a tab that will be deplaced in the run-time
        /// </summary>
        private TabPage predraggedTab;

        /// <summary>
        ///     The page that was selected for the context menu
        /// </summary>
        public TabPage contextTab;

        /// <summary>
        ///     The color of the text
        /// </summary>
        private Color textColor = Color.FromArgb(255, 255, 255);

        ///<summary>
        /// Shows closing buttons
        /// </summary> 
        public bool ShowClosingButton { get; set; }

        /// <summary>
        /// Selected tab text color
        /// </summary>
        public Color selectedTextColor = Color.FromArgb(255, 255, 255);
        /// <summary>
        ///     Init
        /// </summary>
        public CustomTabControl()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw
                | ControlStyles.OptimizedDoubleBuffer,
                true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(240, 16);
            AllowDrop = true;

            Selecting += new TabControlCancelEventHandler(TabChanging);
        }

        [Category("Colors"), Browsable(true), Description("The color of the selected page")]
        public Color ActiveColor
        {
            get
            {
                return this.activeColor;
            }

            set
            {
                this.activeColor = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the background of the tab")]
        public Color BackTabColor
        {
            get
            {
                return this.backTabColor;
            }

            set
            {
                this.backTabColor = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the border of the control")]
        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }

            set
            {
                this.borderColor = value;
            }
        }

        /// <summary>
        ///     The color of the closing button
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the closing button")]
        public Color ClosingButtonColor
        {
            get
            {
                return this.closingButtonColor;
            }

            set
            {
                this.closingButtonColor = value;
            }
        }

        /// <summary>
        ///     The message that will be shown before closing.
        /// </summary>
        [Category("Options"), Browsable(true), Description("The message that will be shown before closing.")]
        public string ClosingMessage
        {
            get
            {
                return this.closingMessage;
            }

            set
            {
                this.closingMessage = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the header.")]
        public Color HeaderColor
        {
            get
            {
                return this.headerColor;
            }

            set
            {
                this.headerColor = value;
            }
        }

        [Category("Colors"), Browsable(true),
         Description("The color of the horizontal line which is located under the headers of the pages.")]
        public Color HorizontalLineColor
        {
            get
            {
                return this.horizLineColor;
            }

            set
            {
                this.horizLineColor = value;
            }
        }

        /// <summary>
        ///     Show a Yes/No message before closing?
        /// </summary>
        [Category("Options"), Browsable(true), Description("Show a Yes/No message before closing?")]
        public bool ShowClosingMessage { get; set; }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color SelectedTextColor
        {
            get
            {
                return this.selectedTextColor;
            }

            set
            {
                this.selectedTextColor = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color TextColor
        {
            get
            {
                return this.textColor;
            }

            set
            {
                this.textColor = value;
            }
        }

        /// <summary>
        ///     Sets the Tabs on the top
        /// </summary>
        protected override void CreateHandle()
        {
            base.CreateHandle();
            base.Alignment = TabAlignment.Top;

            SendMessage(Handle, 0x1331, IntPtr.Zero, (IntPtr)16);
        }

        /// <summary>
        ///     Drags the selected tab
        /// </summary>
        /// <param name="drgevent"></param>
        protected override void OnDragOver(DragEventArgs drgevent)
        {
            if (predraggedTab != null)
            {
                TabPage draggedTab = (TabPage)drgevent.Data.GetData(typeof(TabPage));
                var pointedTab = GetPointedTab();

                int selectedIdx = TabPages.IndexOf(draggedTab);
                if (draggedTab != null && selectedIdx != TabCount)
                {
                    TabPage addTab = TabPages[TabCount - 1];
                    if (!ReferenceEquals(draggedTab, addTab) &&
                        ReferenceEquals(draggedTab, predraggedTab) && pointedTab != null)
                    {
                        drgevent.Effect = DragDropEffects.Move;

                        if (!ReferenceEquals(pointedTab, addTab) && !ReferenceEquals(pointedTab, draggedTab))
                        {
                            this.ReplaceTabPages(draggedTab, pointedTab);
                        }
                    }
                }
            }

            base.OnDragOver(drgevent);
        }

        /// <summary>
        ///     Handles the selected tab|closes the selected page if wanted.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            predraggedTab = GetPointedTab();
            var p = e.Location;
            for (var i = 0; i < this.TabCount; i++)
            {
                var r = this.GetTabRect(i);
                r.Offset(r.Width - 15, 2);
                r.Width = 10;
                r.Height = 10;
                if (!r.Contains(p))
                {
                    continue;
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (i != TabCount - 1)
                    {
                        predraggedTab = null;
                        TabPage tab = TabPages[i];

                        if (this.ShowClosingMessage)
                        {
                            CloseTab(tab);
                        }
                        else
                        {
                            if (tab.Controls.Count > 0)
                            {
                                tab.Controls[0].Dispose();
                            }

                            this.TabPages.RemoveAt(i);
                            break;
                        }
                    }
                    else
                    {
                        if (GetTabRect(TabCount - 1).Contains(e.Location))
                        {
                            AddEvent();
                            predraggedTab = null;
                            break;
                        }
                    }
                }
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        ///     Holds the selected page until it sets down
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && predraggedTab != null)
            {
                this.DoDragDrop(predraggedTab, DragDropEffects.Move);
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        ///     Abandons the selected tab
        /// </summary>
        /// <param name="e"></param>
        public static Form1 Form1;
        protected override void OnMouseUp(MouseEventArgs e)
        {
            predraggedTab = null;

            if (e.Button == MouseButtons.Right)
            {
                Form1.TabContextMenu.Show(Cursor.Position);

            }

            base.OnMouseUp(e);
        }



        /// <summary>
        ///     Draws the control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var Drawer = g;

            Drawer.SmoothingMode = SmoothingMode.HighQuality;
            Drawer.PixelOffsetMode = PixelOffsetMode.HighQuality;
            Drawer.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            Drawer.Clear(this.headerColor);
            try
            {
                SelectedTab.BackColor = this.backTabColor;
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
                TabPage curPage = TabPages[i];

                int tabWidth = (int)e.Graphics.MeasureString(curPage.Text, Font).Width + 16;
                curPage.Width = tabWidth;

                var Header = new Rectangle(
                    new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y),
                    new Size(GetTabRect(i).Width, GetTabRect(i).Height));
                var HeaderSize = new Rectangle(Header.Location, new Size(Header.Width, Header.Height));
                Brush ColorBrush = new SolidBrush(this.closingButtonColor);

                if (i == SelectedIndex)
                {
                    // Draws the back of the header 
                    Drawer.FillRectangle(new SolidBrush(this.headerColor), HeaderSize);

                    // Draws the back of the color when it is selected
                    Drawer.FillRectangle(
                        new SolidBrush(Color.FromArgb(0, 122, 204)),
                        new Rectangle(Header.X - 5, Header.Y - 3, Header.Width, Header.Height + 5));

                    // Draws the title of the page
                    Drawer.DrawString(
                        curPage.Text,
                        Font,
                        new SolidBrush(this.selectedTextColor),
                        HeaderSize,
                        this.CenterSringFormat);
                }
                else
                {
                    // Simply draws the header when it is not selected
                    Drawer.DrawString(
                        curPage.Text,
                        Font,
                        new SolidBrush(this.textColor),
                        HeaderSize,
                        this.CenterSringFormat);
                }

                if (i != TabCount - 1)
                {
                    // Draws the closing button
                    if (this.ShowClosingButton)
                    {
                        e.Graphics.DrawString("X", Font, ColorBrush, HeaderSize.Right - 17, 3);
                    }
                }
                else
                {
                    using (Font bigFont = new Font(SystemFonts.DefaultFont.FontFamily, 14, FontStyle.Bold))
                    {
                        e.Graphics.DrawString("+", bigFont, ColorBrush, HeaderSize.Right - 22, (HeaderSize.Top / 2) - 4);
                    }
                }

                ColorBrush.Dispose();
            }

            // Draws the horizontal line
            Drawer.DrawLine(new Pen(Color.FromArgb(0, 122, 204), 5), new Point(0, 19), new Point(Width, 19));

            // Draws the background of the tab control
            Drawer.FillRectangle(new SolidBrush(this.backTabColor), new Rectangle(0, 20, Width, Height - 20));

            // Draws the border of the TabControl
            Drawer.DrawRectangle(new Pen(this.borderColor, 2), new Rectangle(0, 0, Width, Height));
            Drawer.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        /// <summary>
        ///     Gets the pointed tab
        /// </summary>
        /// <returns></returns>
        private TabPage GetPointedTab()
        {
            for (var i = 0; i <= this.TabPages.Count - 1; i++)
            {
                if (this.GetTabRect(i).Contains(this.PointToClient(Cursor.Position)))
                {
                    return this.TabPages[i];
                }
            }

            return null;
        }

        /// <summary>
        ///     Swaps the two tabs
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
        private void ReplaceTabPages(TabPage Source, TabPage Destination)
        {
            var SourceIndex = this.TabPages.IndexOf(Source);
            var DestinationIndex = this.TabPages.IndexOf(Destination);

            if (SourceIndex == -1 || DestinationIndex == -1)
                return;

            this.TabPages[DestinationIndex] = Source;
            this.TabPages[SourceIndex] = Destination;

            if (this.SelectedIndex == SourceIndex)
            {
                this.SelectedIndex = DestinationIndex;
            }
            else if (this.SelectedIndex == DestinationIndex)
            {
                this.SelectedIndex = SourceIndex;
            }

            this.Refresh();
        }

        public void CloseTab(TabPage tab)
        {
           
            Scintilla editor = tab.Controls[0] as Scintilla;

            int selectedIdx = TabPages.IndexOf(tab);

            if (selectedIdx != 0 || TabCount > 2)
                TabPages.RemoveAt(selectedIdx);
            else
            {
                TabPage firstTab = TabPages[0];

                tab.Text = "Script.lua";
                editor.Text = "";
                editor.Refresh();
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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
                AddEvent(Path.GetFileNameWithoutExtension(file), File.ReadAllText(file));
        }

        public Scintilla NewEditor(string script)
        {
            Scintilla scintilla = new Scintilla();
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
            scintilla.Styles[32].Size = 9;
            scintilla.Styles[32].BackColor = Color.FromArgb(40, 40, 40);
            scintilla.Styles[32].ForeColor = Color.White;
            scintilla.StyleClearAll();
            scintilla.Styles[11].ForeColor = Color.White;
            scintilla.Styles[1].ForeColor = Color.FromArgb(193, 118, 76); // block comment
            scintilla.Styles[2].ForeColor = Color.FromArgb(193, 118, 76); // Comment color
            scintilla.Styles[3].ForeColor = Color.FromArgb(58, 64, 34); // Not sure
            scintilla.Styles[4].ForeColor = Color.FromArgb(189, 159, 255); // "Nuumbers"
            scintilla.Styles[6].ForeColor = Color.FromArgb(193, 118, 76); // "Brackets"
            scintilla.Styles[7].ForeColor = Color.FromArgb(193, 118, 76); // thewse things ' '
            scintilla.Styles[8].ForeColor = Color.FromArgb(255, 192, 255);
            scintilla.Styles[9].ForeColor = Color.FromArgb(138, 175, 238);
            scintilla.Styles[10].ForeColor = Color.White;
            scintilla.Styles[5].ForeColor = Color.FromArgb(65, 114, 255); // Keywords if then else
            scintilla.Styles[13].ForeColor = Color.FromArgb(154, 87, 172); // Keyowrds 2
            scintilla.Styles[13].Bold = true;
            scintilla.Styles[14].ForeColor = Color.DeepSkyBlue;
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
                "and break do else elseif end false for function if in local nil not or repeat return then true until while");
            scintilla.SetKeywords(1,
                "warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle CFrame.new gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
            scintilla.SetKeywords(2,
                "getgenv getreg() endscript changereadonly setclipboard clipboard.set toclipboard setupvalue getupvalue proto get_nil_instances getrawmetatable get_thread_context getscriptfunc test getregistry getrenv _G setlp getlocal special console_print lproto readfile bctolua getscintillaects is_protosmasher_closure create_ebc getupvalues getlocals checkreadonly decompile is_protosmasher_func loadstring load_ebc dumpfunc shared copystr writefile bcloadstring loadfile ");
            scintilla.ScrollWidth = 1;
            scintilla.ScrollWidthTracking = true;
            scintilla.CaretForeColor = Color.White;
            scintilla.BackColor = Color.White;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.TextChanged += scintilla1_TextChanged;
            scintilla.WrapIndentMode = WrapIndentMode.Indent;
            scintilla.WrapMode = ScintillaNET.WrapMode.Whitespace;
            scintilla.WrapVisualFlagLocation = WrapVisualFlagLocation.EndByText;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Text = script;

            return scintilla;
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var scintilla = (Scintilla)sender;
            var lineCount = scintilla.Lines.Count.ToString().Length;
            scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 2;
        }

        public Scintilla GetWorkingTextEditor()
        {
            return SelectedTab.Controls[0] as Scintilla;
        }
        int count = 0;
        public void AddEvent(string name = "Script.lua", string content = "")
        {
            if (string.IsNullOrEmpty(GetWorkingTextEditor().Text) && !string.IsNullOrEmpty(content))
            {
                SelectedTab.Text = $"Script {count.ToString()}.lua";
                SelectedTab.Controls[0].Text = content;
                SelectedTab.Controls[0].Refresh();
            }
            else
            {
                int lastTab = TabCount - 1;

                TabPages.Insert(lastTab, name);

                TabPages[lastTab].Controls.Add(NewEditor(content));

                SelectedIndex = lastTab;
                if (name.Contains($"Script{count.ToString()}.lua"))
                {
                    SelectedTab.Text = $"Script {count.ToString()}.lua";
                }
            }
            count++;
        }

        public void TabChanging(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == TabCount - 1)
                e.Cancel = true;
        }

        public string OpenSaveDialog(TabPage tab, string text)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;
                sfd.FileName = tab.Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, text);
                    return new FileInfo(sfd.FileName).Name;
                }
                else
                    return tab.Text;
            }
        }

        public bool OpenFileDialog(TabPage tab)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    GetWorkingTextEditor().Text = File.ReadAllText(sfd.FileName);
                    tab.Text = Path.GetFileName(sfd.FileName);
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
