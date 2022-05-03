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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLLNHhanVien bllnv = new BLLNHhanVien();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bllnv.dsNhanVien();
            comboBox1.DisplayMember = "TENNV";
            comboBox1.ValueMember = "MANV";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangkiNV a = new DangkiNV();
            a.Show();
        }
    }
}
