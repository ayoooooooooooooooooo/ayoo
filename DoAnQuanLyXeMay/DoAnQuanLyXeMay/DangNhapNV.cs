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
    public partial class DangNhapNV : Form
    {
        
        public DangNhapNV()
        {
            InitializeComponent();
        }
        BLLNHhanVien bllnv = new BLLNHhanVien();
        private void btn_dnnv_Click(object sender, EventArgs e)
        {
            //if (bllnv.dangNhapNV(txt_tknv.Text, txt_mknv.Text))
            //{
            //    bool n=true;    
            //    NHANVIEN nv= bllnv.BLLLay1NV(txt_tknv.Text,txt_mknv.Text);
            //    if (nv.PHANLOAI.Equals("ql"))
            //    {
                   
            //        nhanvien a = new nhanvien(true, nv.MANV) ;
            //        a.Show();
            //        this.Close();

            //    }
            //    else
            //    {
            //        nhanvien a = new nhanvien(false, nv.MANV);
            //        a.Show();
            //        this.Close();
            //    }    

            //}
            //else
            //{
            //    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            //    txt_tknv.Focus();

            //}    
        }

        private void DangNhapNV_Load(object sender, EventArgs e)
        {

        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (bllnv.dangNhapNV(txt_tknv.Text, txt_mknv.Text))
            {
              
                NHANVIEN nv = bllnv.BLLLay1NV(txt_tknv.Text, txt_mknv.Text);
                if (nv.PHANLOAI.Equals("ql"))
                {
                   
                    nhanvien a = new nhanvien(true, nv.MANV);

                    a.Show();
                    
                    this.Visible=false;
                }
                else
                {
                    nhanvien a = new nhanvien(false, nv.MANV);
                    a.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                txt_tknv.Focus();

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
