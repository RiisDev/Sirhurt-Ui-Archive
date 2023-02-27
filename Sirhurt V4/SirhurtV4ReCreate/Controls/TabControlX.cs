using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using SirhurtV4ReCreate.Classes;
using SirhurtV4ReCreate.Properties;

namespace SirhurtV4ReCreate.Controls
{
    public partial class TabControlX : UserControl
    {
        public int A2 = Settings.Default.A2;


        private readonly List<string> btstrlist = new List<string>();
        public int ButtonIndex;
        public List<ButtonX> buttonlist = new List<ButtonX>();
        public Point Clicked;
        public int plsindex;
        public Color RibbonColour = Color.FromArgb(20, 120, 240);
        public Dictionary<int, Scintilla> Scintillas = new Dictionary<int, Scintilla>();
        public int Scints;
        public int selected_index = -1;
        public Color SelectedTabBackColour = Color.FromArgb(20, 120, 240);

        public Color SelectedTabTextColour = Color.White;
        private Size tab_size = new Size(110, 30);
        public Color TabClickColour = Color.FromArgb(20, 80, 200);
        public Color TabControlBackColour = Color.FromArgb(40, 40, 40);
        public Color TabControlPanelBackColour = Color.FromArgb(30, 30, 30);

        public Color TabHoverColour = Color.FromArgb(20, 120, 240);
        public List<TabPanelControl> tabPanelCtrlList = new List<TabPanelControl>();

        private int txt_x_loc = 10, txt_y_loc = 5;
        public Color UnSelectedTabBackColour = Color.FromArgb(40, 40, 40);

        public Color UnSelectedTabTextColour = Color.White;

        public TabControlX()
        {
            InitializeComponent();
        }

        public Size TabSize
        {
            get => tab_size;
            set
            {
                tab_size = value;
                setHeight();
                Invalidate();
            }
        }

        public Color SelTabForeColor
        {
            get => SelectedTabTextColour;
            set
            {
                SelectedTabTextColour = value;
                Invalidate();
            }
        }

        public Color UnSelTabForeColor
        {
            get => UnSelectedTabTextColour;
            set
            {
                UnSelectedTabTextColour = value;
                Invalidate();
            }
        }

        public Color SelTabBackColor
        {
            get => SelectedTabBackColour;
            set
            {
                SelectedTabBackColour = value;
                Invalidate();
            }
        }

        public Color UnSelTabBackColor
        {
            get => Color.FromArgb(30, 30, 30);
            set
            {
                UnSelectedTabBackColour = Color.FromArgb(30, 30, 30);
                Invalidate();
            }
        }

        public Color MouseHrTabColor
        {
            get => TabHoverColour;
            set
            {
                TabHoverColour = value;
                Invalidate();
            }
        }

        public Color MouseClkTabColor
        {
            get => TabClickColour;
            set
            {
                TabClickColour = value;
                Invalidate();
            }
        }

        public int X_TextLoc
        {
            get => txt_x_loc;
            set
            {
                txt_x_loc = value;
                Invalidate();
            }
        }

        public int Y_TextLoc
        {
            get => txt_y_loc;
            set
            {
                txt_y_loc = value;
                Invalidate();
            }
        }


        public Color CtrlPanelColor
        {
            get => TabControlBackColour;
            set
            {
                TabPanel.BackColor = value;
                TabControlBackColour = value;
                Invalidate();
            }
        }

        public Color TabPanelColor
        {
            get => TabControlPanelBackColour;
            set
            {
                BackTopPanel.BackColor = value;
                TabButtonPanel.BackColor = value;
                TabControlPanelBackColour = value;
                Invalidate();
            }
        }

        private void setHeight()
        {
            if (!buttonlist.Any())
            {
                BackTopPanel.Height = tab_size.Height;
                TabButtonPanel.Height = tab_size.Height;
            }
            else
            {
                BackTopPanel.Height = buttonlist[0].Height;
                TabButtonPanel.Height = buttonlist[0].Height;
            }
        }

        public int SelectedTabIndex()
        {
            return selected_index;
        }

        public int TabCount()
        {
            return buttonlist.Count;
        }


        public void ChangeTabText(string newtext, int index)
        {
            var but = buttonlist[index];
            but.Text = newtext;
        }


        private void createAndAddButton(string tabtext, TabPanelControl tpcontrol, Point loc)
        {
            var b = new ButtonX();
            b.DisplayText = tabtext;
            b.Text = tabtext;
            b.Size = tab_size;
            b.Location = loc;
            b.ForeColor = SelectedTabTextColour;
            b.BXBackColor = SelectedTabBackColour;
            b.MouseHoverColor = SelectedTabBackColour;
            b.MouseClickColor1 = SelectedTabBackColour;
            b.ChangeColorMouseHC = false;
            b.TextLocation_X = txt_x_loc;
            b.TextLocation_Y = txt_y_loc;
            b.Font = Font;
            b.Click += button_Click;
            b.Name = tabtext;
            TabButtonPanel.Controls.Add(b);
            buttonlist.Add(b);
            selected_index++;

            tabPanelCtrlList.Add(tpcontrol);
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tpcontrol);
            TabPanel.Controls[0].Name = b.Name;
            Scints++;
            Scintillas.Add(Scints, TabPanel.Controls[0].Controls[0] as Scintilla);

            UpdateButtons();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var btext = ((ButtonX) sender).Name;

            int index = 0, i;
            for (i = 0; i < buttonlist.Count; i++)
                if (buttonlist[i].Name == btext)
                    index = i;
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tabPanelCtrlList[index]);
            selected_index = ((ButtonX) sender).TabIndex;

            UpdateButtons();
        }


        public void AddTab(string tabtext, TabPanelControl tpcontrol)
        {
            if (!buttonlist.Any())
                createAndAddButton(tabtext, tpcontrol, new Point(0, 0));
            else
                createAndAddButton(tabtext, tpcontrol,
                    new Point(buttonlist[buttonlist.Count - 1].Size.Width + buttonlist[buttonlist.Count - 1].Location.X,
                        0));
        }


        public void UpdateButtons()
        {
            if (buttonlist.Count > 0)
                for (var i = 0; i < buttonlist.Count; i++)
                {
                    buttonlist[i].Size =
                        new Size(TextRenderer.MeasureText(" " + buttonlist[i].Name, buttonlist[i].Font).Width + 40, 30);
                    if (i == selected_index)
                    {
                        plsindex = i;
                        buttonlist[i].ChangeColorMouseHC = false;
                        buttonlist[i].BXBackColor = SelectedTabBackColour;
                        buttonlist[i].ForeColor = SelectedTabTextColour;
                        buttonlist[i].MouseHoverColor = SelectedTabBackColour;
                        buttonlist[i].MouseClickColor1 = SelectedTabBackColour;
                        buttonlist[i].Text = " " + buttonlist[i].Name;

                        var panel = new Panel();
                        panel.Size = new Size(13, 13);
                        panel.BackgroundImage = Resources.Close_WhiteNoHalo_16x;
                        panel.BackgroundImageLayout = ImageLayout.Stretch;
                        panel.Location =
                            new Point(
                                buttonlist[i].TextLocation_X - 6 +
                                TextRenderer.MeasureText(buttonlist[i].Text, buttonlist[i].Font).Width + 15,
                                buttonlist[i].TextLocation_Y + 2);
                        panel.MouseClick += Panel_MouseClick;
                        panel.BackColor = Color.Transparent;
                        panel.Name = buttonlist[i].Name;
                        buttonlist[i].Controls.Clear();
                        buttonlist[i].Controls.Add(panel);
                        buttonlist[i].TextLocation_X = txt_x_loc;
                        buttonlist[i].TextLocation_Y = txt_y_loc + 2;
                    }
                    else
                    {
                        buttonlist[i].ChangeColorMouseHC = true;
                        buttonlist[i].ForeColor = UnSelectedTabTextColour;
                        buttonlist[i].MouseHoverColor = TabHoverColour;
                        buttonlist[i].BXBackColor = UnSelectedTabBackColour;
                        buttonlist[i].BackColor = UnSelectedTabBackColour;
                        buttonlist[i].MouseClickColor1 = TabClickColour;
                        buttonlist[i].Text = buttonlist[i].Text.Replace(" ", "");
                        buttonlist[i].Controls.Clear();
                        buttonlist[i].TextLocation_X = 4;
                        buttonlist[i].TextLocation_Y = 7;
                    }
                }
        }

        private void toolStripButton1_DropDownOpening(object sender, EventArgs e)
        {
        }


        private async void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            ((Panel) sender).BackgroundImage = Resources.Close_WhiteNoHalo_12x_16x;
            await Task.Delay(50);
            ((Panel) sender).BackgroundImage = Resources.Close_WhiteNoHalo_16x;

            if (buttonlist.Count > 1)
            {
                RemoveTab(selected_index);
                Settings.Default.A2--;
            }
        }

        private void tbr_Click(object sender, EventArgs e)
        {
            int i;
            for (var k = 0; k < ((ToolStripMenuItem) sender).MergeIndex; k++)
            {
                var j = 0;
                for (i = ((ToolStripMenuItem) sender).MergeIndex; i >= 0; i--)
                {
                    var but = buttonlist[i];
                    var temp = buttonlist[j];
                    buttonlist[i] = temp;
                    buttonlist[j] = but;

                    var uct1 = tabPanelCtrlList[i];
                    var tempusr = tabPanelCtrlList[j];
                    tabPanelCtrlList[i] = tempusr;
                    tabPanelCtrlList[j] = uct1;
                }
            }

            var btext = ((ToolStripMenuItem) sender).Text;
            BackToFront_SelButton();
            selected_index = 0;
            TabPanel.Controls.Add(tabPanelCtrlList[buttonlist[0].TabIndex]);
            UpdateButtons();
        }

        public void RemoveTab(int index)
        {
            if (index >= 0 && buttonlist.Count > 0 && index < buttonlist.Count)
            {
                buttonlist.RemoveAt(index);
                tabPanelCtrlList.RemoveAt(index);
                BackToFront_SelButton();
                if (buttonlist.Count > 1)
                {
                    if (index - 1 >= 0)
                    {
                        TabPanel.Controls.Add(tabPanelCtrlList[index - 1]);
                    }
                    else
                    {
                        TabPanel.Controls.Add(tabPanelCtrlList[index - 1 + 1]);
                        selected_index = index - 1 + 1;
                    }
                }

                selected_index = index - 1;

                if (buttonlist.Count == 1)
                {
                    TabPanel.Controls.Add(tabPanelCtrlList[0]);
                    selected_index = 0;
                }
            }

            UpdateButtons();
        }

        private void BackToFront_SelButton()
        {
            var i = 0;

            TabButtonPanel.Controls.Clear();
            btstrlist.Clear();
            for (i = 0; i < buttonlist.Count; i++) btstrlist.Add(buttonlist[i].Name);

            buttonlist.Clear();

            for (var j = 0; j < btstrlist.Count; j++)
                if (j == 0)
                {
                    var b = new ButtonX();
                    b.DisplayText = btstrlist[j];
                    b.Name = btstrlist[j];
                    b.Text = b.Name;
                    b.Size = tab_size;
                    b.Location = new Point(0, 0);
                    b.ForeColor = SelectedTabTextColour;
                    b.BXBackColor = SelectedTabBackColour;
                    b.MouseHoverColor = SelectedTabBackColour;
                    b.MouseClickColor1 = SelectedTabBackColour;
                    b.ChangeColorMouseHC = false;
                    b.TextLocation_X = txt_x_loc;
                    b.TextLocation_Y = txt_y_loc;
                    b.Font = Font;
                    b.Click += button_Click;


                    TabButtonPanel.Controls.Add(b);
                    buttonlist.Add(b);

                    selected_index++;
                }
                else if (j > 0)
                {
                    var b = new ButtonX();
                    b.DisplayText = btstrlist[j];
                    b.Name = btstrlist[j];
                    b.Text = b.Name;
                    b.Size = tab_size;
                    b.ForeColor = SelectedTabTextColour;
                    b.BXBackColor = SelectedTabBackColour;
                    b.MouseHoverColor = SelectedTabBackColour;
                    b.MouseClickColor1 = SelectedTabBackColour;
                    b.ChangeColorMouseHC = false;
                    b.TextLocation_X = txt_x_loc;
                    b.TextLocation_Y = txt_y_loc;
                    b.Font = Font;
                    b.Click += button_Click;
                    b.Location = new Point(buttonlist[j - 1].Size.Width + buttonlist[j - 1].Location.X, 0);
                    TabButtonPanel.Controls.Add(b);
                    buttonlist.Add(b);
                    selected_index++;
                }

            TabPanel.Controls.Clear();
        }
    }
}