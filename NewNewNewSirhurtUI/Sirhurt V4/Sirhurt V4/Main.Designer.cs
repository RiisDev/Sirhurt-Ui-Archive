using Newtonsoft.Json;
using Sirhurt_V4.Properties;
using SirhurtNewUI.MenuStripStuff;
using System.Reflection.Emit;
using static Sirhurt_V4.Controls.UIControls;

namespace Sirhurt_V4
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.ToggleSwitch.ToggleState toggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState4 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState5 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState6 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState7 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState8 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState9 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState10 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState11 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState12 = new Bunifu.ToggleSwitch.ToggleState();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SirhurtTitle = new System.Windows.Forms.Label();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themestoolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripSeparator1 = new SirhurtNewUI.MenuStripStuff.CustomToolStripSeparator();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripSeparator2 = new SirhurtNewUI.MenuStripStuff.CustomToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripSeparator4 = new SirhurtNewUI.MenuStripStuff.CustomToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killRobloxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.AsshurtIcon = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.irisTabControl1 = new WindowsFormsApp1.IrisTabControl();
            this.ImLazy = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.AstheticPanel = new System.Windows.Forms.Panel();
            this.Settings = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ScriptHub = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Attach = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ScriptListOpener = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.RunScript = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ScriptHubPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshScriptHub = new System.Windows.Forms.Button();
            this.ExecuteScriptHub = new System.Windows.Forms.Button();
            this.ScriptHubList = new System.Windows.Forms.ListBox();
            this.ScriptListHolder = new System.Windows.Forms.Panel();
            this.ScriptList = new System.Windows.Forms.TreeView();
            this.ScriptListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveToScriptsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.setParentToScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScriptListAdjust = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.CustomKeywordColor = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.EditorKeyword3Color = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.EditorKeyword2Color = new System.Windows.Forms.TextBox();
            this.EditorOperatorColor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.EditorKeyword1Color = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.EditorStringColor = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.EditorCommentColor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.EditorTextColor = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.EditorBackColor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.EditorIntColor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.autoattachchecked = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.label13 = new System.Windows.Forms.Label();
            this.multiappchecked = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.label12 = new System.Windows.Forms.Label();
            this.topmostchecked = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.fpsunlockchecked = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TopPanelColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TabClickedColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TabTextColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RibbonHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.RibbonColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BBackColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TabBackColor = new System.Windows.Forms.TextBox();
            this.TabControlContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.rereNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopPanel.SuspendLayout();
            this.MainStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptListOpener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunScript)).BeginInit();
            this.ScriptHubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ScriptListHolder.SuspendLayout();
            this.ScriptListContext.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.TabControlContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.SirhurtTitle);
            this.TopPanel.Controls.Add(this.MainStrip);
            this.TopPanel.Controls.Add(this.minimize);
            this.TopPanel.Controls.Add(this.close);
            this.TopPanel.Controls.Add(this.AsshurtIcon);
            this.bunifuTransition1.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(849, 31);
            this.TopPanel.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.TopPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.TopPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.TopPanel, "");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(385, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "https://sirhurt.net/";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // SirhurtTitle
            // 
            this.SirhurtTitle.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.SirhurtTitle, BunifuAnimatorNS.DecorationType.None);
            this.SirhurtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SirhurtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SirhurtTitle.Location = new System.Drawing.Point(300, 6);
            this.SirhurtTitle.Name = "SirhurtTitle";
            this.SirhurtTitle.Size = new System.Drawing.Size(62, 18);
            this.SirhurtTitle.TabIndex = 7;
            this.SirhurtTitle.Text = "SDFfsdf";
            this.bunifuToolTip1.SetToolTip(this.SirhurtTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.SirhurtTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.SirhurtTitle, "");
            // 
            // MainStrip
            // 
            this.bunifuTransition1.SetDecoration(this.MainStrip, BunifuAnimatorNS.DecorationType.None);
            this.MainStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem9,
            this.extensionsToolStripMenuItem,
            this.themestoolstripmenuitem,
            this.helpToolStripMenuItem});
            this.MainStrip.Location = new System.Drawing.Point(27, 4);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(208, 24);
            this.MainStrip.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.MainStrip, "");
            this.bunifuToolTip1.SetToolTipIcon(this.MainStrip, null);
            this.bunifuToolTip1.SetToolTipTitle(this.MainStrip, "");
            // 
            // Themes
            // 
            this.themestoolstripmenuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {});
            this.themestoolstripmenuitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.themestoolstripmenuitem.Name = "themestoolstripmenuitem";
            this.themestoolstripmenuitem.Size = new System.Drawing.Size(37, 20);
            this.themestoolstripmenuitem.Text = "Themes";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScriptToolStripMenuItem,
            this.customToolStripSeparator1,
            this.openFileToolStripMenuItem,
            this.customToolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.customToolStripSeparator4,
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newScriptToolStripMenuItem
            // 
            this.newScriptToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.newScriptToolStripMenuItem.Name = "newScriptToolStripMenuItem";
            this.newScriptToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newScriptToolStripMenuItem.Text = "New Script";
            this.newScriptToolStripMenuItem.ToolTipText = "Ctrl + N";
            this.newScriptToolStripMenuItem.Click += new System.EventHandler(this.newScriptToolStripMenuItem_Click);
            // 
            // customToolStripSeparator1
            // 
            this.customToolStripSeparator1.Name = "customToolStripSeparator1";
            this.customToolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.ToolTipText = "Ctrl + O";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // customToolStripSeparator2
            // 
            this.customToolStripSeparator2.Name = "customToolStripSeparator2";
            this.customToolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Ctrl + S";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.ToolTipText = "Ctrl + Shift + S";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // customToolStripSeparator4
            // 
            this.customToolStripSeparator4.Name = "customToolStripSeparator4";
            this.customToolStripSeparator4.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Alt + F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem9.Text = "View";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem10.Text = "Search";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem11.Text = "Appearance Settings";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // extensionsToolStripMenuItem
            // 
            this.extensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killRobloxToolStripMenuItem});
            this.extensionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.extensionsToolStripMenuItem.Name = "extensionsToolStripMenuItem";
            this.extensionsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.extensionsToolStripMenuItem.Text = "Extensions";
            // 
            // killRobloxToolStripMenuItem
            // 
            this.killRobloxToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem";
            this.killRobloxToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.killRobloxToolStripMenuItem.Text = "Kill Roblox";
            this.killRobloxToolStripMenuItem.Click += new System.EventHandler(this.killRobloxToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinDiscordToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // joinDiscordToolStripMenuItem
            // 
            this.joinDiscordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.joinDiscordToolStripMenuItem.Name = "joinDiscordToolStripMenuItem";
            this.joinDiscordToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.joinDiscordToolStripMenuItem.Text = "Join Discord";
            this.joinDiscordToolStripMenuItem.Click += new System.EventHandler(this.joinDiscordToolStripMenuItem_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(807, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(15, 15);
            this.minimize.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.minimize, "");
            this.bunifuToolTip1.SetToolTipIcon(this.minimize, null);
            this.bunifuToolTip1.SetToolTipTitle(this.minimize, "");
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(828, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 15);
            this.close.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.close, "");
            this.bunifuToolTip1.SetToolTipIcon(this.close, null);
            this.bunifuToolTip1.SetToolTipTitle(this.close, "");
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AsshurtIcon
            // 
            this.AsshurtIcon.BackgroundImage = global::Sirhurt_V4.Properties.Resources.asshurt2;
            this.AsshurtIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.AsshurtIcon, BunifuAnimatorNS.DecorationType.None);
            this.AsshurtIcon.Location = new System.Drawing.Point(3, 3);
            this.AsshurtIcon.Name = "AsshurtIcon";
            this.AsshurtIcon.Size = new System.Drawing.Size(28, 25);
            this.AsshurtIcon.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.AsshurtIcon, "");
            this.bunifuToolTip1.SetToolTipIcon(this.AsshurtIcon, null);
            this.bunifuToolTip1.SetToolTipTitle(this.AsshurtIcon, "");
            this.AsshurtIcon.Click += Main_Click;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label28, BunifuAnimatorNS.DecorationType.None);
            this.label28.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label28.Location = new System.Drawing.Point(0, 387);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 13);
            this.label28.TabIndex = 7;
            this.label28.Text = "v1.0.0";
            this.bunifuToolTip1.SetToolTip(this.label28, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label28, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label28, "");
            // 
            // irisTabControl1
            // 
            this.irisTabControl1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuTransition1.SetDecoration(this.irisTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.irisTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irisTabControl1.Location = new System.Drawing.Point(42, 31);
            this.irisTabControl1.MenuStripChosen = null;
            this.irisTabControl1.Name = "irisTabControl1";
            this.irisTabControl1.RibbonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.irisTabControl1.RibbonDock = System.Windows.Forms.DockStyle.Bottom;
            this.irisTabControl1.RibbonHeight = 3;
            this.irisTabControl1.Size = new System.Drawing.Size(803, 400);
            this.irisTabControl1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.irisTabControl1.TabIndex = 8;
            this.irisTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bunifuToolTip1.SetToolTip(this.irisTabControl1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.irisTabControl1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.irisTabControl1, "");
            this.irisTabControl1.TopClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.irisTabControl1.TopHpverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.irisTabControl1.TopPannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // ImLazy
            // 
            this.ImLazy.Fixed = true;
            this.ImLazy.Horizontal = true;
            this.ImLazy.TargetControl = this.TopPanel;
            this.ImLazy.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 4);
            this.panel1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMouseUp);
            // 
            // panel3
            // 
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(839, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 4);
            this.panel3.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel3, "");
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMouseUp);
            // 
            // panel2
            // 
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(845, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 400);
            this.panel2.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMouseUp);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = true;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 3000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 1000;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = "Test";
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.AstheticPanel);
            this.LeftPanel.Controls.Add(this.Settings);
            this.LeftPanel.Controls.Add(this.ScriptHub);
            this.LeftPanel.Controls.Add(this.Attach);
            this.LeftPanel.Controls.Add(this.ScriptListOpener);
            this.LeftPanel.Controls.Add(this.RunScript);
            this.LeftPanel.Controls.Add(this.label28);
            this.bunifuTransition1.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 31);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(42, 400);
            this.LeftPanel.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.LeftPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.LeftPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.LeftPanel, "");
            // 
            // AstheticPanel
            // 
            this.AstheticPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.bunifuTransition1.SetDecoration(this.AstheticPanel, BunifuAnimatorNS.DecorationType.None);
            this.AstheticPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AstheticPanel.Location = new System.Drawing.Point(0, 48);
            this.AstheticPanel.Name = "AstheticPanel";
            this.AstheticPanel.Size = new System.Drawing.Size(3, 30);
            this.AstheticPanel.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.AstheticPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.AstheticPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.AstheticPanel, "");
            this.AstheticPanel.Visible = false;
            // 
            // Settings
            // 
            this.Settings.AllowFocused = false;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Settings.BorderRadius = 50;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Settings, BunifuAnimatorNS.DecorationType.None);
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.Image = global::Sirhurt_V4.Properties.Resources.SettingsHolder;
            this.Settings.IsCircle = true;
            this.Settings.Location = new System.Drawing.Point(0, 168);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(42, 42);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 4;
            this.Settings.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.Settings, "UI Settings");
            this.bunifuToolTip1.SetToolTipIcon(this.Settings, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Settings, "");
            this.Settings.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.Settings.MouseEnter += new System.EventHandler(this.Settings_MouseEnter);
            this.Settings.MouseLeave += new System.EventHandler(this.Settings_MouseLeave);
            this.Settings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMouseUp);
            // 
            // ScriptHub
            // 
            this.ScriptHub.AllowFocused = false;
            this.ScriptHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ScriptHub.BorderRadius = 0;
            this.ScriptHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ScriptHub, BunifuAnimatorNS.DecorationType.None);
            this.ScriptHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScriptHub.Image = global::Sirhurt_V4.Properties.Resources.ScriptHub;
            this.ScriptHub.IsCircle = false;
            this.ScriptHub.Location = new System.Drawing.Point(0, 126);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Size = new System.Drawing.Size(42, 42);
            this.ScriptHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScriptHub.TabIndex = 3;
            this.ScriptHub.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.ScriptHub, "Sirhurt Scripthub");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptHub, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptHub, "");
            this.ScriptHub.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ScriptHub.Click += new System.EventHandler(this.ScriptHub_Click);
            this.ScriptHub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.ScriptHub.MouseEnter += new System.EventHandler(this.LeftPanel_MouseEnter);
            this.ScriptHub.MouseLeave += new System.EventHandler(this.LeftPanel_MouseLeave);
            this.ScriptHub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // Attach
            // 
            this.Attach.AllowFocused = false;
            this.Attach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Attach.BorderRadius = 0;
            this.Attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Attach, BunifuAnimatorNS.DecorationType.None);
            this.Attach.Dock = System.Windows.Forms.DockStyle.Top;
            this.Attach.Image = global::Sirhurt_V4.Properties.Resources.bitmap;
            this.Attach.IsCircle = false;
            this.Attach.Location = new System.Drawing.Point(0, 84);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(42, 42);
            this.Attach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attach.TabIndex = 1;
            this.Attach.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.Attach, "Attach");
            this.bunifuToolTip1.SetToolTipIcon(this.Attach, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Attach, "");
            this.Attach.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            this.Attach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.Attach.MouseLeave += new System.EventHandler(this.LeftPanel_MouseLeave);
            this.Attach.MouseHover += new System.EventHandler(this.LeftPanel_MouseEnter);
            this.Attach.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // ScriptListOpener
            // 
            this.ScriptListOpener.AllowFocused = false;
            this.ScriptListOpener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScriptListOpener.BorderRadius = 50;
            this.ScriptListOpener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ScriptListOpener, BunifuAnimatorNS.DecorationType.None);
            this.ScriptListOpener.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScriptListOpener.Image = global::Sirhurt_V4.Properties.Resources.explorer1;
            this.ScriptListOpener.IsCircle = true;
            this.ScriptListOpener.Location = new System.Drawing.Point(0, 42);
            this.ScriptListOpener.Name = "ScriptListOpener";
            this.ScriptListOpener.Size = new System.Drawing.Size(42, 42);
            this.ScriptListOpener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScriptListOpener.TabIndex = 5;
            this.ScriptListOpener.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.ScriptListOpener, "Open\'s the script list");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptListOpener, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptListOpener, "");
            this.ScriptListOpener.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ScriptListOpener.Click += new System.EventHandler(this.ScriptListOpener_Click);
            this.ScriptListOpener.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.ScriptListOpener.MouseEnter += new System.EventHandler(this.LeftPanel_MouseEnter);
            this.ScriptListOpener.MouseLeave += new System.EventHandler(this.LeftPanel_MouseLeave);
            this.ScriptListOpener.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // RunScript
            // 
            this.RunScript.AllowFocused = false;
            this.RunScript.BorderRadius = 0;
            this.RunScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.RunScript, BunifuAnimatorNS.DecorationType.None);
            this.RunScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.RunScript.Image = global::Sirhurt_V4.Properties.Resources.Execute;
            this.RunScript.IsCircle = false;
            this.RunScript.Location = new System.Drawing.Point(0, 0);
            this.RunScript.Name = "RunScript";
            this.RunScript.Size = new System.Drawing.Size(42, 42);
            this.RunScript.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RunScript.TabIndex = 2;
            this.RunScript.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.RunScript, "Run Script");
            this.bunifuToolTip1.SetToolTipIcon(this.RunScript, null);
            this.bunifuToolTip1.SetToolTipTitle(this.RunScript, "");
            this.RunScript.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.RunScript.Click += new System.EventHandler(this.RunScript_Click);
            this.RunScript.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.RunScript.MouseEnter += new System.EventHandler(this.LeftPanel_MouseEnter);
            this.RunScript.MouseLeave += new System.EventHandler(this.LeftPanel_MouseLeave);
            this.RunScript.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // ScriptHubPanel
            // 
            this.ScriptHubPanel.Controls.Add(this.richTextBox1);
            this.ScriptHubPanel.Controls.Add(this.pictureBox1);
            this.ScriptHubPanel.Controls.Add(this.RefreshScriptHub);
            this.ScriptHubPanel.Controls.Add(this.ExecuteScriptHub);
            this.ScriptHubPanel.Controls.Add(this.ScriptHubList);
            this.bunifuTransition1.SetDecoration(this.ScriptHubPanel, BunifuAnimatorNS.DecorationType.None);
            this.ScriptHubPanel.Location = new System.Drawing.Point(42, 31);
            this.ScriptHubPanel.Name = "ScriptHubPanel";
            this.ScriptHubPanel.Size = new System.Drawing.Size(807, 404);
            this.ScriptHubPanel.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.ScriptHubPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptHubPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptHubPanel, "");
            this.ScriptHubPanel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.richTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.richTextBox1.Location = new System.Drawing.Point(391, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(303, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.bunifuToolTip1.SetToolTip(this.richTextBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.richTextBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.richTextBox1, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(377, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            this.pictureBox1.Click += Main_Click;
            // 
            // RefreshScriptHub
            // 
            this.RefreshScriptHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RefreshScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bunifuTransition1.SetDecoration(this.RefreshScriptHub, BunifuAnimatorNS.DecorationType.None);
            this.RefreshScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshScriptHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RefreshScriptHub.Location = new System.Drawing.Point(48, 325);
            this.RefreshScriptHub.Name = "RefreshScriptHub";
            this.RefreshScriptHub.Size = new System.Drawing.Size(196, 23);
            this.RefreshScriptHub.TabIndex = 2;
            this.RefreshScriptHub.Text = "Refresh List";
            this.bunifuToolTip1.SetToolTip(this.RefreshScriptHub, "Refresh ScriptHub");
            this.bunifuToolTip1.SetToolTipIcon(this.RefreshScriptHub, null);
            this.bunifuToolTip1.SetToolTipTitle(this.RefreshScriptHub, "");
            this.RefreshScriptHub.UseVisualStyleBackColor = false;
            this.RefreshScriptHub.Click += new System.EventHandler(this.RefreshScriptHub_Click);
            // 
            // ExecuteScriptHub
            // 
            this.ExecuteScriptHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExecuteScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bunifuTransition1.SetDecoration(this.ExecuteScriptHub, BunifuAnimatorNS.DecorationType.None);
            this.ExecuteScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteScriptHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ExecuteScriptHub.Location = new System.Drawing.Point(48, 296);
            this.ExecuteScriptHub.Name = "ExecuteScriptHub";
            this.ExecuteScriptHub.Size = new System.Drawing.Size(196, 23);
            this.ExecuteScriptHub.TabIndex = 1;
            this.ExecuteScriptHub.Text = "Execute";
            this.bunifuToolTip1.SetToolTip(this.ExecuteScriptHub, "Execute selected item on the scripthub");
            this.bunifuToolTip1.SetToolTipIcon(this.ExecuteScriptHub, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ExecuteScriptHub, "");
            this.ExecuteScriptHub.UseVisualStyleBackColor = false;
            this.ExecuteScriptHub.Click += new System.EventHandler(this.ExecuteScriptHub_Click);
            // 
            // ScriptHubList
            // 
            this.ScriptHubList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScriptHubList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ScriptHubList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.ScriptHubList, BunifuAnimatorNS.DecorationType.None);
            this.ScriptHubList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ScriptHubList.FormattingEnabled = true;
            this.ScriptHubList.Location = new System.Drawing.Point(37, 15);
            this.ScriptHubList.Name = "ScriptHubList";
            this.ScriptHubList.Size = new System.Drawing.Size(216, 275);
            this.ScriptHubList.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.ScriptHubList, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptHubList, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptHubList, "");
            this.ScriptHubList.SelectedIndexChanged += new System.EventHandler(this.ScriptHubList_SelectedIndexChanged);
            // 
            // ScriptListHolder
            // 
            this.ScriptListHolder.Controls.Add(this.ScriptList);
            this.ScriptListHolder.Controls.Add(this.ScriptListAdjust);
            this.bunifuTransition1.SetDecoration(this.ScriptListHolder, BunifuAnimatorNS.DecorationType.None);
            this.ScriptListHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScriptListHolder.Location = new System.Drawing.Point(42, 31);
            this.ScriptListHolder.Name = "ScriptListHolder";
            this.ScriptListHolder.Size = new System.Drawing.Size(0, 400);
            this.ScriptListHolder.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.ScriptListHolder, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptListHolder, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptListHolder, "");
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.ContextMenuStrip = this.ScriptListContext;
            this.bunifuTransition1.SetDecoration(this.ScriptList, BunifuAnimatorNS.DecorationType.None);
            this.ScriptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ScriptList.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ScriptList.Location = new System.Drawing.Point(0, 0);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(0, 400);
            this.ScriptList.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.ScriptList, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptList, null);
            
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptList, "");
            this.ScriptList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ScriptList_NodeMouseClick);
            this.ScriptList.DoubleClick += new System.EventHandler(this.ScriptList_DoubleClick);
            this.ScriptList.BeforeExpand += ScriptList_BeforeExpand;
            this.ScriptList.AfterCollapse += ScriptList_AfterCollapse;
            // 
            // ScriptListContext
            // 
            this.bunifuTransition1.SetDecoration(this.ScriptListContext, BunifuAnimatorNS.DecorationType.None);
            this.ScriptListContext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScriptListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToScriptsMenuStrip,
            this.setParentToScriptsToolStripMenuItem,
            this.createFolderToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ScriptListContext.Name = "contextMenuStrip2";
            this.ScriptListContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ScriptListContext.Size = new System.Drawing.Size(181, 92);
            this.bunifuToolTip1.SetToolTip(this.ScriptListContext, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptListContext, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptListContext, "");
            // 
            // SaveToScriptsMenuStrip
            // 
            this.SaveToScriptsMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SaveToScriptsMenuStrip.Name = "SaveToScriptsMenuStrip";
            this.SaveToScriptsMenuStrip.Size = new System.Drawing.Size(180, 22);
            this.SaveToScriptsMenuStrip.Text = "Save To Scripts";
            this.SaveToScriptsMenuStrip.Click += new System.EventHandler(this.SaveToScriptsMenuStrip_Click);
            // 
            // setParentToScriptsToolStripMenuItem
            // 
            this.setParentToScriptsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.setParentToScriptsToolStripMenuItem.Name = "setParentToScriptsToolStripMenuItem";
            this.setParentToScriptsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setParentToScriptsToolStripMenuItem.Text = "Set Parent To Scripts";
            this.setParentToScriptsToolStripMenuItem.Click += new System.EventHandler(this.setParentToScriptsToolStripMenuItem_Click);
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createFolderToolStripMenuItem.Text = "Create Folder";
            this.createFolderToolStripMenuItem.Click += new System.EventHandler(this.createFolderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ScriptListAdjust
            // 
            this.ScriptListAdjust.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.bunifuTransition1.SetDecoration(this.ScriptListAdjust, BunifuAnimatorNS.DecorationType.None);
            this.ScriptListAdjust.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScriptListAdjust.Location = new System.Drawing.Point(-5, 0);
            this.ScriptListAdjust.Name = "ScriptListAdjust";
            this.ScriptListAdjust.Size = new System.Drawing.Size(5, 400);
            this.ScriptListAdjust.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.ScriptListAdjust, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ScriptListAdjust, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ScriptListAdjust, "");
            this.ScriptListAdjust.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScriptListAdjust_MouseDown);
            this.ScriptListAdjust.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScriptListAdjust_MouseMove);
            this.ScriptListAdjust.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScriptListAdjust_MouseUp);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPanel.Controls.Add(this.bunifuSeparator2);
            this.SettingsPanel.Controls.Add(this.label26);
            this.SettingsPanel.Controls.Add(this.label27);
            this.SettingsPanel.Controls.Add(this.CustomKeywordColor);
            this.SettingsPanel.Controls.Add(this.label25);
            this.SettingsPanel.Controls.Add(this.EditorKeyword3Color);
            this.SettingsPanel.Controls.Add(this.label24);
            this.SettingsPanel.Controls.Add(this.EditorKeyword2Color);
            this.SettingsPanel.Controls.Add(this.EditorOperatorColor);
            this.SettingsPanel.Controls.Add(this.label17);
            this.SettingsPanel.Controls.Add(this.EditorKeyword1Color);
            this.SettingsPanel.Controls.Add(this.label18);
            this.SettingsPanel.Controls.Add(this.label19);
            this.SettingsPanel.Controls.Add(this.EditorStringColor);
            this.SettingsPanel.Controls.Add(this.label20);
            this.SettingsPanel.Controls.Add(this.EditorCommentColor);
            this.SettingsPanel.Controls.Add(this.label21);
            this.SettingsPanel.Controls.Add(this.EditorTextColor);
            this.SettingsPanel.Controls.Add(this.label22);
            this.SettingsPanel.Controls.Add(this.EditorBackColor);
            this.SettingsPanel.Controls.Add(this.label23);
            this.SettingsPanel.Controls.Add(this.EditorIntColor);
            this.SettingsPanel.Controls.Add(this.label16);
            this.SettingsPanel.Controls.Add(this.label15);
            this.SettingsPanel.Controls.Add(this.label14);
            this.SettingsPanel.Controls.Add(this.autoattachchecked);
            this.SettingsPanel.Controls.Add(this.label13);
            this.SettingsPanel.Controls.Add(this.multiappchecked);
            this.SettingsPanel.Controls.Add(this.label12);
            this.SettingsPanel.Controls.Add(this.topmostchecked);
            this.SettingsPanel.Controls.Add(this.label11);
            this.SettingsPanel.Controls.Add(this.fpsunlockchecked);
            this.SettingsPanel.Controls.Add(this.label10);
            this.SettingsPanel.Controls.Add(this.button1);
            this.SettingsPanel.Controls.Add(this.label9);
            this.SettingsPanel.Controls.Add(this.TopPanelColor);
            this.SettingsPanel.Controls.Add(this.label8);
            this.SettingsPanel.Controls.Add(this.TabClickedColor);
            this.SettingsPanel.Controls.Add(this.label7);
            this.SettingsPanel.Controls.Add(this.TabTextColor);
            this.SettingsPanel.Controls.Add(this.label6);
            this.SettingsPanel.Controls.Add(this.RibbonHeight);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.bunifuSeparator3);
            this.SettingsPanel.Controls.Add(this.RibbonColor);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.BBackColor);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label5);
            this.SettingsPanel.Controls.Add(this.bunifuSeparator1);
            this.SettingsPanel.Controls.Add(this.TabBackColor);
            this.bunifuTransition1.SetDecoration(this.SettingsPanel, BunifuAnimatorNS.DecorationType.None);
            this.SettingsPanel.Location = new System.Drawing.Point(42, 31);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(803, 400);
            this.SettingsPanel.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.SettingsPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.SettingsPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.SettingsPanel, "");
            this.SettingsPanel.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(284, 34);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 325);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator2, "");
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label26.Location = new System.Drawing.Point(290, 274);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(166, 18);
            this.label26.TabIndex = 48;
            this.label26.Text = "Custom Word Color";
            this.bunifuToolTip1.SetToolTip(this.label26, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label26, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label26, "");
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label27, BunifuAnimatorNS.DecorationType.None);
            this.label27.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label27.Location = new System.Drawing.Point(300, 310);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(252, 36);
            this.label27.TabIndex = 50;
            this.label27.Text = "Custom keywords can be\r\neditted in the settings.ini file\r\n";
            this.bunifuToolTip1.SetToolTip(this.label27, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label27, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label27, "");
            // 
            // CustomKeywordColor
            // 
            this.CustomKeywordColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomKeywordColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CustomKeywordColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.CustomKeywordColor, BunifuAnimatorNS.DecorationType.None);
            this.CustomKeywordColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CustomKeywordColor.Location = new System.Drawing.Point(456, 275);
            this.CustomKeywordColor.Multiline = true;
            this.CustomKeywordColor.Name = "CustomKeywordColor";
            this.CustomKeywordColor.Size = new System.Drawing.Size(100, 20);
            this.CustomKeywordColor.TabIndex = 49;
            this.bunifuToolTip1.SetToolTip(this.CustomKeywordColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.CustomKeywordColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.CustomKeywordColor, "");
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label25.Location = new System.Drawing.Point(306, 251);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 18);
            this.label25.TabIndex = 46;
            this.label25.Text = "Keyword3 Color";
            this.bunifuToolTip1.SetToolTip(this.label25, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label25, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label25, "");
            // 
            // EditorKeyword3Color
            // 
            this.EditorKeyword3Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorKeyword3Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorKeyword3Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorKeyword3Color, BunifuAnimatorNS.DecorationType.None);
            this.EditorKeyword3Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorKeyword3Color.Location = new System.Drawing.Point(456, 249);
            this.EditorKeyword3Color.Multiline = true;
            this.EditorKeyword3Color.Name = "EditorKeyword3Color";
            this.EditorKeyword3Color.Size = new System.Drawing.Size(100, 20);
            this.EditorKeyword3Color.TabIndex = 47;
            this.bunifuToolTip1.SetToolTip(this.EditorKeyword3Color, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorKeyword3Color, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorKeyword3Color, "");
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label24.Location = new System.Drawing.Point(306, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 18);
            this.label24.TabIndex = 44;
            this.label24.Text = "Keyword2 Color";
            this.bunifuToolTip1.SetToolTip(this.label24, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label24, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label24, "");
            // 
            // EditorKeyword2Color
            // 
            this.EditorKeyword2Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorKeyword2Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorKeyword2Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorKeyword2Color, BunifuAnimatorNS.DecorationType.None);
            this.EditorKeyword2Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorKeyword2Color.Location = new System.Drawing.Point(456, 223);
            this.EditorKeyword2Color.Multiline = true;
            this.EditorKeyword2Color.Name = "EditorKeyword2Color";
            this.EditorKeyword2Color.Size = new System.Drawing.Size(100, 20);
            this.EditorKeyword2Color.TabIndex = 45;
            this.bunifuToolTip1.SetToolTip(this.EditorKeyword2Color, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorKeyword2Color, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorKeyword2Color, "");
            // 
            // EditorOperatorColor
            // 
            this.EditorOperatorColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorOperatorColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorOperatorColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorOperatorColor, BunifuAnimatorNS.DecorationType.None);
            this.EditorOperatorColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorOperatorColor.Location = new System.Drawing.Point(456, 171);
            this.EditorOperatorColor.Multiline = true;
            this.EditorOperatorColor.Name = "EditorOperatorColor";
            this.EditorOperatorColor.Size = new System.Drawing.Size(100, 20);
            this.EditorOperatorColor.TabIndex = 41;
            this.bunifuToolTip1.SetToolTip(this.EditorOperatorColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorOperatorColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorOperatorColor, "");
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label17.Location = new System.Drawing.Point(308, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 18);
            this.label17.TabIndex = 42;
            this.label17.Text = "Keyword1 Color";
            this.bunifuToolTip1.SetToolTip(this.label17, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label17, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label17, "");
            // 
            // EditorKeyword1Color
            // 
            this.EditorKeyword1Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorKeyword1Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorKeyword1Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorKeyword1Color, BunifuAnimatorNS.DecorationType.None);
            this.EditorKeyword1Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorKeyword1Color.Location = new System.Drawing.Point(456, 197);
            this.EditorKeyword1Color.Multiline = true;
            this.EditorKeyword1Color.Name = "EditorKeyword1Color";
            this.EditorKeyword1Color.Size = new System.Drawing.Size(100, 20);
            this.EditorKeyword1Color.TabIndex = 43;
            this.bunifuToolTip1.SetToolTip(this.EditorKeyword1Color, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorKeyword1Color, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorKeyword1Color, "");
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label18.Location = new System.Drawing.Point(308, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 18);
            this.label18.TabIndex = 40;
            this.label18.Text = "Operator Color";
            this.bunifuToolTip1.SetToolTip(this.label18, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label18, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label18, "");
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label19.Location = new System.Drawing.Point(308, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 18);
            this.label19.TabIndex = 38;
            this.label19.Text = "String Color";
            this.bunifuToolTip1.SetToolTip(this.label19, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label19, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label19, "");
            // 
            // EditorStringColor
            // 
            this.EditorStringColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorStringColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorStringColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorStringColor, BunifuAnimatorNS.DecorationType.None);
            this.EditorStringColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorStringColor.Location = new System.Drawing.Point(456, 145);
            this.EditorStringColor.Multiline = true;
            this.EditorStringColor.Name = "EditorStringColor";
            this.EditorStringColor.Size = new System.Drawing.Size(100, 20);
            this.EditorStringColor.TabIndex = 39;
            this.bunifuToolTip1.SetToolTip(this.EditorStringColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorStringColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorStringColor, "");
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label20.Location = new System.Drawing.Point(308, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 18);
            this.label20.TabIndex = 36;
            this.label20.Text = "Int Color";
            this.bunifuToolTip1.SetToolTip(this.label20, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label20, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label20, "");
            // 
            // EditorCommentColor
            // 
            this.EditorCommentColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorCommentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorCommentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorCommentColor, BunifuAnimatorNS.DecorationType.None);
            this.EditorCommentColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorCommentColor.Location = new System.Drawing.Point(456, 93);
            this.EditorCommentColor.Multiline = true;
            this.EditorCommentColor.Name = "EditorCommentColor";
            this.EditorCommentColor.Size = new System.Drawing.Size(100, 20);
            this.EditorCommentColor.TabIndex = 35;
            this.bunifuToolTip1.SetToolTip(this.EditorCommentColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorCommentColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorCommentColor, "");
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label21.Location = new System.Drawing.Point(306, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 18);
            this.label21.TabIndex = 34;
            this.label21.Text = "Comment Color";
            this.bunifuToolTip1.SetToolTip(this.label21, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label21, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label21, "");
            // 
            // EditorTextColor
            // 
            this.EditorTextColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorTextColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorTextColor, BunifuAnimatorNS.DecorationType.None);
            this.EditorTextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorTextColor.Location = new System.Drawing.Point(456, 69);
            this.EditorTextColor.Multiline = true;
            this.EditorTextColor.Name = "EditorTextColor";
            this.EditorTextColor.Size = new System.Drawing.Size(100, 20);
            this.EditorTextColor.TabIndex = 33;
            this.bunifuToolTip1.SetToolTip(this.EditorTextColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorTextColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorTextColor, "");
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label22.Location = new System.Drawing.Point(308, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 18);
            this.label22.TabIndex = 32;
            this.label22.Text = "Text Color";
            this.bunifuToolTip1.SetToolTip(this.label22, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label22, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label22, "");
            // 
            // EditorBackColor
            // 
            this.EditorBackColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorBackColor, BunifuAnimatorNS.DecorationType.None);
            this.EditorBackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorBackColor.Location = new System.Drawing.Point(456, 45);
            this.EditorBackColor.Multiline = true;
            this.EditorBackColor.Name = "EditorBackColor";
            this.EditorBackColor.Size = new System.Drawing.Size(100, 20);
            this.EditorBackColor.TabIndex = 31;
            this.bunifuToolTip1.SetToolTip(this.EditorBackColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorBackColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorBackColor, "");
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label23.Location = new System.Drawing.Point(308, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 18);
            this.label23.TabIndex = 30;
            this.label23.Text = "Back Color";
            this.bunifuToolTip1.SetToolTip(this.label23, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label23, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label23, "");
            // 
            // EditorIntColor
            // 
            this.EditorIntColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorIntColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.EditorIntColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.EditorIntColor, BunifuAnimatorNS.DecorationType.None);
            this.EditorIntColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EditorIntColor.Location = new System.Drawing.Point(456, 119);
            this.EditorIntColor.Multiline = true;
            this.EditorIntColor.Name = "EditorIntColor";
            this.EditorIntColor.Size = new System.Drawing.Size(100, 20);
            this.EditorIntColor.TabIndex = 37;
            this.bunifuToolTip1.SetToolTip(this.EditorIntColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.EditorIntColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.EditorIntColor, "");
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label16.Location = new System.Drawing.Point(326, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(201, 18);
            this.label16.TabIndex = 29;
            this.label16.Text = "Scintilla Editor Settings";
            this.bunifuToolTip1.SetToolTip(this.label16, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label16, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label16, "");
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label15.Location = new System.Drawing.Point(582, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Does not require restart";
            this.bunifuToolTip1.SetToolTip(this.label15, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label15, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label15, "");
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label14.Location = new System.Drawing.Point(580, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Auto Attach";
            this.bunifuToolTip1.SetToolTip(this.label14, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label14, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label14, "");
            // 
            // autoattachchecked
            // 
            this.autoattachchecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoattachchecked.Animation = 5;
            this.autoattachchecked.BackColor = System.Drawing.Color.Transparent;
            this.autoattachchecked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autoattachchecked.BackgroundImage")));
            this.autoattachchecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.autoattachchecked, BunifuAnimatorNS.DecorationType.None);
            this.autoattachchecked.Location = new System.Drawing.Point(741, 127);
            this.autoattachchecked.Name = "autoattachchecked";
            this.autoattachchecked.Size = new System.Drawing.Size(39, 20);
            this.autoattachchecked.TabIndex = 26;
            toggleState1.BackColor = System.Drawing.Color.Empty;
            toggleState1.BackColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState1.BorderColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderRadius = 1;
            toggleState1.BorderRadiusInner = 1;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.autoattachchecked.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Gray;
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.Gray;
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 15;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.autoattachchecked.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 15;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.autoattachchecked.ToggleStateOn = toggleState3;
            this.bunifuToolTip1.SetToolTip(this.autoattachchecked, "");
            this.bunifuToolTip1.SetToolTipIcon(this.autoattachchecked, null);
            this.bunifuToolTip1.SetToolTipTitle(this.autoattachchecked, "");
            this.autoattachchecked.Value = false;
            this.autoattachchecked.OnValuechange += new System.EventHandler(this.Toggle_OnValuechange);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label13.Location = new System.Drawing.Point(580, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Multi-Application";
            this.bunifuToolTip1.SetToolTip(this.label13, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label13, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label13, "");
            // 
            // multiappchecked
            // 
            this.multiappchecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiappchecked.Animation = 5;
            this.multiappchecked.BackColor = System.Drawing.Color.Transparent;
            this.multiappchecked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiappchecked.BackgroundImage")));
            this.multiappchecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.multiappchecked, BunifuAnimatorNS.DecorationType.None);
            this.multiappchecked.Location = new System.Drawing.Point(741, 99);
            this.multiappchecked.Name = "multiappchecked";
            this.multiappchecked.Size = new System.Drawing.Size(39, 20);
            this.multiappchecked.TabIndex = 24;
            toggleState4.BackColor = System.Drawing.Color.Empty;
            toggleState4.BackColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState4.BorderColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderRadius = 1;
            toggleState4.BorderRadiusInner = 1;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.multiappchecked.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.Gray;
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.Gray;
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 15;
            toggleState5.BorderThickness = 1;
            toggleState5.BorderThicknessInner = 1;
            this.multiappchecked.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 15;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.multiappchecked.ToggleStateOn = toggleState6;
            this.bunifuToolTip1.SetToolTip(this.multiappchecked, "");
            this.bunifuToolTip1.SetToolTipIcon(this.multiappchecked, null);
            this.bunifuToolTip1.SetToolTipTitle(this.multiappchecked, "");
            this.multiappchecked.Value = false;
            this.multiappchecked.OnValuechange += new System.EventHandler(this.Toggle_OnValuechange);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label12.Location = new System.Drawing.Point(580, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "TopMost";
            this.bunifuToolTip1.SetToolTip(this.label12, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label12, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label12, "");
            // 
            // topmostchecked
            // 
            this.topmostchecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topmostchecked.Animation = 5;
            this.topmostchecked.BackColor = System.Drawing.Color.Transparent;
            this.topmostchecked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topmostchecked.BackgroundImage")));
            this.topmostchecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.topmostchecked, BunifuAnimatorNS.DecorationType.None);
            this.topmostchecked.Location = new System.Drawing.Point(741, 71);
            this.topmostchecked.Name = "topmostchecked";
            this.topmostchecked.Size = new System.Drawing.Size(39, 20);
            this.topmostchecked.TabIndex = 22;
            toggleState7.BackColor = System.Drawing.Color.Empty;
            toggleState7.BackColorInner = System.Drawing.Color.Empty;
            toggleState7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState7.BorderColorInner = System.Drawing.Color.Empty;
            toggleState7.BorderRadius = 1;
            toggleState7.BorderRadiusInner = 1;
            toggleState7.BorderThickness = 1;
            toggleState7.BorderThicknessInner = 1;
            this.topmostchecked.ToggleStateDisabled = toggleState7;
            toggleState8.BackColor = System.Drawing.Color.Gray;
            toggleState8.BackColorInner = System.Drawing.Color.White;
            toggleState8.BorderColor = System.Drawing.Color.Gray;
            toggleState8.BorderColorInner = System.Drawing.Color.White;
            toggleState8.BorderRadius = 17;
            toggleState8.BorderRadiusInner = 15;
            toggleState8.BorderThickness = 1;
            toggleState8.BorderThicknessInner = 1;
            this.topmostchecked.ToggleStateOff = toggleState8;
            toggleState9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState9.BackColorInner = System.Drawing.Color.White;
            toggleState9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState9.BorderColorInner = System.Drawing.Color.White;
            toggleState9.BorderRadius = 17;
            toggleState9.BorderRadiusInner = 15;
            toggleState9.BorderThickness = 1;
            toggleState9.BorderThicknessInner = 1;
            this.topmostchecked.ToggleStateOn = toggleState9;
            this.bunifuToolTip1.SetToolTip(this.topmostchecked, "");
            this.bunifuToolTip1.SetToolTipIcon(this.topmostchecked, null);
            this.bunifuToolTip1.SetToolTipTitle(this.topmostchecked, "");
            this.topmostchecked.Value = true;
            this.topmostchecked.OnValuechange += new System.EventHandler(this.Toggle_OnValuechange);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label11.Location = new System.Drawing.Point(580, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "FPS Unlocker";
            this.bunifuToolTip1.SetToolTip(this.label11, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label11, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label11, "");
            // 
            // fpsunlockchecked
            // 
            this.fpsunlockchecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpsunlockchecked.Animation = 5;
            this.fpsunlockchecked.BackColor = System.Drawing.Color.Transparent;
            this.fpsunlockchecked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fpsunlockchecked.BackgroundImage")));
            this.fpsunlockchecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.fpsunlockchecked, BunifuAnimatorNS.DecorationType.None);
            this.fpsunlockchecked.Location = new System.Drawing.Point(741, 42);
            this.fpsunlockchecked.Name = "fpsunlockchecked";
            this.fpsunlockchecked.Size = new System.Drawing.Size(39, 20);
            this.fpsunlockchecked.TabIndex = 20;
            toggleState10.BackColor = System.Drawing.Color.Empty;
            toggleState10.BackColorInner = System.Drawing.Color.Empty;
            toggleState10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState10.BorderColorInner = System.Drawing.Color.Empty;
            toggleState10.BorderRadius = 1;
            toggleState10.BorderRadiusInner = 1;
            toggleState10.BorderThickness = 1;
            toggleState10.BorderThicknessInner = 1;
            this.fpsunlockchecked.ToggleStateDisabled = toggleState10;
            toggleState11.BackColor = System.Drawing.Color.Gray;
            toggleState11.BackColorInner = System.Drawing.Color.White;
            toggleState11.BorderColor = System.Drawing.Color.Gray;
            toggleState11.BorderColorInner = System.Drawing.Color.White;
            toggleState11.BorderRadius = 17;
            toggleState11.BorderRadiusInner = 15;
            toggleState11.BorderThickness = 1;
            toggleState11.BorderThicknessInner = 1;
            this.fpsunlockchecked.ToggleStateOff = toggleState11;
            toggleState12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState12.BackColorInner = System.Drawing.Color.White;
            toggleState12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            toggleState12.BorderColorInner = System.Drawing.Color.White;
            toggleState12.BorderRadius = 17;
            toggleState12.BorderRadiusInner = 15;
            toggleState12.BorderThickness = 1;
            toggleState12.BorderThicknessInner = 1;
            this.fpsunlockchecked.ToggleStateOn = toggleState12;
            this.bunifuToolTip1.SetToolTip(this.fpsunlockchecked, "");
            this.bunifuToolTip1.SetToolTipIcon(this.fpsunlockchecked, null);
            this.bunifuToolTip1.SetToolTipTitle(this.fpsunlockchecked, "");
            this.fpsunlockchecked.Value = false;
            this.fpsunlockchecked.OnValuechange += new System.EventHandler(this.Toggle_OnValuechange);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label10.Location = new System.Drawing.Point(612, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Extra UI Settings";
            this.bunifuToolTip1.SetToolTip(this.label10, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label10, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label10, "");
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button1.Location = new System.Drawing.Point(14, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(774, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Apply Changes (Will restart the UI)";
            this.bunifuToolTip1.SetToolTip(this.button1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.button1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.button1, "");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label9.Location = new System.Drawing.Point(18, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Top Tab Color";
            this.bunifuToolTip1.SetToolTip(this.label9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label9, "");
            // 
            // TopPanelColor
            // 
            this.TopPanelColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopPanelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TopPanelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.TopPanelColor, BunifuAnimatorNS.DecorationType.None);
            this.TopPanelColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TopPanelColor.Location = new System.Drawing.Point(178, 205);
            this.TopPanelColor.Multiline = true;
            this.TopPanelColor.Name = "TopPanelColor";
            this.TopPanelColor.Size = new System.Drawing.Size(100, 20);
            this.TopPanelColor.TabIndex = 17;
            this.bunifuToolTip1.SetToolTip(this.TopPanelColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.TopPanelColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.TopPanelColor, "");
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(18, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tab Clicked Color";
            this.bunifuToolTip1.SetToolTip(this.label8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label8, "");
            // 
            // TabClickedColor
            // 
            this.TabClickedColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabClickedColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TabClickedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.TabClickedColor, BunifuAnimatorNS.DecorationType.None);
            this.TabClickedColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TabClickedColor.Location = new System.Drawing.Point(178, 178);
            this.TabClickedColor.Multiline = true;
            this.TabClickedColor.Name = "TabClickedColor";
            this.TabClickedColor.Size = new System.Drawing.Size(100, 20);
            this.TabClickedColor.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.TabClickedColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.TabClickedColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.TabClickedColor, "");
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(17, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tab Text Color";
            this.bunifuToolTip1.SetToolTip(this.label7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label7, "");
            // 
            // TabTextColor
            // 
            this.TabTextColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabTextColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TabTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.TabTextColor, BunifuAnimatorNS.DecorationType.None);
            this.TabTextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TabTextColor.Location = new System.Drawing.Point(178, 152);
            this.TabTextColor.Multiline = true;
            this.TabTextColor.Name = "TabTextColor";
            this.TabTextColor.Size = new System.Drawing.Size(100, 20);
            this.TabTextColor.TabIndex = 13;
            this.bunifuToolTip1.SetToolTip(this.TabTextColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.TabTextColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.TabTextColor, "");
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tab Back Color";
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            // 
            // RibbonHeight
            // 
            this.RibbonHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RibbonHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.RibbonHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.RibbonHeight, BunifuAnimatorNS.DecorationType.None);
            this.RibbonHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RibbonHeight.Location = new System.Drawing.Point(178, 100);
            this.RibbonHeight.Multiline = true;
            this.RibbonHeight.Name = "RibbonHeight";
            this.RibbonHeight.Size = new System.Drawing.Size(100, 20);
            this.RibbonHeight.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.RibbonHeight, "");
            this.bunifuToolTip1.SetToolTipIcon(this.RibbonHeight, null);
            this.bunifuToolTip1.SetToolTipTitle(this.RibbonHeight, "");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ribbon Height";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(556, 34);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(18, 325);
            this.bunifuSeparator3.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator3, "");
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // RibbonColor
            // 
            this.RibbonColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RibbonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.RibbonColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.RibbonColor, BunifuAnimatorNS.DecorationType.None);
            this.RibbonColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RibbonColor.Location = new System.Drawing.Point(178, 74);
            this.RibbonColor.Multiline = true;
            this.RibbonColor.Name = "RibbonColor";
            this.RibbonColor.Size = new System.Drawing.Size(100, 20);
            this.RibbonColor.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.RibbonColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.RibbonColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.RibbonColor, "");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ribbon Color";
            this.bunifuToolTip1.SetToolTip(this.label4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label4, "");
            // 
            // BBackColor
            // 
            this.BBackColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.BBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.BBackColor, BunifuAnimatorNS.DecorationType.None);
            this.BBackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BBackColor.Location = new System.Drawing.Point(179, 48);
            this.BBackColor.Multiline = true;
            this.BBackColor.Name = "BBackColor";
            this.BBackColor.Size = new System.Drawing.Size(100, 20);
            this.BBackColor.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.BBackColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.BBackColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.BBackColor, "");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Button Back Color";
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(39, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tab Control Settings";
            this.bunifuToolTip1.SetToolTip(this.label5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label5, "");
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(30, 25);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(774, 15);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // TabBackColor
            // 
            this.TabBackColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TabBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.TabBackColor, BunifuAnimatorNS.DecorationType.None);
            this.TabBackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TabBackColor.Location = new System.Drawing.Point(178, 126);
            this.TabBackColor.Multiline = true;
            this.TabBackColor.Name = "TabBackColor";
            this.TabBackColor.Size = new System.Drawing.Size(100, 20);
            this.TabBackColor.TabIndex = 11;
            this.bunifuToolTip1.SetToolTip(this.TabBackColor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.TabBackColor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.TabBackColor, "");
            // 
            // TabControlContext
            // 
            this.bunifuTransition1.SetDecoration(this.TabControlContext, BunifuAnimatorNS.DecorationType.None);
            this.TabControlContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reNameToolStripMenuItem});
            this.TabControlContext.Name = "contextMenuStrip1";
            this.TabControlContext.Size = new System.Drawing.Size(118, 26);
            this.bunifuToolTip1.SetToolTip(this.TabControlContext, "");
            this.bunifuToolTip1.SetToolTipIcon(this.TabControlContext, null);
            this.bunifuToolTip1.SetToolTipTitle(this.TabControlContext, "");
            // 
            // reNameToolStripMenuItem
            // 
            this.reNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.reNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.reNameToolStripMenuItem.Name = "reNameToolStripMenuItem";
            this.reNameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.reNameToolStripMenuItem.Text = "Rename";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // rereNameToolStripMenuItem
            // 
            this.rereNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.rereNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rereNameToolStripMenuItem.Name = "rereNameToolStripMenuItem";
            this.rereNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rereNameToolStripMenuItem.Text = "ReName";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.close;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.minimize;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.SirhurtTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(849, 435);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.ScriptHubPanel);
            this.Controls.Add(this.irisTabControl1);
            this.Controls.Add(this.ScriptListHolder);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Sirhurt_V4.Properties.Resources.MainIco;
            this.MinimumSize = new System.Drawing.Size(564, 280);
            this.Name = "Main";
            this.Text = "Sirhurt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.LocationChanged += Main_LocationChanged;
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptListOpener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunScript)).EndInit();
            this.ScriptHubPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ScriptListHolder.ResumeLayout(false);
            this.ScriptListContext.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.TabControlContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuDragControl ImLazy;
        private System.Windows.Forms.Panel AsshurtIcon;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themestoolstripmenuitem;
        private System.Windows.Forms.ToolStripMenuItem newScriptToolStripMenuItem;
        private SirhurtNewUI.MenuStripStuff.CustomToolStripSeparator customToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private SirhurtNewUI.MenuStripStuff.CustomToolStripSeparator customToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private SirhurtNewUI.MenuStripStuff.CustomToolStripSeparator customToolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killRobloxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinDiscordToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        public System.Windows.Forms.ContextMenuStrip ScriptListContext;
        private System.Windows.Forms.ToolStripMenuItem SaveToScriptsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private WindowsFormsApp1.IrisTabControl irisTabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SirhurtTitle;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.Panel LeftPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox Attach;
        private Bunifu.UI.WinForms.BunifuPictureBox RunScript;
        private Bunifu.UI.WinForms.BunifuPictureBox ScriptHub;
        private System.Windows.Forms.Panel ScriptHubPanel;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuPictureBox Settings;
        private Bunifu.UI.WinForms.BunifuPictureBox ScriptListOpener;
        private System.Windows.Forms.Panel ScriptListHolder;
        private System.Windows.Forms.Panel ScriptListAdjust;
        private System.Windows.Forms.TreeView ScriptList;
        private System.Windows.Forms.Panel AstheticPanel;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button RefreshScriptHub;
        private System.Windows.Forms.Button ExecuteScriptHub;
        private System.Windows.Forms.ListBox ScriptHubList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SettingsPanel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox BBackColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RibbonHeight;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox RibbonColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Label label69;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch fpsunlockchecked;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TopPanelColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TabClickedColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TabTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TabBackColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch autoattachchecked;
        private System.Windows.Forms.Label label13;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch multiappchecked;
        private System.Windows.Forms.Label label12;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch topmostchecked;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EditorOperatorColor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EditorKeyword1Color;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox EditorStringColor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox EditorCommentColor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox EditorTextColor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox EditorBackColor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox EditorIntColor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox CustomKeywordColor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox EditorKeyword3Color;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox EditorKeyword2Color;
        private System.Windows.Forms.ToolStripMenuItem reNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ContextMenuStrip TabControlContext;
        private System.Windows.Forms.ToolStripMenuItem setParentToScriptsToolStripMenuItem;
        private CustomToolStripSeparator customToolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rereNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label28;
    }
}

