using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace DoAnQuanLyXeMay
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        bool flag;

        private void xephankhoilon_Load(object sender, EventArgs e)
        {
            if (flag == false)
                btn_nv.Enabled = false;

                    label6.Text = "Hãy làm việc thật tốt nhé " + bllnv.BLLlayTenNV(tennv);
        }

        string tennv = "";
        public nhanvien(bool loainv,string manv):this()
        {
            flag = loainv;
            tennv = manv;

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_nv_Click(object sender, EventArgs e)
        {
            thongtinnv a = new thongtinnv(tennv);
            a.Show();
            this.Hide();
        }

        private void btn_hdnhap_Click(object sender, EventArgs e)
        {
            HoadonNhap a = new HoadonNhap(tennv);
            a.Show(); a.MdiParent = this.MdiParent;
        }

        private void btn_hdxuat_Click(object sender, EventArgs e)
        {
            HoaDonXuat a = new HoaDonXuat(tennv);
            a.Show();
            a.MdiParent = this.MdiParent;
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhapNV a = new DangNhapNV();
            a.Show();
            a.MdiParent = this.MdiParent;
        }
       
        
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            formkho a = new formkho();
            a.Show();
            a.MdiParent = this.MdiParent;
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            //KhachHang a = new KhachHang();
            //a.Show();
            //a.MdiParent = this.MdiParent;
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            //thongtinnvcanhan a = new thongtinnvcanhan(tennv);
            //a.Show();
            //a.MdiParent = this.MdiParent;
        }
        BLLNHhanVien bllnv = new BLLNHhanVien();
        private void btn_doimk_Click(object sender, EventArgs e)
        {
            doimknv a = new doimknv(bllnv.BLLLay1NV("NV01"));

            a.Show();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_themsp_Click_1(object sender, EventArgs e)
        {
            //tbsp a = new tbsp();
            //a.Show();
            //a.MdiParent = this.MdiParent;
        }
    }
}
