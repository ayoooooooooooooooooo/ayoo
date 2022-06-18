using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DemoBuoi7;

namespace DoAnQuanLyXeMay
{
    public partial class chitiethoadonxuat : Form
    {
        string mahd = null;
        public chitiethoadonxuat()
        {
            InitializeComponent();
        }
        public chitiethoadonxuat(string mahd1):this()
        {
            mahd = mahd1;
        }
        BLLCTHDNhap bllctn= new BLLCTHDNhap();
        BLLCTHDXuat bllctx = new BLLCTHDXuat();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int luu_flag = 0;
        private void chitiethoadon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            if (mahd.Substring(0, 3).Equals("HDX"))
                dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
            else
                dataGridView1.DataSource = bllctn.lstcthdnhap(mahd);
            txt_sanpham.DataSource = bllSanpham.dsSanPham();
            txt_sanpham.ValueMember = "MASP";
            txt_sanpham.DisplayMember = "TENSP";
            txt_sanpham.Enabled = txt_dongia.Enabled = txt_sl.Enabled = txt_thue.Enabled = false;
            btn_xoahdx.Enabled = false;
            btn_suahdx.Enabled = false;btn_luu.Enabled = false;
            lb_thanhtien.Text =  String.Format("{0:0,0 vnđ}", bllctx.tinhtien(mahd));
        }
        BLLSanPham bllSanpham = new BLLSanPham();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_themhdx_Click(object sender, EventArgs e)
        {
            txt_sanpham.Enabled = txt_dongia.Enabled = txt_sl.Enabled = txt_thue.Enabled = true;
            luu_flag = 1;
            btn_luu.Enabled=true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (mahd.Substring(0, 3).Equals("HDX"))
            {
                CHITIETHDXUAT ctxx=new CHITIETHDXUAT();
                ctxx.MAHD = mahd;
                ctxx.MASP = txt_sanpham.SelectedValue.ToString();
                ctxx.SL = int.Parse(txt_sl.Text);
                ctxx.DONGIA = decimal.Parse(txt_dongia.Text);
                ctxx.THUE = double.Parse(txt_thue.Text);
                ctxx.THANHTIEN = decimal.Parse( bllctn.tinhthanhtien(double.Parse(txt_dongia.Text), int.Parse(txt_sl.Text), double.Parse(txt_thue.Text)).ToString());

                if (luu_flag == 1)
                {
                    if (bLLHDXuat.Ktraxetrongkho(txt_sanpham.SelectedValue.ToString(), int.Parse(txt_sl.Text)))
                        if (bllctx.themhdx(ctxx))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm thất bại");
                    else
                        MessageBox.Show("Xe không đủ trong kho để thực hiện hành động");

                }
                else
                if (bLLHDXuat.Ktraxetrongkho(txt_sanpham.SelectedValue.ToString(), int.Parse(txt_sl.Text)))
                    if (bllctx.suahdx(ctxx))
                {
                    MessageBox.Show("Sửa sản phẩm thành công");
                    dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
                }
                else
                    MessageBox.Show("Sửa sản phẩm thất bại");
                else
                    MessageBox.Show("Xe không đủ trong kho để thực hiện hành động");

            }
            else
            {
                CHITIETHDNHAP ctnn = new CHITIETHDNHAP();
                ctnn.MAHD = mahd;
                ctnn.MASP = txt_sanpham.SelectedValue.ToString();
                ctnn.SL = int.Parse(txt_sl.Text);
                ctnn.DONGIA = decimal.Parse(txt_dongia.Text);
                ctnn.THUE = double.Parse(txt_thue.Text);
                ctnn.THANHTIEN = decimal.Parse(bllctn.tinhthanhtien(double.Parse(txt_dongia.Text), int.Parse(txt_sl.Text), double.Parse(txt_thue.Text)).ToString());

                if (luu_flag == 1)
                {
                 
                        if (bllctn.themhdn(ctnn))
                        {
                            MessageBox.Show("Thêm sản phẩm thành công");
                            dataGridView1.DataSource = bllctn.lstcthdnhap(mahd);
                        }
                        else
                            MessageBox.Show("Thêm sản phẩm thất bại");
                   

                }
                else
                 
                    if (bllctn.suahdn(ctnn))
                {
                    MessageBox.Show("Sửa sản phẩm thành công");
                    dataGridView1.DataSource = bllctn.lstcthdnhap(mahd);
                }
                else
                    MessageBox.Show("Sửa sản phẩm thất bại");
                
            }
            txt_sanpham.Enabled = txt_dongia.Enabled = txt_sl.Enabled = txt_thue.Enabled = false;
            btn_luu.Enabled = false;
            lb_thanhtien.Text = String.Format("{0:0,0 vnđ}", bllctx.tinhtien(mahd));
        }
        BLLSanPham bLLSanPham=new BLLSanPham();
        BLLHDXuat bLLHDXuat = new BLLHDXuat();
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_dongia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_sl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_thue.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btn_suahdx.Enabled = btn_xoahdx.Enabled = true;
        }

        private void btn_suahdx_Click(object sender, EventArgs e)
        {
            txt_sanpham.Enabled = txt_dongia.Enabled = txt_sl.Enabled = txt_thue.Enabled = true;
            luu_flag = 2;
            btn_luu.Enabled = true;
        }

        private void btn_xoahdx_Click(object sender, EventArgs e)
        {
            if (mahd.Substring(0, 3).Equals("HDX"))

                if (bllctx.xoahdx(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                    dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại");
                  
                }
            else
                if (bllctn.xoahdn(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                dataGridView1.DataSource = bllctn.lstcthdnhap(mahd);
            }
            else
                MessageBox.Show("Xóa sản phẩm thất bại");
            lb_thanhtien.Text = String.Format("{0:0,0 vnđ}", bllctx.tinhtien(mahd));

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_dongia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_sl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_thue.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btn_suahdx.Enabled = btn_xoahdx.Enabled = true;
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            if (mahd.Substring(0, 3).Equals("HDX"))
            {
                HoaDonXuat a= new HoaDonXuat();
                a.Show();
                this.Close();
            }
            else
            {
                HoadonNhap a = new HoadonNhap();
                a.Show();
                this.Close();
            }
        }

        private void lb_thanhtien_Click(object sender, EventArgs e)
        {

        }
        BLLCTHDNhap bLLCTHDNhap= new BLLCTHDNhap();
        private void btn_inhd_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
      

     
            string path = string.Empty;
            excel.ExportKhoa(bLLCTHDNhap.lstcthdnhap(mahd), ref path, false);
            System.Diagnostics.Process.Start(path);
        }
    }
}
