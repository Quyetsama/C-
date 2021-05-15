
namespace Test2
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
            this.button = new System.Windows.Forms.Button();
            this.Tieude = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelChieuCao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(226, 133);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "OK a zai";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Tieude
            // 
            this.Tieude.AutoSize = true;
            this.Tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tieude.Location = new System.Drawing.Point(220, 9);
            this.Tieude.Name = "Tieude";
            this.Tieude.Size = new System.Drawing.Size(352, 32);
            this.Tieude.TabIndex = 1;
            this.Tieude.Text = "Con me thang Hung Tien";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(226, 88);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(172, 26);
            this.textBox.TabIndex = 2;
            // 
            // labelChieuCao
            // 
            this.labelChieuCao.AutoSize = true;
            this.labelChieuCao.Location = new System.Drawing.Point(223, 57);
            this.labelChieuCao.Name = "labelChieuCao";
            this.labelChieuCao.Size = new System.Drawing.Size(125, 13);
            this.labelChieuCao.TabIndex = 3;
            this.labelChieuCao.Text = "Nhap chieu cao cua ban";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChieuCao);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Tieude);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label Tieude;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelChieuCao;
    }
}

