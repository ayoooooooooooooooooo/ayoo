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
    public partial class HoadonNhap : Form
    {
        public HoadonNhap()
        {
            InitializeComponent();
        }

        private void tbL_hdN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            txt_mahd.Text = txt_masp.Text = txt_soluong.Text = "";
            txt_manv.Enabled = false;
            txt_manv.Text = manv;
            txt_mahd.Enabled = txt_masp.Enabled = txt_soluong.Enabled  = true;
            txt_gia.Enabled = true;
            dt_ngayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dt_ngayban.Enabled = false;
        }

        void Databingding(DataTable pDT)
        {
            txt_mahd.DataBindings.Clear();
            txt_masp.DataBindings.Clear();
            txt_soluong.DataBindings.Clear();
            txt_manv.DataBindings.Clear();
            dt_ngayban.DataBindings.Clear();

            txt_masp.DataBindings.Add("Text", pDT, "MASP");
            txt_mahd.DataBindings.Add("Text", pDT, "MAHD");
            txt_soluong.DataBindings.Add("Text", pDT, "SL");
            txt_manv.DataBindings.Add("Text", pDT, "MANV");
            dt_ngayban.DataBindings.Add("Text", pDT, "NGAYBAN");
    
        }
        string manv="";
        public HoadonNhap(string manhanvien):this()
        {
            manv = manhanvien;
            
        }

        private void HoadonNhap_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = xldl.loadhdn();
            //Databingding(xldl.loadhdn());
            //txt_manv.Enabled = false;
            //btn_them.Enabled = false;
        }

        private void btn_xoahdn_Click(object sender, EventArgs e)
        {
           
            //if (xldl.xoahdn(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            //{
            //        MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
            //}
            //else
            //    MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //if (txt_mahd.Enabled == true)
            //{
            //    if (xldl.themhn(txt_mahd.Text, txt_manv.Text, txt_masp.Text, int.Parse(txt_soluong.Text)))
            //    {
            //        xldl.loadcthdn();
            //        if (xldl.themcthdn(txt_mahd.Text,txt_masp.Text, int.Parse(txt_soluong.Text),float.Parse(txt_gia.Text)))
            //        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
            //        else
            //            MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
            //    }
            //    else
            //        MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
            //}
            //else
            //{
            //    if (xldl.suahdn(txt_mahd.Text, txt_masp.Text, int.Parse(txt_soluong.Text)))
            //        MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
            //    else
            //        MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo");
            //}
        }

        private void btn_suahdn_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            dt_ngayban.Enabled = txt_masp.Enabled =txt_soluong.Enabled= true ;
            txt_mahd.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_soluong.Enabled = false;
            txt_mahd.Enabled = false;
            txt_masp.Enabled = false;
            btn_them.Enabled = false;
            dt_ngayban.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xcthdn_Click(object sender, EventArgs e)
        {

        }
    }
}
