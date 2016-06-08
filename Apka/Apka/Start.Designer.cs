namespace Apka
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artystaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piosenkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytwórniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumyartystowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabeleToolStripMenuItem
            // 
            this.tabeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artystaToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.piosenkaToolStripMenuItem,
            this.wytwórniaToolStripMenuItem,
            this.albumyartystowToolStripMenuItem});
            this.tabeleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabeleToolStripMenuItem.Name = "tabeleToolStripMenuItem";
            this.tabeleToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.tabeleToolStripMenuItem.Text = "Tabele";
            this.tabeleToolStripMenuItem.Click += new System.EventHandler(this.tabeleToolStripMenuItem_Click);
            // 
            // artystaToolStripMenuItem
            // 
            this.artystaToolStripMenuItem.Name = "artystaToolStripMenuItem";
            this.artystaToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.artystaToolStripMenuItem.Text = "Artysta";
            this.artystaToolStripMenuItem.Click += new System.EventHandler(this.artystaToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // piosenkaToolStripMenuItem
            // 
            this.piosenkaToolStripMenuItem.Name = "piosenkaToolStripMenuItem";
            this.piosenkaToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.piosenkaToolStripMenuItem.Text = "Piosenka";
            this.piosenkaToolStripMenuItem.Click += new System.EventHandler(this.piosenkaToolStripMenuItem_Click);
            // 
            // wytwórniaToolStripMenuItem
            // 
            this.wytwórniaToolStripMenuItem.Name = "wytwórniaToolStripMenuItem";
            this.wytwórniaToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.wytwórniaToolStripMenuItem.Text = "Wytwornia";
            this.wytwórniaToolStripMenuItem.Click += new System.EventHandler(this.wytworniaToolStripMenuItem_Click);
            // 
            // albumyartystowToolStripMenuItem
            // 
            this.albumyartystowToolStripMenuItem.Name = "albumyartystowToolStripMenuItem";
            this.albumyartystowToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.albumyartystowToolStripMenuItem.Text = "Albumy_artystow";
            this.albumyartystowToolStripMenuItem.Click += new System.EventHandler(this.albumyartystowToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Synchronizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Aplikacja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artystaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piosenkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytwórniaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem albumyartystowToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

