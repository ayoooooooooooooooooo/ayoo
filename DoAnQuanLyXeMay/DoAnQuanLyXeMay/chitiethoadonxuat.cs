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
    public partial class chitiethoadonxuat : Form
    {
        string mahd = null;
        public chitiethoadonxuat()
        {
            InitializeComponent();
        }
        public chitiethoadonxuat(string mahd1):this()
        {
            mahd = mahd1;
        }
        BLLCTHDNhap bllctn= new BLLCTHDNhap();
        BLLCTHDXuat bllctx = new BLLCTHDXuat();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chitiethoadon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            if (mahd.Substring(0, 3).Equals("HDX"))
                dataGridView1.DataSource = bllctx.lstcthdxuat(mahd);
            else
                dataGridView1.DataSource = bllctn.lstcthdnhap(mahd);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_themhdx_Click(object sender, EventArgs e)
        {

        }
    }
}
