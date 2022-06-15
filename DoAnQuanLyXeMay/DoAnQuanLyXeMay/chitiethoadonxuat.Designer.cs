namespace DoAnQuanLyXeMay
{
    partial class chitiethoadonxuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitiethoadonxuat));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctx_hdxuat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_themhdx = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_xoahdx = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_suahdx = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDN1 = new ThietkeControl.ButtonDN();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ctx_hdxuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1204, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_thanhtien, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDN1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.54296F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.1031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.810997F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.37113F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1210, 582);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.ContextMenuStrip = this.ctx_hdxuat;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 402);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masp";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sl";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dongia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "thue";
            this.Column4.HeaderText = "Thuế";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thanhtien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // ctx_hdxuat
            // 
            this.ctx_hdxuat.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_hdxuat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_themhdx,
            this.btn_xoahdx,
            this.btn_suahdx});
            this.ctx_hdxuat.Name = "ctx_hdnhap";
            this.ctx_hdxuat.Size = new System.Drawing.Size(109, 70);
            // 
            // btn_themhdx
            // 
            this.btn_themhdx.Image = ((System.Drawing.Image)(resources.GetObject("btn_themhdx.Image")));
            this.btn_themhdx.Name = "btn_themhdx";
            this.btn_themhdx.Size = new System.Drawing.Size(108, 22);
            this.btn_themhdx.Text = "Thêm";
            this.btn_themhdx.Click += new System.EventHandler(this.btn_themhdx_Click);
            // 
            // btn_xoahdx
            // 
            this.btn_xoahdx.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoahdx.Image")));
            this.btn_xoahdx.Name = "btn_xoahdx";
            this.btn_xoahdx.Size = new System.Drawing.Size(108, 22);
            this.btn_xoahdx.Text = "Xóa";
            // 
            // btn_suahdx
            // 
            this.btn_suahdx.Image = ((System.Drawing.Image)(resources.GetObject("btn_suahdx.Image")));
            this.btn_suahdx.Name = "btn_suahdx";
            this.btn_suahdx.Size = new System.Drawing.Size(108, 22);
            this.btn_suahdx.Text = "Sửa";
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.ForeColor = System.Drawing.Color.Crimson;
            this.lb_thanhtien.Location = new System.Drawing.Point(608, 484);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(59, 22);
            this.lb_thanhtien.TabIndex = 3;
            this.lb_thanhtien.Text = "label3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(509, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền:";
            // 
            // buttonDN1
            // 
            this.buttonDN1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDN1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDN1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDN1.BorderRadius = 16;
            this.buttonDN1.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonDN1, 2);
            this.buttonDN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDN1.FlatAppearance.BorderSize = 0;
            this.buttonDN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDN1.ForeColor = System.Drawing.Color.White;
            this.buttonDN1.Location = new System.Drawing.Point(3, 512);
            this.buttonDN1.Name = "buttonDN1";
            this.buttonDN1.Size = new System.Drawing.Size(1204, 67);
            this.buttonDN1.TabIndex = 4;
            this.buttonDN1.Text = "THOÁT";
            this.buttonDN1.TextColor = System.Drawing.Color.White;
            this.buttonDN1.UseVisualStyleBackColor = false;
            // 
            // chitiethoadonxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "chitiethoadonxuat";
            this.Text = "chitiethoadon";
            this.Load += new System.EventHandler(this.chitiethoadon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ctx_hdxuat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ContextMenuStrip ctx_hdxuat;
        private System.Windows.Forms.ToolStripMenuItem btn_themhdx;
        private System.Windows.Forms.ToolStripMenuItem btn_xoahdx;
        private System.Windows.Forms.ToolStripMenuItem btn_suahdx;
        private ThietkeControl.ButtonDN buttonDN1;
    }
}