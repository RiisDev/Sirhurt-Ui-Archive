using System.Drawing;
using System.Windows.Forms;

namespace SirhurtUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openIntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InjectUwU = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SizeDown = new System.Windows.Forms.Panel();
            this.All = new System.Windows.Forms.Panel();
            this.RightSize = new System.Windows.Forms.Panel();
            this.TabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ScriptView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.execToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.owOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoAttachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScriptFolderPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Noclip = new Bunifu.Framework.UI.BunifuImageButton();
            this.InfinityHub = new Bunifu.Framework.UI.BunifuImageButton();
            this.ESP = new Bunifu.Framework.UI.BunifuImageButton();
            this.InfiniteYield = new Bunifu.Framework.UI.BunifuImageButton();
            this.SirhurtHub = new Bunifu.Framework.UI.BunifuImageButton();
            this.Dex = new Bunifu.Framework.UI.BunifuImageButton();
            this.RemoteSpy = new Bunifu.Framework.UI.BunifuImageButton();
            this.SaveGame = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customTabControl1 = new SirhurtUI.Controls.CustomTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.SizeDown.SuspendLayout();
            this.TabContextMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Noclip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfinityHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfiniteYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SirhurtHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveGame)).BeginInit();
            this.customTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabName});
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // newTabName
            // 
            this.newTabName.Name = "newTabName";
            this.newTabName.Size = new System.Drawing.Size(100, 23);
            this.newTabName.Text = "untitled";
            this.newTabName.TextChanged += new System.EventHandler(this.NewTabNameTextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemHandler);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(124, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItemHandler);
            // 
            // openIntoToolStripMenuItem
            // 
            this.openIntoToolStripMenuItem.Name = "openIntoToolStripMenuItem";
            this.openIntoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openIntoToolStripMenuItem.Text = "Open Into";
            this.openIntoToolStripMenuItem.Click += new System.EventHandler(this.OpenIntoToolStripMenuItemHandler);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemHandler);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.InjectUwU);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 29);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 29);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // InjectUwU
            // 
            this.InjectUwU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InjectUwU.AutoSize = true;
            this.InjectUwU.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectUwU.ForeColor = System.Drawing.Color.Red;
            this.InjectUwU.Location = new System.Drawing.Point(351, 5);
            this.InjectUwU.Name = "InjectUwU";
            this.InjectUwU.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.InjectUwU.Size = new System.Drawing.Size(54, 23);
            this.InjectUwU.TabIndex = 4;
            this.InjectUwU.Text = "Offline";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(698, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.Button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(727, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.Button1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SirHurt V2";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SizeDown
            // 
            this.SizeDown.Controls.Add(this.All);
            this.SizeDown.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.SizeDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SizeDown.Location = new System.Drawing.Point(0, 365);
            this.SizeDown.MaximumSize = new System.Drawing.Size(0, 10);
            this.SizeDown.MinimumSize = new System.Drawing.Size(0, 10);
            this.SizeDown.Name = "SizeDown";
            this.SizeDown.Size = new System.Drawing.Size(756, 10);
            this.SizeDown.TabIndex = 2;
            this.SizeDown.Paint += new System.Windows.Forms.PaintEventHandler(this.SizeDown_Paint);
            this.SizeDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseDown);
            this.SizeDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseMove);
            this.SizeDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseUp);
            // 
            // All
            // 
            this.All.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.All.Dock = System.Windows.Forms.DockStyle.Right;
            this.All.Location = new System.Drawing.Point(746, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(10, 10);
            this.All.TabIndex = 0;
            this.All.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseDown);
            this.All.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseMove);
            this.All.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseUp);
            // 
            // RightSize
            // 
            this.RightSize.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.RightSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSize.Location = new System.Drawing.Point(746, 29);
            this.RightSize.Name = "RightSize";
            this.RightSize.Size = new System.Drawing.Size(10, 336);
            this.RightSize.TabIndex = 3;
            this.RightSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseDown);
            this.RightSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseMove);
            this.RightSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizeDown_MouseUp);
            // 
            // TabContextMenu
            // 
            this.TabContextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem,
            this.toolStripSeparator4,
            this.clearToolStripMenuItem,
            this.openIntoToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.TabContextMenu.Name = "contextMenuStrip2";
            this.TabContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TabContextMenu.Size = new System.Drawing.Size(128, 126);
            this.TabContextMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.NewTabNameClosed);
            this.TabContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TabContextMenuOpening);
            // 
            // ScriptView
            // 
            this.ScriptView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ScriptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptView.ContextMenuStrip = this.contextMenuStrip1;
            this.ScriptView.ForeColor = System.Drawing.Color.White;
            this.ScriptView.Location = new System.Drawing.Point(596, 57);
            this.ScriptView.Name = "ScriptView";
            this.ScriptView.Size = new System.Drawing.Size(144, 208);
            this.ScriptView.TabIndex = 4;
            this.ScriptView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ScriptView_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePathToolStripMenuItem,
            this.execToolStripMenuItem,
            this.deleteFileToolStripMenuItem,
            this.changePathToolStripMenuItem1,
            this.reloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 114);
            // 
            // changePathToolStripMenuItem
            // 
            this.changePathToolStripMenuItem.Name = "changePathToolStripMenuItem";
            this.changePathToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.changePathToolStripMenuItem.Text = "Execute";
            this.changePathToolStripMenuItem.Click += new System.EventHandler(this.ChangePathToolStripMenuItem_Click);
            // 
            // execToolStripMenuItem
            // 
            this.execToolStripMenuItem.Name = "execToolStripMenuItem";
            this.execToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.execToolStripMenuItem.Text = "Load Into Editor";
            this.execToolStripMenuItem.Click += new System.EventHandler(this.ExecToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete File";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.DeleteFileToolStripMenuItem_Click);
            // 
            // changePathToolStripMenuItem1
            // 
            this.changePathToolStripMenuItem1.Name = "changePathToolStripMenuItem1";
            this.changePathToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.changePathToolStripMenuItem1.Text = "Change Path";
            this.changePathToolStripMenuItem1.Click += new System.EventHandler(this.ChangePathToolStripMenuItem1_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton5);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 31);
            this.panel2.TabIndex = 7;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.InjectUwU;
            this.bunifuDragControl2.Vertical = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.owOToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // owOToolStripMenuItem
            // 
            this.owOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.owOToolStripMenuItem.Name = "owOToolStripMenuItem";
            this.owOToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.owOToolStripMenuItem.Text = "Inject";
            this.owOToolStripMenuItem.Click += new System.EventHandler(this.OwOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Force Quit Roblox";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoAttachToolStripMenuItem,
            this.topMostToolStripMenuItem,
            this.changeScriptFolderPathToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.viewToolStripMenuItem.Text = "Settings";
            // 
            // autoAttachToolStripMenuItem
            // 
            this.autoAttachToolStripMenuItem.CheckOnClick = true;
            this.autoAttachToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.autoAttachToolStripMenuItem.Name = "autoAttachToolStripMenuItem";
            this.autoAttachToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.autoAttachToolStripMenuItem.Text = "Auto Attach";
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Checked = true;
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.TopMostToolStripMenuItem_Click);
            // 
            // changeScriptFolderPathToolStripMenuItem
            // 
            this.changeScriptFolderPathToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeScriptFolderPathToolStripMenuItem.Name = "changeScriptFolderPathToolStripMenuItem";
            this.changeScriptFolderPathToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.changeScriptFolderPathToolStripMenuItem.Text = "Change Script Folder Path";
            this.changeScriptFolderPathToolStripMenuItem.Click += new System.EventHandler(this.ChangePathToolStripMenuItem1_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pluginsToolStripMenuItem.Text = "Script Hub";
            this.pluginsToolStripMenuItem.Click += new System.EventHandler(this.PluginsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Noclip
            // 
            this.Noclip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Noclip.BackColor = System.Drawing.Color.Transparent;
            this.Noclip.Image = global::SirhurtUI.Properties.Resources._448493;
            this.Noclip.ImageActive = null;
            this.Noclip.Location = new System.Drawing.Point(602, 302);
            this.Noclip.Name = "Noclip";
            this.Noclip.Size = new System.Drawing.Size(30, 30);
            this.Noclip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noclip.TabIndex = 23;
            this.Noclip.TabStop = false;
            this.Noclip.Zoom = 10;
            this.Noclip.Click += new System.EventHandler(this.Noclip_Click);
            // 
            // InfinityHub
            // 
            this.InfinityHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfinityHub.BackColor = System.Drawing.Color.Transparent;
            this.InfinityHub.Image = global::SirhurtUI.Properties.Resources.np_2;
            this.InfinityHub.ImageActive = global::SirhurtUI.Properties.Resources.np_2;
            this.InfinityHub.Location = new System.Drawing.Point(602, 271);
            this.InfinityHub.Name = "InfinityHub";
            this.InfinityHub.Size = new System.Drawing.Size(30, 30);
            this.InfinityHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfinityHub.TabIndex = 22;
            this.InfinityHub.TabStop = false;
            this.InfinityHub.Zoom = 20;
            this.InfinityHub.Click += new System.EventHandler(this.InfinityHub_Click);
            // 
            // ESP
            // 
            this.ESP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ESP.BackColor = System.Drawing.Color.Transparent;
            this.ESP.Image = global::SirhurtUI.Properties.Resources.ESP1;
            this.ESP.ImageActive = null;
            this.ESP.Location = new System.Drawing.Point(710, 302);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(30, 30);
            this.ESP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP.TabIndex = 21;
            this.ESP.TabStop = false;
            this.ESP.Zoom = 10;
            this.ESP.Click += new System.EventHandler(this.ESP_Click);
            // 
            // InfiniteYield
            // 
            this.InfiniteYield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfiniteYield.BackColor = System.Drawing.Color.Transparent;
            this.InfiniteYield.Image = global::SirhurtUI.Properties.Resources.InfiniteYield;
            this.InfiniteYield.ImageActive = null;
            this.InfiniteYield.Location = new System.Drawing.Point(674, 302);
            this.InfiniteYield.Name = "InfiniteYield";
            this.InfiniteYield.Size = new System.Drawing.Size(30, 30);
            this.InfiniteYield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfiniteYield.TabIndex = 20;
            this.InfiniteYield.TabStop = false;
            this.InfiniteYield.Zoom = 10;
            this.InfiniteYield.Click += new System.EventHandler(this.InfiniteYield_Click);
            // 
            // SirhurtHub
            // 
            this.SirhurtHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SirhurtHub.BackColor = System.Drawing.Color.Transparent;
            this.SirhurtHub.Image = global::SirhurtUI.Properties.Resources.ScriptHub;
            this.SirhurtHub.ImageActive = null;
            this.SirhurtHub.Location = new System.Drawing.Point(638, 302);
            this.SirhurtHub.Name = "SirhurtHub";
            this.SirhurtHub.Size = new System.Drawing.Size(30, 30);
            this.SirhurtHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SirhurtHub.TabIndex = 19;
            this.SirhurtHub.TabStop = false;
            this.SirhurtHub.Zoom = 10;
            this.SirhurtHub.Click += new System.EventHandler(this.SirhurtHub_Click);
            // 
            // Dex
            // 
            this.Dex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dex.BackColor = System.Drawing.Color.Transparent;
            this.Dex.Image = global::SirhurtUI.Properties.Resources.DEX_Explorer;
            this.Dex.ImageActive = null;
            this.Dex.Location = new System.Drawing.Point(710, 271);
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(30, 30);
            this.Dex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dex.TabIndex = 18;
            this.Dex.TabStop = false;
            this.Dex.Zoom = 10;
            this.Dex.Click += new System.EventHandler(this.Dex_Click);
            // 
            // RemoteSpy
            // 
            this.RemoteSpy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoteSpy.BackColor = System.Drawing.Color.Transparent;
            this.RemoteSpy.Image = global::SirhurtUI.Properties.Resources.RemoteSpy;
            this.RemoteSpy.ImageActive = null;
            this.RemoteSpy.Location = new System.Drawing.Point(674, 271);
            this.RemoteSpy.Name = "RemoteSpy";
            this.RemoteSpy.Size = new System.Drawing.Size(30, 30);
            this.RemoteSpy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoteSpy.TabIndex = 17;
            this.RemoteSpy.TabStop = false;
            this.RemoteSpy.Zoom = 10;
            this.RemoteSpy.Click += new System.EventHandler(this.RemoteSpy_Click);
            // 
            // SaveGame
            // 
            this.SaveGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveGame.BackColor = System.Drawing.Color.Transparent;
            this.SaveGame.Image = global::SirhurtUI.Properties.Resources.SaveGame;
            this.SaveGame.ImageActive = null;
            this.SaveGame.Location = new System.Drawing.Point(638, 271);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(30, 30);
            this.SaveGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SaveGame.TabIndex = 16;
            this.SaveGame.TabStop = false;
            this.SaveGame.Zoom = 10;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Open File";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::SirhurtUI.Properties.Resources.image1;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 30D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(186, 3);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(90, 25);
            this.bunifuFlatButton5.TabIndex = 10;
            this.bunifuFlatButton5.Text = "Open File";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.BunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Inject";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::SirhurtUI.Properties.Resources.rocket_blast_png_18;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 30D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(372, 3);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bunifuFlatButton4.MaximumSize = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton4.MinimumSize = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.Text = "Inject";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.BunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Save File";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::SirhurtUI.Properties.Resources.icons8_send_file_40;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 30D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(279, 3);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(90, 25);
            this.bunifuFlatButton3.TabIndex = 8;
            this.bunifuFlatButton3.Text = "Save File";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "New";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::SirhurtUI.Properties.Resources.icons8_new_file_80;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 30D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(99, 3);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bunifuFlatButton2.MaximumSize = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton2.MinimumSize = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "New";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Execute";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::SirhurtUI.Properties.Resources._41sc29FSaEL__UX522_;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 20D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 3);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bunifuFlatButton1.MaximumSize = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton1.MinimumSize = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(84, 25);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Execute";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // customTabControl1
            // 
            this.customTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.customTabControl1.AllowDrop = true;
            this.customTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.customTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customTabControl1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.customTabControl1.ClosingMessage = null;
            this.customTabControl1.Controls.Add(this.tabPage3);
            this.customTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.customTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.customTabControl1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.customTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.customTabControl1.Location = new System.Drawing.Point(12, 56);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customTabControl1.ShowClosingButton = true;
            this.customTabControl1.ShowClosingMessage = true;
            this.customTabControl1.Size = new System.Drawing.Size(578, 276);
            this.customTabControl1.TabIndex = 3;
            this.customTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 252);
            this.tabPage3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(756, 375);
            this.Controls.Add(this.Noclip);
            this.Controls.Add(this.InfinityHub);
            this.Controls.Add(this.ESP);
            this.Controls.Add(this.InfiniteYield);
            this.Controls.Add(this.SirhurtHub);
            this.Controls.Add(this.Dex);
            this.Controls.Add(this.RemoteSpy);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ScriptView);
            this.Controls.Add(this.customTabControl1);
            this.Controls.Add(this.RightSize);
            this.Controls.Add(this.SizeDown);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(756, 375);
            this.Name = "Form1";
            this.Text = "SirHurt V2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SizeDown.ResumeLayout(false);
            this.TabContextMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Noclip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfinityHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfiniteYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SirhurtHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveGame)).EndInit();
            this.customTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox newTabName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openIntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel SizeDown;
        private System.Windows.Forms.Panel RightSize;
        private System.Windows.Forms.Panel All;
        public System.Windows.Forms.ContextMenuStrip TabContextMenu;
        private Controls.CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView ScriptView;
        private System.Windows.Forms.Label InjectUwU;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem execToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePathToolStripMenuItem1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem owOToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem autoAttachToolStripMenuItem;
        private ToolStripMenuItem topMostToolStripMenuItem;
        private ToolStripMenuItem changeScriptFolderPathToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton SaveGame;
        private Bunifu.Framework.UI.BunifuImageButton RemoteSpy;
        private Bunifu.Framework.UI.BunifuImageButton Dex;
        private Bunifu.Framework.UI.BunifuImageButton SirhurtHub;
        private Bunifu.Framework.UI.BunifuImageButton InfiniteYield;
        private Bunifu.Framework.UI.BunifuImageButton ESP;
        private Bunifu.Framework.UI.BunifuImageButton Noclip;
        private Bunifu.Framework.UI.BunifuImageButton InfinityHub;
    }
}

