using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class XeTheoHang : Form
    {
        public XeTheoHang()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_tv_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void Databingding(DataTable pDT)
        {
            txt_masp.DataBindings.Clear();
            txt_tensp.DataBindings.Clear();
            txt_nambh.DataBindings.Clear();
            txt_ngaysx.DataBindings.Clear();
            txt_ngayxuatkhau.DataBindings.Clear();
            txt_nsx.DataBindings.Clear();
            txt_mota.DataBindings.Clear();
            txt_loaisp.DataBindings.Clear();

            txt_masp.DataBindings.Add("Text", pDT, "MASP");
            txt_tensp.DataBindings.Add("Text", pDT, "TENSP");
            txt_nsx.DataBindings.Add("Text", pDT, "NHASX");
            txt_ngaysx.DataBindings.Add("Text", pDT, "NGAYSX");
            txt_ngayxuatkhau.DataBindings.Add("Text", pDT, "NGAYXUATKHAU");
            txt_nambh.DataBindings.Add("Text", pDT, "NAMBH");
            txt_loaisp.DataBindings.Add("Text", pDT, "LOAISP");
            txt_mota.DataBindings.Add("Text", pDT, "MOTASP");

        }
        dulieu xldl = new dulieu();
        private void XeSo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xldl.loadxeso();
            Databingding(xldl.loadxeso());

        }
    }
}
