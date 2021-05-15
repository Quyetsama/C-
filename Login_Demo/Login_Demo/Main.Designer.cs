
namespace Login_Demo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyBanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyBanHangToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyBanHangToolStripMenuItem
            // 
            this.quanLyBanHangToolStripMenuItem.Name = "quanLyBanHangToolStripMenuItem";
            this.quanLyBanHangToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quanLyBanHangToolStripMenuItem.Text = "quan ly ban hang";
            this.quanLyBanHangToolStripMenuItem.Click += new System.EventHandler(this.quanLyBanHangToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thangToolStripMenuItem,
            this.tuanToolStripMenuItem});
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.thongKeToolStripMenuItem.Text = "thong ke";
            // 
            // thangToolStripMenuItem
            // 
            this.thangToolStripMenuItem.Name = "thangToolStripMenuItem";
            this.thangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thangToolStripMenuItem.Text = "thang";
            // 
            // tuanToolStripMenuItem
            // 
            this.tuanToolStripMenuItem.Name = "tuanToolStripMenuItem";
            this.tuanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tuanToolStripMenuItem.Text = "tuan";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyBanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuanToolStripMenuItem;
    }
}