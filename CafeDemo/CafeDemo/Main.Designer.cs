
namespace CafeDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnTct = new System.Windows.Forms.Button();
            this.btnKmtv = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnQltk = new System.Windows.Forms.Button();
            this.btnQlmh = new System.Windows.Forms.Button();
            this.btnQlbh = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tctSide = new CafeDemo.Tct();
            this.homeSide = new CafeDemo.Home();
            this.qlmhSide = new CafeDemo.Qlmh();
            this.kmtvSide = new CafeDemo.Kmtv();
            this.qltkSide = new CafeDemo.Qltk();
            this.qlbhSide = new CafeDemo.Qlbh();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.btnTct);
            this.panel1.Controls.Add(this.btnKmtv);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnQltk);
            this.panel1.Controls.Add(this.btnQlmh);
            this.panel1.Controls.Add(this.btnQlbh);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 1041);
            this.panel1.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelSide.Location = new System.Drawing.Point(0, 168);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 80);
            this.panelSide.TabIndex = 12;
            // 
            // btnTct
            // 
            this.btnTct.FlatAppearance.BorderSize = 0;
            this.btnTct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTct.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTct.ForeColor = System.Drawing.Color.White;
            this.btnTct.Image = ((System.Drawing.Image)(resources.GetObject("btnTct.Image")));
            this.btnTct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTct.Location = new System.Drawing.Point(0, 586);
            this.btnTct.Name = "btnTct";
            this.btnTct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTct.Size = new System.Drawing.Size(285, 80);
            this.btnTct.TabIndex = 13;
            this.btnTct.Text = "        Thu Chi Tiền";
            this.btnTct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTct.UseVisualStyleBackColor = true;
            this.btnTct.Click += new System.EventHandler(this.btnTct_Click);
            // 
            // btnKmtv
            // 
            this.btnKmtv.FlatAppearance.BorderSize = 0;
            this.btnKmtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKmtv.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKmtv.ForeColor = System.Drawing.Color.White;
            this.btnKmtv.Image = ((System.Drawing.Image)(resources.GetObject("btnKmtv.Image")));
            this.btnKmtv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKmtv.Location = new System.Drawing.Point(0, 503);
            this.btnKmtv.Name = "btnKmtv";
            this.btnKmtv.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKmtv.Size = new System.Drawing.Size(282, 80);
            this.btnKmtv.TabIndex = 12;
            this.btnKmtv.Text = "        Khuyến Mãi - Thẻ VIP";
            this.btnKmtv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKmtv.UseVisualStyleBackColor = true;
            this.btnKmtv.Click += new System.EventHandler(this.btnKmtv_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnQltk
            // 
            this.btnQltk.FlatAppearance.BorderSize = 0;
            this.btnQltk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQltk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQltk.ForeColor = System.Drawing.Color.White;
            this.btnQltk.Image = ((System.Drawing.Image)(resources.GetObject("btnQltk.Image")));
            this.btnQltk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQltk.Location = new System.Drawing.Point(0, 420);
            this.btnQltk.Name = "btnQltk";
            this.btnQltk.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQltk.Size = new System.Drawing.Size(282, 80);
            this.btnQltk.TabIndex = 6;
            this.btnQltk.Text = "        Quản Lý Tồn Kho";
            this.btnQltk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQltk.UseVisualStyleBackColor = true;
            this.btnQltk.Click += new System.EventHandler(this.btnQltk_Click);
            // 
            // btnQlmh
            // 
            this.btnQlmh.FlatAppearance.BorderSize = 0;
            this.btnQlmh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlmh.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlmh.ForeColor = System.Drawing.Color.White;
            this.btnQlmh.Image = ((System.Drawing.Image)(resources.GetObject("btnQlmh.Image")));
            this.btnQlmh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQlmh.Location = new System.Drawing.Point(0, 337);
            this.btnQlmh.Name = "btnQlmh";
            this.btnQlmh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQlmh.Size = new System.Drawing.Size(282, 80);
            this.btnQlmh.TabIndex = 5;
            this.btnQlmh.Text = "        Quản Lý Mua Hàng";
            this.btnQlmh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQlmh.UseVisualStyleBackColor = true;
            this.btnQlmh.Click += new System.EventHandler(this.btnQlmh_Click);
            // 
            // btnQlbh
            // 
            this.btnQlbh.FlatAppearance.BorderSize = 0;
            this.btnQlbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlbh.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlbh.ForeColor = System.Drawing.Color.White;
            this.btnQlbh.Image = ((System.Drawing.Image)(resources.GetObject("btnQlbh.Image")));
            this.btnQlbh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQlbh.Location = new System.Drawing.Point(0, 254);
            this.btnQlbh.Name = "btnQlbh";
            this.btnQlbh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQlbh.Size = new System.Drawing.Size(282, 80);
            this.btnQlbh.TabIndex = 4;
            this.btnQlbh.Text = "        Quản Lý Bán Hàng";
            this.btnQlbh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQlbh.UseVisualStyleBackColor = true;
            this.btnQlbh.Click += new System.EventHandler(this.btnQlbh_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 171);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(282, 80);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "        Trang Chủ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.Location = new System.Drawing.Point(1573, 0);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(45, 45);
            this.btnShutdown.TabIndex = 7;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelToolBar.Controls.Add(this.button1);
            this.panelToolBar.Controls.Add(this.button6);
            this.panelToolBar.Controls.Add(this.btnShutdown);
            this.panelToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBar.Location = new System.Drawing.Point(285, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(1619, 45);
            this.panelToolBar.TabIndex = 1;
            this.panelToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolBar_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1471, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1522, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 9;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // tctSide
            // 
            this.tctSide.Location = new System.Drawing.Point(285, 51);
            this.tctSide.Name = "tctSide";
            this.tctSide.Size = new System.Drawing.Size(1183, 711);
            this.tctSide.TabIndex = 15;
            // 
            // homeSide
            // 
            this.homeSide.Location = new System.Drawing.Point(285, 51);
            this.homeSide.Name = "homeSide";
            this.homeSide.Size = new System.Drawing.Size(1183, 711);
            this.homeSide.TabIndex = 10;
            // 
            // qlmhSide
            // 
            this.qlmhSide.Location = new System.Drawing.Point(285, 51);
            this.qlmhSide.Name = "qlmhSide";
            this.qlmhSide.Size = new System.Drawing.Size(1183, 711);
            this.qlmhSide.TabIndex = 12;
            // 
            // kmtvSide
            // 
            this.kmtvSide.Location = new System.Drawing.Point(285, 51);
            this.kmtvSide.Name = "kmtvSide";
            this.kmtvSide.Size = new System.Drawing.Size(1183, 711);
            this.kmtvSide.TabIndex = 14;
            // 
            // qltkSide
            // 
            this.qltkSide.Location = new System.Drawing.Point(285, 51);
            this.qltkSide.Name = "qltkSide";
            this.qltkSide.Size = new System.Drawing.Size(1183, 718);
            this.qltkSide.TabIndex = 13;
            // 
            // qlbhSide
            // 
            this.qlbhSide.Location = new System.Drawing.Point(285, 48);
            this.qlbhSide.Name = "qlbhSide";
            this.qlbhSide.Size = new System.Drawing.Size(1183, 711);
            this.qlbhSide.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tctSide);
            this.Controls.Add(this.homeSide);
            this.Controls.Add(this.qlmhSide);
            this.Controls.Add(this.kmtvSide);
            this.Controls.Add(this.qltkSide);
            this.Controls.Add(this.qlbhSide);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnQltk;
        private System.Windows.Forms.Button btnQlmh;
        private System.Windows.Forms.Button btnQlbh;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private Home homeSide;
        private Qlbh qlbhSide;
        private Qlmh qlmhSide;
        private System.Windows.Forms.Button btnKmtv;
        private System.Windows.Forms.Button btnTct;
        private Qltk qltkSide;
        private Kmtv kmtvSide;
        private Tct tctSide;
        private System.Windows.Forms.Panel panelSide;
    }
}

