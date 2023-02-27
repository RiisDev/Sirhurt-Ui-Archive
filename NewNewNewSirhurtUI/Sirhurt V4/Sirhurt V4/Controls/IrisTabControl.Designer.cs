namespace WindowsFormsApp1
{
    public partial class IrisTabControl
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
            this.BackDrop.SuspendLayout();
            this.ButtonHolder.SuspendLayout();
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
            this.Container.Location = new System.Drawing.Point(0, 35);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(368, 255);
            this.Container.TabIndex = 0;
            // 
            // ButtonHolder
            // 
            this.ButtonHolder.AutoScroll = true;
            this.ButtonHolder.Controls.Add(this.AddTab);
            this.ButtonHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHolder.Location = new System.Drawing.Point(0, 0);
            this.ButtonHolder.Name = "ButtonHolder";
            this.ButtonHolder.Size = new System.Drawing.Size(368, 35);
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
            this.AddTab.Size = new System.Drawing.Size(35, 35);
            this.AddTab.TabIndex = 99;
            this.AddTab.Text = "+";
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(0, 0);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(200, 100);
            this.ScrollBar.TabIndex = 0;
            // 
            // IrisTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackDrop);
            this.Name = "IrisTabControl";
            this.Size = new System.Drawing.Size(368, 290);
            this.BackDrop.ResumeLayout(false);
            this.ButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackDrop;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel ScrollBar;
        public System.Windows.Forms.Panel ButtonHolder;
        public System.Windows.Forms.Button AddTab;
    }
}
