﻿namespace UngDung1
{
    partial class FormSuaHangHoa
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
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(12, 197);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(276, 20);
            this.txtSL.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số Lượng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(12, 140);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(276, 20);
            this.txtGia.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giá ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(12, 84);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(276, 20);
            this.txtTen.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(54, 237);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(12, 33);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(276, 20);
            this.txtMa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaHangHoa";
            this.Text = "FormSuaHangHoa";
            this.Load += new System.EventHandler(this.FormSuaHangHoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}