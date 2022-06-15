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
    public partial class doimknv : Form
    {
        public doimknv()
        {
            InitializeComponent();
        }
        BLLNHhanVien bllnv= new BLLNHhanVien();
        NHANVIEN nhanvien = new NHANVIEN(); 
        public doimknv(NHANVIEN nv) : this()
        {
            nhanvien = nv;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        string manv;
        public doimknv(string mnv)
            : this()
        {
            manv = mnv;
        }
        private void khthaydoithongtin_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonDN1_Click(object sender, EventArgs e)
        {
            if (txt_mkmoi.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Thông báo");
            else
                if (txt_xnmk.Text == "")
                MessageBox.Show("Vui lòng xác nhận mật khẩu.", "Thông báo");
            else
            {

                if (txt_mkmoi.Text.Equals(txt_xnmk.Text))
                {
                    nhanvien.MATKHAU = txt_mkmoi.Text;
                    if (bllnv.BLLSuaNV(nhanvien))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo");
                }
                else
                    MessageBox.Show("xác nhận mật khẩu không đúng", "Thông báo");
            }
        }
    }
}
