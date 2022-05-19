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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.buttonDN1.ForeColor = System.Drawing.Color.White;
            this.buttonDN1.Location = new System.Drawing.Point(368, 322);
            this.buttonDN1.Name = "buttonDN1";
            this.buttonDN1.Size = new System.Drawing.Size(325, 148);
            this.buttonDN1.TabIndex = 1;
            this.buttonDN1.Text = "buttonDN1";
            this.buttonDN1.TextColor = System.Drawing.Color.White;
            this.buttonDN1.UseVisualStyleBackColor = false;
            this.buttonDN1.Click += new System.EventHandler(this.buttonDN1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1033, 589);
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
    }
}

