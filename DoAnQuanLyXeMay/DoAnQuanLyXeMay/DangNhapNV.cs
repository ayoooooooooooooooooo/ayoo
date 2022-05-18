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
            if (bllnv.dangNhapNV(txt_tknv.Text, txt_mknv.Text))
            {
                DangkiNV a = new DangkiNV();
                a.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                txt_tknv.Focus();

            }    
        }
    }
}
