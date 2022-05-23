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
    public partial class XeTayGa : Form
    {
        public XeTayGa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        dulieu xldl = new dulieu();
        void Databingding(DataTable pDT)
        {
            txt_masp.DataBindings.Clear();
            txt_tensp.DataBindings.Clear();
            txt_nambh.DataBindings.Clear();
            txt_ngaysx.DataBindings.Clear();
            txt_xuatkhau.DataBindings.Clear();
            txt_nsx.DataBindings.Clear();
            txt_mota.DataBindings.Clear();
            txt_loaisp.DataBindings.Clear();

            txt_masp.DataBindings.Add("Text", pDT, "MASP");
            txt_tensp.DataBindings.Add("Text", pDT, "TENSP");
            txt_nsx.DataBindings.Add("Text", pDT, "NHASX");
            txt_ngaysx.DataBindings.Add("Text", pDT, "NGAYSX");
            txt_xuatkhau.DataBindings.Add("Text", pDT, "NGAYXUATKHAU");
            txt_nambh.DataBindings.Add("Text", pDT, "NAMBH");
            txt_loaisp.DataBindings.Add("Text", pDT, "LOAISP");
            txt_mota.DataBindings.Add("Text", pDT, "MOTASP");

        }
        private void XeTayGa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xldl.loadtayga();
            Databingding(xldl.loadtayga());
        }
    }
}
