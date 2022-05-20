
namespace DoAnQuanLyXeMay
{
    partial class HoadonNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoadonNhap));
            this.tbL_hdN = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_mhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctx_hdnhap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_themhdn = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_xoahdn = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_suahdn = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_xcthdn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.dt_ngayban = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbL_hdN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ctx_hdnhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbL_hdN
            // 
            this.tbL_hdN.ColumnCount = 1;
            this.tbL_hdN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbL_hdN.Controls.Add(this.dataGridView1, 0, 2);
            this.tbL_hdN.Controls.Add(this.label1, 0, 0);
            this.tbL_hdN.Controls.Add(this.groupBox1, 0, 1);
            this.tbL_hdN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbL_hdN.Location = new System.Drawing.Point(0, 0);
            this.tbL_hdN.Name = "tbL_hdN";
            this.tbL_hdN.RowCount = 3;
            this.tbL_hdN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.tbL_hdN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.48276F));
            this.tbL_hdN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tbL_hdN.Size = new System.Drawing.Size(856, 688);
            this.tbL_hdN.TabIndex = 0;
            this.tbL_hdN.Paint += new System.Windows.Forms.PaintEventHandler(this.tbL_hdN_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_mhd,
            this.cl_masp,
            this.cl_manv,
            this.cl_soluong,
            this.cl_nb});
            this.dataGridView1.ContextMenuStrip = this.ctx_hdnhap;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 334);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cl_mhd
            // 
            this.cl_mhd.DataPropertyName = "MAHD";
            this.cl_mhd.HeaderText = "Mã Hóa Đơn";
            this.cl_mhd.Name = "cl_mhd";
            this.cl_mhd.ReadOnly = true;
            // 
            // cl_masp
            // 
            this.cl_masp.DataPropertyName = "MASP";
            this.cl_masp.HeaderText = "Mã Sản Phẩm";
            this.cl_masp.Name = "cl_masp";
            this.cl_masp.ReadOnly = true;
            // 
            // cl_manv
            // 
            this.cl_manv.DataPropertyName = "MANV";
            this.cl_manv.HeaderText = "Mã Nhân Viên";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.ReadOnly = true;
            // 
            // cl_soluong
            // 
            this.cl_soluong.DataPropertyName = "SL";
            this.cl_soluong.HeaderText = "Số lượng";
            this.cl_soluong.Name = "cl_soluong";
            this.cl_soluong.ReadOnly = true;
            // 
            // cl_nb
            // 
            this.cl_nb.DataPropertyName = "NGAYBAN";
            this.cl_nb.HeaderText = "Ngày Bán";
            this.cl_nb.Name = "cl_nb";
            this.cl_nb.ReadOnly = true;
            // 
            // ctx_hdnhap
            // 
            this.ctx_hdnhap.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_hdnhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_themhdn,
            this.btn_xoahdn,
            this.btn_suahdn,
            this.btn_xcthdn});
            this.ctx_hdnhap.Name = "ctx_hdnhap";
            this.ctx_hdnhap.Size = new System.Drawing.Size(153, 92);
            // 
            // btn_themhdn
            // 
            this.btn_themhdn.Image = ((System.Drawing.Image)(resources.GetObject("btn_themhdn.Image")));
            this.btn_themhdn.Name = "btn_themhdn";
            this.btn_themhdn.Size = new System.Drawing.Size(152, 22);
            this.btn_themhdn.Text = "Thêm";
            this.btn_themhdn.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // btn_xoahdn
            // 
            this.btn_xoahdn.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoahdn.Image")));
            this.btn_xoahdn.Name = "btn_xoahdn";
            this.btn_xoahdn.Size = new System.Drawing.Size(152, 22);
            this.btn_xoahdn.Text = "Xóa";
            this.btn_xoahdn.Click += new System.EventHandler(this.btn_xoahdn_Click);
            // 
            // btn_suahdn
            // 
            this.btn_suahdn.Image = ((System.Drawing.Image)(resources.GetObject("btn_suahdn.Image")));
            this.btn_suahdn.Name = "btn_suahdn";
            this.btn_suahdn.Size = new System.Drawing.Size(152, 22);
            this.btn_suahdn.Text = "Sửa";
            this.btn_suahdn.Click += new System.EventHandler(this.btn_suahdn_Click);
            // 
            // btn_xcthdn
            // 
            this.btn_xcthdn.Image = ((System.Drawing.Image)(resources.GetObject("btn_xcthdn.Image")));
            this.btn_xcthdn.Name = "btn_xcthdn";
            this.btn_xcthdn.Size = new System.Drawing.Size(152, 22);
            this.btn_xcthdn.Text = "Xem chi tiết";
            this.btn_xcthdn.Click += new System.EventHandler(this.btn_xcthdn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "HÓA ĐƠN NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_masp);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.dt_ngayban);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 288);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Location = new System.Drawing.Point(383, 150);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(181, 29);
            this.txt_gia.TabIndex = 53;
            this.txt_gia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(250, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Giá";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(607, 40);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(181, 29);
            this.txt_masp.TabIndex = 51;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Yellow;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_them.Location = new System.Drawing.Point(332, 240);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(175, 42);
            this.btn_them.TabIndex = 50;
            this.btn_them.Text = "Lưu";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dt_ngayban
            // 
            this.dt_ngayban.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayban.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dt_ngayban.Location = new System.Drawing.Point(355, 196);
            this.dt_ngayban.Name = "dt_ngayban";
            this.dt_ngayban.Size = new System.Drawing.Size(238, 29);
            this.dt_ngayban.TabIndex = 49;
            this.dt_ngayban.Value = new System.DateTime(2021, 11, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(458, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mã Sản Phẩm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(607, 107);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(181, 29);
            this.txt_manv.TabIndex = 46;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(183, 107);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(181, 29);
            this.txt_soluong.TabIndex = 44;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(183, 37);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(181, 29);
            this.txt_mahd.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(457, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Mã Nhân Viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(250, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày bán";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số Lượng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã Hóa Đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HoadonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 688);
            this.Controls.Add(this.tbL_hdN);
            this.Name = "HoadonNhap";
            this.Text = "Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.HoadonNhap_Load);
            this.tbL_hdN.ResumeLayout(false);
            this.tbL_hdN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ctx_hdnhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbL_hdN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngayban;
        private System.Windows.Forms.ContextMenuStrip ctx_hdnhap;
        private System.Windows.Forms.ToolStripMenuItem btn_themhdn;
        private System.Windows.Forms.ToolStripMenuItem btn_xoahdn;
        private System.Windows.Forms.ToolStripMenuItem btn_suahdn;
        private System.Windows.Forms.ToolStripMenuItem btn_xcthdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_mhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nb;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label6;
    }
}