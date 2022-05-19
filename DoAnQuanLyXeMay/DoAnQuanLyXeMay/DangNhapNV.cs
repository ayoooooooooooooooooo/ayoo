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
<<<<<<< HEAD
                //DangkiNV a = new DangkiNV();
                //a.Show();
=======
                DangNhap a = new DangNhap();
                a.Show();
>>>>>>> 1b92c68af9b20fed72fc88478c54c2c1628e964a
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                txt_tknv.Focus();

            }    
        }

        private void DangNhapNV_Load(object sender, EventArgs e)
        {

        }
    }
}
