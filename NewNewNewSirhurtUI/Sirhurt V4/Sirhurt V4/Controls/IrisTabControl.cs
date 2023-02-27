using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.Drawing.Printing;
using Sirhurt_V4.ExtraData;
using Sirhurt_V4;

namespace WindowsFormsApp1
{
    public partial class IrisTabControl : UserControl
    {
        private Color color = Color.FromArgb(45, 45, 45); 
        private Color hovercolor = Color.FromArgb(0, 0, 140);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private Color textcolor = Color.FromArgb(158,158,158);
        private Color buttonbackcolor = Color.FromArgb(60,60,60);
        private Color ribbon = Color.FromArgb(10, 132, 255);
        private Color TabBColor = Color.FromArgb(60, 60, 60);
        private DockStyle dockmethod = DockStyle.Bottom;
        private ContextMenuStrip strip;
        private static NoFocusCueButton PreDraggedTab;
        private int ribbonheight = 3;
        public static NoFocusCueButton TBBb = new NoFocusCueButton();
        public static NoFocusCueButton SelectedTab{ get { return TBBb; } set { TBBb = value; } }
        public static Button TBBbd = new NoFocusCueButton();
        public static Button BackupSelectedTab{ get { return TBBbd; } set { TBBbd = value; } }

        public Color TopPannelColor { get { return color; } set { color = value; Invalidate(); } }
        public Color TopHpverColor { get { return hovercolor; } set { hovercolor = value; Invalidate(); } }
        public Color TopClickColor { get { return clickcolor; } set { clickcolor = value; Invalidate(); } }
        public Color TextColor { get { return textcolor; } set { textcolor = value; Invalidate(); } }
        public Color ButtonBackColor { get { return buttonbackcolor; } set { buttonbackcolor = value; Invalidate(); } }
        public Color RibbonColor { get { return ribbon; } set { ribbon = value; Invalidate(); } }
        public Color TabBackColor { get { return TabBColor; } set { TabBColor = value; Invalidate(); } }
        public int RibbonHeight { get { return ribbonheight; } set { ribbonheight = value; Invalidate(); } }
        public ContextMenuStrip MenuStripChosen { get { return strip; } set { strip = value; Invalidate(); } }
        public DockStyle RibbonDock { get { return dockmethod; } set { dockmethod = value; Invalidate(); } }

        public static List<Button> closeButtons = new List<Button> { };

        public static Dictionary<Button, Panel> Tabs = new Dictionary<Button, Panel>();

        private Editor editor = new Editor();

        public NoFocusCueButton CreateTab(string Name = "Script.lua", string Script = "")
        {
            NoFocusCueButton NewButton = new NoFocusCueButton();
            NewButton.BackColor = buttonbackcolor;
            NewButton.FlatAppearance.BorderSize = 0;
            NewButton.FlatStyle = FlatStyle.Flat;
            NewButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            NewButton.ForeColor = textcolor;
            NewButton.Location = new Point(320, 124);
            NewButton.Size = new Size(107, 35);
            NewButton.TabIndex = TabIndex;
            NewButton.Text = $"{Name}   ";
            NewButton.TextAlign = ContentAlignment.MiddleLeft;
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Dock = DockStyle.Left;
            NewButton.FlatAppearance.MouseDownBackColor = NewButton.BackColor;
            NewButton.FlatAppearance.MouseOverBackColor = NewButton.BackColor;
            NewButton.FlatAppearance.BorderSize = 0;
            NewButton.AutoSize = true;
            NewButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NewButton.AutoEllipsis = false;
            NewButton.Padding = new Padding(0,0,4,0);
            NewButton.SizeChanged += NewButton_SizeChanged;
            NewButton.MouseUp += NewButton_MouseUp;
            NewButton.Click += NewButton_Click;
            NewButton.MouseDown += NewButton_MouseDown;

            Button CloseButton = new Button();
            NewButton.Controls.Add(CloseButton);
            CloseButton.BackColor = buttonbackcolor;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft Sans Serif", 9.75F,FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = textcolor;
            CloseButton.Size = new Size(23, 25);
            CloseButton.MaximumSize = new Size(23, 25);
            CloseButton.Padding = new Padding(0, 4, 0, 0);
            CloseButton.TabIndex = TabIndex;
            CloseButton.Text = "X";
            CloseButton.TextAlign = ContentAlignment.MiddleRight;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Dock = DockStyle.Right;
            CloseButton.FlatAppearance.MouseDownBackColor = NewButton.BackColor;
            CloseButton.FlatAppearance.MouseOverBackColor = NewButton.BackColor;
            CloseButton.Click += CloseButton_Click;

            Panel Ribbon = new Panel();
            NewButton.Controls.Add(Ribbon);
            Ribbon.BackColor = ribbon;
            Ribbon.Location = new Point(635, 365);
            Ribbon.Name = "Ribbon";
            Ribbon.Size = new Size(NewButton.Width, ribbonheight);
            Ribbon.Dock = dockmethod;
            Ribbon.TabIndex = TabIndex;

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

            return NewButton;
        }

        public class NoFocusCueButton : Button
        {
            protected override bool ShowFocusCues
            {
                get
                {
                    return false;
                }
            }

            public override void NotifyDefault(bool value)
            {
                base.NotifyDefault(false);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button ButtonClicked = (Button)sender;
            SelectedTab = ButtonClicked as NoFocusCueButton;
            

            foreach (Panel Page in Tabs.Values)
            {
                Page.Visible = false;
            }

            foreach (Button TabButton in Tabs.Keys)
            {
                if (TabButton != ButtonClicked)
                {
                    TabButton.Controls[1].Visible = false;
                    TabButton.BackColor = buttonbackcolor;
                    TabButton.FlatAppearance.MouseDownBackColor = buttonbackcolor;
                    TabButton.FlatAppearance.MouseOverBackColor = buttonbackcolor;

                    Button CB = TabButton.Controls[0] as Button;
                    CB.BackColor = buttonbackcolor;
                    CB.FlatAppearance.MouseDownBackColor = buttonbackcolor;
                    CB.FlatAppearance.MouseOverBackColor = buttonbackcolor;

                    Tabs[ButtonClicked].Visible = true;
                }
                else
                {
                    TabButton.Controls[1].Visible = true;
                    TabButton.BackColor = clickcolor;
                    TabButton.FlatAppearance.MouseDownBackColor = clickcolor;
                    TabButton.FlatAppearance.MouseOverBackColor = clickcolor;

                    Button CB = TabButton.Controls[0] as Button;
                    CB.BackColor = clickcolor;
                    CB.FlatAppearance.MouseDownBackColor = clickcolor;
                    CB.FlatAppearance.MouseOverBackColor = clickcolor;
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
            int ButtonHeight = (sender as NoFocusCueButton).Height;
            if (ButtonHeight == 18 )
            {
                ButtonHolder.Size = new Size(ButtonHolder.Width, 55);
            }
            else if (ButtonHeight == 55)
            {
                ButtonHolder.Size = new Size(ButtonHolder.Width, 35);
                foreach (var Curr in ButtonHolder.Controls)
                {
                    var Button = Curr as Button;
                    AddTab.Size = new Size(35, 35);
                    Button.Size = new Size(Button.Width, 35);
                }
            }

            if (AddTab.Height == 55)
            {
                AddTab.Size = new Size(35, 35);
            }
        }

        private void NewButton_MouseUp(object sender, MouseEventArgs e)
        {
            NewButton_Click(sender, e);
            SelectedTab = (NoFocusCueButton)sender;
            PreDraggedTab = null;

            if (e.Button == MouseButtons.Right)
            {
                if (strip != null)
                {
                    strip.Show(Cursor.Position);
                }
            }
        }

        private void NewButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackupSelectedTab = (Button)sender;
        }

        public void Debug(params object[] Data)
        {
            string ToWrite = string.Join(" ", Data);
            Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss") + "] " + ToWrite);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Button CloseButtonClicked = (Button)sender;
            Button ParentButton = CloseButtonClicked.Parent as Button;

            if (SelectedTab == ParentButton)
            {
                int Index = Tabs.Values.ToList().IndexOf(Tabs[ParentButton]);

                try
                {
                    Tabs.Keys.ElementAt(Index - 1).PerformClick();
                }
                catch
                {
                    Tabs.Keys.ElementAt(Index).PerformClick();
                }
            }

            Tabs[ParentButton].Dispose();
            Tabs.Remove(ParentButton);
            ParentButton.Dispose();
        }

        public void ReName(string Text)
        {
            SelectedTab.Text = Text + "   ";
        }

        public Scintilla GetWorkingEditor()
        {
            bool Found = false;
            Scintilla Editor = new Scintilla();
            if (ButtonHolder.Controls.Count == 1)
            {
                CreateTab();
            }
            if (SelectedTab == BackupSelectedTab)
            {
                try
                {
                    Editor = Tabs[BackupSelectedTab].Controls[0] as Scintilla;
                }
                catch
                {
                    foreach (Panel pan in Tabs.Values)
                    {
                        if (pan.Visible)
                        {
                            Editor.Dispose();
                            Editor = pan.Controls[0] as Scintilla;
                            Found = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Panel pan in Tabs.Values)
                {
                    if (pan.Visible)
                    {
                        Editor.Dispose();
                        Editor = pan.Controls[0] as Scintilla;
                        Found = true;
                        break;
                    }
                }
            }
            if (!Found)
            {
                //Lets check once more :)

                foreach (Panel pan in Tabs.Values)
                {
                    if (pan.Visible)
                    {
                        SelectedTab = Tabs.FirstOrDefault(x => x.Value == pan).Key as NoFocusCueButton;
                        BackupSelectedTab = SelectedTab;
                        Editor = pan.Controls[0] as Scintilla;
                        return Editor;
                    }
                }

                return new Scintilla();
            }
            return Editor;
        }

        public void SavePointedTab()
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;
                string fuckme = SelectedTab.Text.Replace("   ", "");
                saveFileDialog.FileName = fuckme;


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                     System.IO.File.WriteAllText(saveFileDialog.FileName, GetWorkingEditor().Text);
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
                    using (System.IO.StreamReader Reader = new System.IO.StreamReader(open.FileName))
                    {
                        NoFocusCueButton Tab = CreateTab(open.SafeFileName, Reader.ReadToEnd());
                        Tab.PerformClick();
                        SelectedTab = Tab;
                        var scintilla = GetWorkingEditor();
                        var lineCount = scintilla.Lines.Count.ToString().Length;
                        scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 2;
                        
                    }
                }
            }
        }

        public IrisTabControl()
        {
            InitializeComponent();
            Container.BackColor = buttonbackcolor;
            ButtonHolder.BackColor = TopPannelColor;
            AddTab.ForeColor = textcolor;
            ButtonHolder.HorizontalScroll.Maximum = 500; 
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoFocusCueButton Button = CreateTab();
            SelectedTab = Button;
            BackupSelectedTab = Button;
            Button.PerformClick();
        }

    }
}
