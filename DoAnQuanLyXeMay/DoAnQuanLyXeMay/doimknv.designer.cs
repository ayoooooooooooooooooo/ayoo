namespace DoAnQuanLyXeMay
{
    partial class doimknv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doimknv));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xnmk = new System.Windows.Forms.TextBox();
            this.buttonDN1 = new ThietkeControl.ButtonDN();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Patrick Hand SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.Location = new System.Drawing.Point(238, 64);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '☻';
            this.txt_mkmoi.Size = new System.Drawing.Size(196, 33);
            this.txt_mkmoi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("NiveaSupertypeVietnam", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(151, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đổi mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(22, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xác nhận mật khẩu mới";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_xnmk
            // 
            this.txt_xnmk.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xnmk.Location = new System.Drawing.Point(238, 150);
            this.txt_xnmk.Name = "txt_xnmk";
            this.txt_xnmk.PasswordChar = '☻';
            this.txt_xnmk.Size = new System.Drawing.Size(196, 33);
            this.txt_xnmk.TabIndex = 7;
            this.txt_xnmk.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonDN1
            // 
            this.buttonDN1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDN1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDN1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDN1.BorderRadius = 20;
            this.buttonDN1.BorderSize = 0;
            this.buttonDN1.FlatAppearance.BorderSize = 0;
            this.buttonDN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDN1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDN1.ForeColor = System.Drawing.Color.White;
            this.buttonDN1.Location = new System.Drawing.Point(145, 241);
            this.buttonDN1.Name = "buttonDN1";
            this.buttonDN1.Size = new System.Drawing.Size(150, 40);
            this.buttonDN1.TabIndex = 8;
            this.buttonDN1.Text = "THAY ĐỔI";
            this.buttonDN1.TextColor = System.Drawing.Color.White;
            this.buttonDN1.UseVisualStyleBackColor = false;
            this.buttonDN1.Click += new System.EventHandler(this.buttonDN1_Click);
            // 
            // doimknv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(458, 335);
            this.Controls.Add(this.buttonDN1);
            this.Controls.Add(this.txt_xnmk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.label2);
            this.Name = "doimknv";
            this.Text = "Thay đổi mật khẩu Nhân viên";
            this.Load += new System.EventHandler(this.khthaydoithongtin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_xnmk;
        private ThietkeControl.ButtonDN buttonDN1;
    }
}