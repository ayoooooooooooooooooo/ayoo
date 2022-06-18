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
    public partial class thongtinnvcanhan : Form
    {
        BLLNHhanVien bLLNHhanVien = new BLLNHhanVien();
        public thongtinnvcanhan()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        string mnv = "";
        public thongtinnvcanhan(string manv)
            : this()
        {
            mnv = manv;
        }
      
        private void thongtinkh_Load(object sender, EventArgs e)
        {
            NHANVIEN a = bLLNHhanVien.BLLLay1NV(mnv);
            lb_diachi.Text = a.DIACHI;
            lb_hoten.Text = a.TENNV;
            lb_gioitinh.Text = a.GIOITINH;
            lb_email.Text = a.EMAILNV;
            lb_ngaysinh.Text = a.NGAYSINH.ToString().Substring(0,10);
            lb_sdt.Text = a.SDT;
            lb_ngayvl.Text = a.NGAYVL.ToString().Substring(0, 10);
            lb_phanloai.Text = a.PHANLOAI;
            lb_cmnd.Text = a.CMND;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lb_email_Click(object sender, EventArgs e)
        {

        }

        private void lb_diachi_Click(object sender, EventArgs e)
        {

        }

        private void lb_sdt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_mk_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lb_phanloai_Click(object sender, EventArgs e)
        {

        }
    }
}
