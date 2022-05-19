namespace DoAnQuanLyXeMay
{
    partial class DangNhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mkkh = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tkkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dnkh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Museo 700", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(141, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // txt_mkkh
            // 
            this.txt_mkkh.Location = new System.Drawing.Point(177, 180);
            this.txt_mkkh.Name = "txt_mkkh";
            this.txt_mkkh.Size = new System.Drawing.Size(194, 20);
            this.txt_mkkh.TabIndex = 12;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Museo 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btn_thoat.Location = new System.Drawing.Point(260, 265);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(94, 44);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            this.btn_thoat.MouseLeave += new System.EventHandler(this.btn_thoat_MouseLeave);
            this.btn_thoat.MouseHover += new System.EventHandler(this.btn_thoat_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(51, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_tkkh
            // 
            this.txt_tkkh.Location = new System.Drawing.Point(177, 98);
            this.txt_tkkh.Name = "txt_tkkh";
            this.txt_tkkh.Size = new System.Drawing.Size(194, 20);
            this.txt_tkkh.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(51, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài Khoản";
            // 
            // btn_dnkh
            // 
            this.btn_dnkh.Font = new System.Drawing.Font("Museo 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dnkh.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btn_dnkh.Location = new System.Drawing.Point(86, 265);
            this.btn_dnkh.Name = "btn_dnkh";
            this.btn_dnkh.Size = new System.Drawing.Size(125, 44);
            this.btn_dnkh.TabIndex = 7;
            this.btn_dnkh.Text = "Đăng Nhập";
            this.btn_dnkh.UseVisualStyleBackColor = true;
            this.btn_dnkh.Click += new System.EventHandler(this.btn_dnkh_Click);
            this.btn_dnkh.MouseLeave += new System.EventHandler(this.btn_dnkh_MouseLeave);
            this.btn_dnkh.MouseHover += new System.EventHandler(this.btn_dnkh_MouseHover);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mkkh);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tkkh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dnkh);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mkkh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tkkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dnkh;
    }
}

