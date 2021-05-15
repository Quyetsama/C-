
namespace CafeDemo
{
    partial class Qlbh
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
            this.labelqlbh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelqlbh
            // 
            this.labelqlbh.AutoSize = true;
            this.labelqlbh.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqlbh.Location = new System.Drawing.Point(163, 213);
            this.labelqlbh.Name = "labelqlbh";
            this.labelqlbh.Size = new System.Drawing.Size(932, 128);
            this.labelqlbh.TabIndex = 0;
            this.labelqlbh.Text = "Quản Lí Bán Hàng";
            // 
            // Qlbh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelqlbh);
            this.Name = "Qlbh";
            this.Size = new System.Drawing.Size(1183, 708);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelqlbh;
    }
}
