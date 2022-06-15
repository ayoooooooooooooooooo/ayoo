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
        void Databingding(DataTable pDT)
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
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dG_kh.DataSource = bLLKhachHang.dskhachhang();
            
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
    }
}
