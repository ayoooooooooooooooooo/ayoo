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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btn_dnkh_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_dnkh_MouseHover(object sender, EventArgs e)
        {
            btn_dnkh.BackColor = Color.White;
        }

        private void btn_dnkh_MouseLeave(object sender, EventArgs e)
        {
            btn_dnkh.BackColor = Color.FromArgb(32, 38, 71);
        }

        private void btn_thoat_MouseHover(object sender, EventArgs e)
        {
            btn_thoat.BackColor = Color.White;
        }

        private void btn_thoat_MouseLeave(object sender, EventArgs e)
        {
            btn_thoat.BackColor = Color.FromArgb(32, 38, 71);
        }
    }
}
