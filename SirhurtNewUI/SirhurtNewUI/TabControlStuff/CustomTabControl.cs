using Microsoft.Win32;
using ScintillaNET;
using SirhurtNewUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using SirhurtNewUI.Properties;
using SirhurtNewUI.RandomStuff;

namespace SirhurtUI.Controls
{
    public class CustomTabControl : TabControl
    {
        public TabPage RealTabBoi;
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
        private Color activeColor = Color.FromArgb(28, 28, 28);

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
        private Color headerColor = Color.FromArgb(40, 40, 40);

        /// <summary>
        ///     The color of the horizontal line which is under the headers of the tab pages
        /// </summary>
        private Color horizLineColor = Color.FromArgb(40, 40, 40);

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
            get { return this.activeColor; }

            set { this.activeColor = value; }
        }

        [Category("Colors"), Browsable(true), Description("The color of the background of the tab")]
        public Color BackTabColor
        {
            get { return this.backTabColor; }

            set { this.backTabColor = value; }
        }

        [Category("Colors"), Browsable(true), Description("The color of the border of the control")]
        public Color BorderColor
        {
            get { return this.borderColor; }

            set { this.borderColor = value; }
        }

        /// <summary>
        ///     The color of the closing button
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the closing button")]
        public Color ClosingButtonColor
        {
            get { return this.closingButtonColor; }

            set { this.closingButtonColor = value; }
        }

        /// <summary>
        ///     The message that will be shown before closing.
        /// </summary>
        [Category("Options"), Browsable(true), Description("The message that will be shown before closing.")]
        public string ClosingMessage
        {
            get { return this.closingMessage; }

            set { this.closingMessage = value; }
        }

        [Category("Colors"), Browsable(true), Description("The color of the header.")]
        public Color HeaderColor
        {
            get { return this.headerColor; }

            set { this.headerColor = value; }
        }

        [Category("Colors"), Browsable(true),
         Description("The color of the horizontal line which is located under the headers of the pages.")]
        public Color HorizontalLineColor
        {
            get { return this.horizLineColor; }

            set { this.horizLineColor = value; }
        }

        /// <summary>
        ///     Show a Yes/No message before closing?
        /// </summary>
        [Category("Options"), Browsable(true), Description("Show a Yes/No message before closing?")]
        public bool ShowClosingMessage { get; set; }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color SelectedTextColor
        {
            get { return this.selectedTextColor; }

            set { this.selectedTextColor = value; }
        }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color TextColor
        {
            get { return this.textColor; }

            set { this.textColor = value; }
        }

        /// <summary>
        ///     Sets the Tabs on the top
        /// </summary>
        protected override void CreateHandle()
        {
            base.CreateHandle();
            base.Alignment = TabAlignment.Top;

            SendMessage(Handle, 0x1331, IntPtr.Zero, (IntPtr) 16);
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
                    TabPage addTab = TabPages[TabCount -1];
                    if (!ReferenceEquals(draggedTab, addTab) && ReferenceEquals(draggedTab, predraggedTab) && pointedTab != null)
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
            Settings.Default.FuckingBullShit = GetPointedTab().Text;
            Settings.Default.GodDamnBitch = GetPointedTab();
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

                        if (TabCount <= 2)
                            return;
                        if (this.ShowClosingMessage)
                        {
                            CloseTab(GetPointedTab());
                        }
                        else
                        {
                            CloseTab(GetPointedTab());
                            break;
                        }
                    }
                    else
                    {
                        if (GetTabRect(TabCount - 1).Contains(e.Location))
                        {
                            AddEvent("Script.lua");
                            Update();
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
        protected override void OnMouseUp(MouseEventArgs e)
        {
            predraggedTab = null;

            if (e.Button == MouseButtons.Right)
            {
                new Main().TabContextMenu.Show(Cursor.Position);
            }

            base.OnMouseUp(e);
        }



        /// <summary>
        ///     Draws the control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Debug("Drawing new tab");
            try
            {
                var g = e.Graphics;
                var Drawer = g;

                Drawer.SmoothingMode = SmoothingMode.HighQuality;
                Drawer.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Drawer.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                Drawer.Clear(this.headerColor);
                try
                {
                    if (SelectedTab == null) { return; }
                    SelectedTab.BackColor = this.backTabColor;
                }
                catch
                {
                    // ignored
                }

                try
                {
                    if (SelectedTab == null) { return; }
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
                            new SolidBrush(Color.FromArgb(28, 28, 28)),
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
                        var Foont = new Font("Arial", 13, FontStyle.Bold);
                        // Draws the closing button
                        if (this.ShowClosingButton)
                        {
                            e.Graphics.DrawString("x", Foont, ColorBrush, HeaderSize.Right - 20, 0);
                        }

                    }
                    else
                    {
                        using (Font bigFont = new Font(SystemFonts.DefaultFont.FontFamily, 14, FontStyle.Bold))
                        {
                            e.Graphics.DrawString("+", bigFont, ColorBrush, HeaderSize.Right - 22,
                                (HeaderSize.Top / 2) - 2);
                        }
                    }

                    ColorBrush.Dispose();
                    Update();
                }

                // Draws the horizontal line
                Drawer.DrawLine(new Pen(Color.FromArgb(20, 20, 20), 5), new Point(0, 25), new Point(Width, 25));

                // Draws the background of the tab control
                Drawer.FillRectangle(new SolidBrush(this.backTabColor), new Rectangle(0, 25, Width, Height - 20));

                // Draws the border of the TabControl
                Drawer.DrawRectangle(new Pen(this.borderColor, 2), new Rectangle(0, 0, Width, Height));
                Drawer.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }
            catch (Exception ex)
            {
                Debug("Failed to draw tab error: ", ex.ToString());
            }
        }

        /// <summary>
        ///     Gets the pointed tab
        /// </summary>
        /// <returns></returns>
        private TabPage GetPointedTab()
        {
            Debug("Getpointedtab called");
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
            Console.WriteLine(tab.Text);
            Scintilla editor = tab.Controls[0] as Scintilla;

            int selectedIdx = TabPages.IndexOf(GetPointedTab());
            if (selectedIdx != 0 || TabCount > 2)
                TabPages.RemoveAt(selectedIdx);
            else
            {
                tab.Text = $"Script {(TabCount - 2).ToString()}.lua";
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
            Update();
        }

        private void DragDropHandler(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
                AddEvent(Path.GetFileNameWithoutExtension(file), File.ReadAllText(file));
                Update();
        }

        private Scintilla NewEditor(string Oop)
        {
            return new Editor().NewScintilla(Oop);
        }

        public Scintilla GetWorkingTextEditor()
        {
            try
            {
                Debug("Attempting to set current editor scintilla");
                return SelectedTab.Controls[0] as Scintilla;
            }
            catch
            {
                Debug("Failed to set current editor scintilla, making new page");
                return NewEditor("");
            }
        }

        public async void Debug(params object[] Data)
        {
            string ToWrite = string.Join(" ", Data);
            Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss") + "] TABCONTROL_DATA: " + ToWrite);
        }

        public void AddEvent(string name, string content = "")
        {
            Debug("Checking and settings tab name");
            if (string.IsNullOrEmpty(name) || name == "Script.lua")
            {
                name = $"Script {(TabCount - 1).ToString()}.lua";
            }
            Debug("Checking and settings tab name done");
            Debug("checking for empty editor");
            if (string.IsNullOrEmpty(GetWorkingTextEditor().Text) && !string.IsNullOrEmpty(content))
            {
                Debug("Empty editor found using current");
                DialogResult dia = MessageBox.Show("Current editor is empty would you like to replace it?", "Sirhurt",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dia == DialogResult.Yes)
                {
                    SelectedTab.Text = name;
                    SelectedTab.Controls[0].Text = content;
                    SelectedTab.Controls[0].Refresh();

                    Debug("Editor Values set:", name, SelectedTab.Controls[0].Name);
                    return;
                }




                int lastTab = TabCount - 1;
                Debug("Setting lasttab init:", lastTab);

                Debug("Insertint TabPage and scintilla");
                TabPages.Insert(lastTab, name);

                TabPages[lastTab].Controls.Add(NewEditor(content));

                Debug("Insertint TabPage and scintilla done");
                Debug("Setting global tabpage variable");
                Settings.Default.GodDamnBitch = TabPages[TabPages.Count - 1];
                Debug("Setting global tabpage variable done");

                Debug("Setting index");
                SelectedIndex = lastTab;
                Debug("Index set as:", SelectedIndex);


                SelectedTab.Text = name;
                SelectedTab.Controls[0].Text = content;
                Update();
            }
            else
            {
                Debug("Editor is not empty makling a new one");
                int lastTab = TabCount - 1;
                Debug("Setting lasttab init:", lastTab);
                Debug("Insertint TabPage and scintilla");
                TabPages.Insert(lastTab, name);
                TabPages[lastTab].Controls.Add(NewEditor(content));

                Debug("Setting global tabpage variable");
                Settings.Default.GodDamnBitch = TabPages[TabPages.Count - 1];

                Debug("Setting index");
                SelectedIndex = lastTab;
                Debug("Index set as:", SelectedIndex);


                SelectedTab.Text = name;
                SelectedTab.Controls[0].Text = content;
                Update();
            }
        }

        public string GetTabName()
        {
            Console.WriteLine(SelectedTab.Text);
            return SelectedTab.Text;
        }

        public void TabChanging(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == TabCount - 1)
                e.Cancel = true;

            Update();
        }
    }
}
