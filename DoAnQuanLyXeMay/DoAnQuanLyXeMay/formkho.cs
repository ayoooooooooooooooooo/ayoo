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
using System.Globalization;
namespace DoAnQuanLyXeMay
{
    public partial class formkho : Form
    {
        public formkho()
        {
            InitializeComponent();
        }
        BLLHDXuat bllhdx= new BLLHDXuat();
        private void formkho_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bllhdx.tinhkho();
            
         }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_doanhthu.Text = String.Format("{0:0,0 vnđ}", bllhdx.tinhdoanhthu(txt_ngay.Value));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_doanhthu_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
