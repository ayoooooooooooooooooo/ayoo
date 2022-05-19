using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyXeMay
{
    public partial class themnv : Form
    {
        public themnv()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void themnv_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        BLLNHhanVien bllnv = new BLLNHhanVien();
       
        private void buttonDN1_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = txt_manv.Text;
            nv.TENNV=txt_tennhanvien.Text;
            nv.SDT = txt_sdt.Text;
            nv.EMAILNV = txt_email.Text;
            nv.NGAYVL = txt_ngayvl.Value;
            nv.CMND= txt_cmnd.Text;
            nv.DIACHI= txt_diachi.Text;
            nv.GIOITINH = cbo_gt.Text;
            nv.MATKHAU = txt_mk.Text;
            nv.TAIKHOAN = txt_tk.Text;
            nv.NGAYSINH = txt_ngaysinh.Value;
            nv.PHANLOAI = cbo_pl.Text;
            if (bllnv.BLLthemNV(nv))
                MessageBox.Show("Them thanh cong");
            else
                MessageBox.Show("them that bai");
        }
    }
}
