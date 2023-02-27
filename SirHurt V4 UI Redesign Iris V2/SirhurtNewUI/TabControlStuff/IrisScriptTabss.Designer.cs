namespace IrisFramework
{
    partial class IrisScriptTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackDrop = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.ButtonHolder = new System.Windows.Forms.Panel();
            this.AddTab = new System.Windows.Forms.Button();
            this.ScrollBar = new System.Windows.Forms.Panel();
            this.MainStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameBox = new System.Windows.Forms.ToolStripTextBox();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackDrop.SuspendLayout();
            this.ButtonHolder.SuspendLayout();
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackDrop
            // 
            this.BackDrop.Controls.Add(this.Container);
            this.BackDrop.Controls.Add(this.ButtonHolder);
            this.BackDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackDrop.Location = new System.Drawing.Point(0, 0);
            this.BackDrop.Name = "BackDrop";
            this.BackDrop.Size = new System.Drawing.Size(368, 290);
            this.BackDrop.TabIndex = 0;
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 30);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(368, 260);
            this.Container.TabIndex = 0;
            // 
            // ButtonHolder
            // 
            this.ButtonHolder.AutoScroll = true;
            this.ButtonHolder.Controls.Add(this.AddTab);
            this.ButtonHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHolder.Location = new System.Drawing.Point(0, 0);
            this.ButtonHolder.Name = "ButtonHolder";
            this.ButtonHolder.Size = new System.Drawing.Size(368, 30);
            this.ButtonHolder.TabIndex = 1;
            // 
            // AddTab
            // 
            this.AddTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddTab.FlatAppearance.BorderSize = 0;
            this.AddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTab.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTab.ForeColor = System.Drawing.Color.Coral;
            this.AddTab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddTab.Location = new System.Drawing.Point(0, 0);
            this.AddTab.MaximumSize = new System.Drawing.Size(35, 35);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(35, 30);
            this.AddTab.TabIndex = 99;
            this.AddTab.Text = "+";
            this.AddTab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.AddTabClicked);
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(0, 0);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(200, 100);
            this.ScrollBar.TabIndex = 0;
            // 
            // MainStrip
            // 
            this.MainStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.RenameBox,
            this.closeToolStripMenuItem});
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.RenderStyle.ArrowColor = System.Drawing.Color.Black;
            this.MainStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MainStrip.RenderStyle.ColorTable = null;
            this.MainStrip.RenderStyle.RoundedEdges = false;
            this.MainStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MainStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.MainStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MainStrip.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.MainStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MainStrip.ShowImageMargin = false;
            this.MainStrip.Size = new System.Drawing.Size(156, 95);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // RenameBox
            // 
            this.RenameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RenameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RenameBox.ForeColor = System.Drawing.Color.White;
            this.RenameBox.Name = "RenameBox";
            this.RenameBox.Size = new System.Drawing.Size(100, 23);
            this.RenameBox.Visible = false;
            this.RenameBox.Click += new System.EventHandler(this.RenameBox_Click);
            this.RenameBox.TextChanged += new System.EventHandler(this.RenameBox_TextChanged);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IrisScriptTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackDrop);
            this.Name = "IrisScriptTabs";
            this.Size = new System.Drawing.Size(368, 290);
            this.BackDrop.ResumeLayout(false);
            this.ButtonHolder.ResumeLayout(false);
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackDrop;
        private new System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel ScrollBar;
        public System.Windows.Forms.Panel ButtonHolder;
        public System.Windows.Forms.Button AddTab;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox RenameBox;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip MainStrip;
    }
}
