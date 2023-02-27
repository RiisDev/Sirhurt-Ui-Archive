namespace SirhurtBootStrapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DownloadProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.animated = true;
            this.DownloadProgress.animationIterval = 1;
            this.DownloadProgress.animationSpeed = 5;
            this.DownloadProgress.BackColor = System.Drawing.Color.Transparent;
            this.DownloadProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownloadProgress.BackgroundImage")));
            this.DownloadProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.DownloadProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.DownloadProgress.LabelVisible = false;
            this.DownloadProgress.LineProgressThickness = 8;
            this.DownloadProgress.LineThickness = 5;
            this.DownloadProgress.Location = new System.Drawing.Point(-2, -2);
            this.DownloadProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.DownloadProgress.MaxValue = 65;
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.DownloadProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(93)))), ((int)(((byte)(215)))));
            this.DownloadProgress.Size = new System.Drawing.Size(300, 300);
            this.DownloadProgress.TabIndex = 0;
            this.DownloadProgress.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SirhurtBootStrapper.Properties.Resources.bruhfish;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(81, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 126);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(58, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Downloading SirHurt..";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 900;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DownloadProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCircleProgressbar DownloadProgress;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

