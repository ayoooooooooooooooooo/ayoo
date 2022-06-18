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
namespace DoAnQuanLyXeMay
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        void Databingding(KHACHHANG pDT)
        {
            txt_mkh.DataBindings.Clear();
            txt_sdtkh.DataBindings.Clear();
            txt_hotenkh.DataBindings.Clear();
            txt_dckh.DataBindings.Clear();
            txt_gtkh.DataBindings.Clear();
            dt_nskh.DataBindings.Clear();

            txt_mkh.DataBindings.Add("Text", pDT, "MAKH");
            txt_sdtkh.DataBindings.Add("Text", pDT, "SDT");
            txt_hotenkh.DataBindings.Add("Text", pDT, "TENKH");
            txt_dckh.DataBindings.Add("Text", pDT, "DIACHI");
            txt_gtkh.DataBindings.Add("Text", pDT, "GIOITINH");
            dt_nskh.DataBindings.Add("Text", pDT, "NGAYSINH");

        }
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        BLLKhachHang bLLKhachHang= new BLLKhachHang();
        int luu = 0;
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dG_kh.DataSource = bLLKhachHang.dskhachhang();
            txt_dckh.Enabled = txt_gtkh.Enabled = txt_hotenkh.Enabled = txt_mkh.Enabled = txt_sdtkh.Enabled = dt_nskh.Enabled = false;
        }

        private void btn_ls_Click(object sender, EventArgs e)
        {
            //thongtinkh a = new thongtinkh(dG_kh.CurrentRow.Cells[2].Value.ToString());
            //a.Show();
        }

        private void dG_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_lsgd_Click(object sender, EventArgs e)
        {
            //hdtheokh a = new hdtheokh(dG_kh.CurrentRow.Cells[2].Value.ToString());
            //a.Show();
        }

        private void dG_kh_Click(object sender, EventArgs e)
        {
            txt_mkh.Text = dG_kh.CurrentRow.Cells[2].Value.ToString();
            txt_hotenkh.Text = dG_kh.CurrentRow.Cells[3].Value.ToString();
            txt_gtkh.Text = dG_kh.CurrentRow.Cells[8].Value.ToString();
            txt_dckh.Text = dG_kh.CurrentRow.Cells[5].Value.ToString();
            txt_sdtkh.Text = dG_kh.CurrentRow.Cells[6].Value.ToString();
            string a = dG_kh.CurrentRow.Cells[7].Value.ToString();
            dt_nskh.Value = DateTime.Parse(a);
            dt_nskh.Text = dt_nskh.Value.ToString("yyyy-MM-dd");
            
        }

        private void btn_themhdn_Click(object sender, EventArgs e)
        {
            txt_dckh.Enabled = txt_gtkh.Enabled = txt_hotenkh.Enabled = txt_mkh.Enabled = txt_sdtkh.Enabled = dt_nskh.Enabled = true;
            txt_dckh.Text = txt_gtkh.Text = txt_hotenkh.Text = txt_mkh.Text = txt_sdtkh.Text = dt_nskh.Text = "";
            luu = 1;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            KHACHHANG kh = new KHACHHANG();
            kh.MAKH = txt_mkh.Text;

            kh.NGAYSINH = dt_nskh.Value;
            kh.TENKH = txt_hotenkh.Text;
            kh.SDT = txt_sdtkh.Text;
            kh.DIACHI = txt_dckh.Text;
            kh.GIOITINH = txt_gtkh.Text;
            if (luu==1)
            {
                if (bLLKhachHang.themkh(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                    dG_kh.DataSource = bLLKhachHang.dskhachhang();
                }
                else
                    MessageBox.Show("Thêm khách hàng thất bại", "Thông báo");
            }

            else
            {
                if (bLLKhachHang.suakh(kh))
                {
                    MessageBox.Show("Sửa khách hàngthành công", "Thông báo");
                    dG_kh.DataSource = bLLKhachHang.dskhachhang();
                }
                else
                    MessageBox.Show("Sửa khách hàng thất bại", "Thông báo");
            }
            
        }

        private void btn_suahdn_Click(object sender, EventArgs e)
        {
            txt_dckh.Enabled = txt_gtkh.Enabled = txt_hotenkh.Enabled = txt_sdtkh.Enabled = dt_nskh.Enabled = true;
            txt_mkh.Enabled = false;
            luu = 2;
        }

        private void btn_xoahdn_Click(object sender, EventArgs e)
        {
   
            if (bLLKhachHang.xoakh(dG_kh.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("Xóa khách hàngthành công", "Thông báo");
                dG_kh.DataSource = bLLKhachHang.dskhachhang();
            }
            else
                MessageBox.Show("Xóa khách hàng thất bại", "Thông báo");
        }
    }
}
