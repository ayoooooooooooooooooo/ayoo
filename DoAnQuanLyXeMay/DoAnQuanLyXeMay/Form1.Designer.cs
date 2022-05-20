namespace DoAnQuanLyXeMay
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDN1 = new ThietkeControl.ButtonDN();
            this.buttonDN2 = new ThietkeControl.ButtonDN();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonDN1
            // 
            this.buttonDN1.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonDN1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.buttonDN1.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonDN1.BorderRadius = 18;
            this.buttonDN1.BorderSize = 0;
            this.buttonDN1.FlatAppearance.BorderSize = 0;
            this.buttonDN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDN1.ForeColor = System.Drawing.Color.White;
            this.buttonDN1.Location = new System.Drawing.Point(421, 316);
            this.buttonDN1.Name = "buttonDN1";
            this.buttonDN1.Size = new System.Drawing.Size(264, 32);
            this.buttonDN1.TabIndex = 1;
            this.buttonDN1.Text = "buttonDN1";
            this.buttonDN1.TextColor = System.Drawing.Color.White;
            this.buttonDN1.UseVisualStyleBackColor = false;
            this.buttonDN1.Click += new System.EventHandler(this.buttonDN1_Click);
            // 
            // buttonDN2
            // 
            this.buttonDN2.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonDN2.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.buttonDN2.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonDN2.BorderRadius = 18;
            this.buttonDN2.BorderSize = 0;
            this.buttonDN2.FlatAppearance.BorderSize = 0;
            this.buttonDN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDN2.ForeColor = System.Drawing.Color.White;
            this.buttonDN2.Location = new System.Drawing.Point(630, 99);
            this.buttonDN2.Name = "buttonDN2";
            this.buttonDN2.Size = new System.Drawing.Size(264, 32);
            this.buttonDN2.TabIndex = 2;
            this.buttonDN2.Text = "đổi mật khẩu";
            this.buttonDN2.TextColor = System.Drawing.Color.White;
            this.buttonDN2.UseVisualStyleBackColor = false;
            this.buttonDN2.Click += new System.EventHandler(this.buttonDN2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1033, 589);
            this.Controls.Add(this.buttonDN2);
            this.Controls.Add(this.buttonDN1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private ThietkeControl.ButtonDN buttonDN1;
        private ThietkeControl.ButtonDN buttonDN2;
    }
}

