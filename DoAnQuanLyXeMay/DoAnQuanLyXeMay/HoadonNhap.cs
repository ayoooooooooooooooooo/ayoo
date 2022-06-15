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
            txt_mahd.Text = "";
            txt_manv.Enabled = false;
            txt_manv.Text = manv;
            txt_mahd.Enabled  = true;

            dt_ngayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dt_ngayban.Enabled = false;
        }

     
        string manv="";
        public HoadonNhap(string manhanvien):this()
        {
            manv = manhanvien;
            
        }
        BLLHDNhap bLLHDNhap=new BLLHDNhap();
        private void HoadonNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bLLHDNhap.dsHDNhap();
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
   
            txt_mahd.Enabled=false;
            txt_manv.Text = manv;
            txt_manv.Enabled = false;
            
        }

        private void btn_xoahdn_Click(object sender, EventArgs e)
        {

            if (bLLHDNhap.xoahdn(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                dataGridView1.DataSource=bLLHDNhap.dsHDNhap();
            }
            else
                MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = bLLHDNhap.mahdauto();
            txt_mahd.Enabled = false;
      
            txt_manv.Enabled = false;
            txt_manv.Text = manv;


            dt_ngayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dt_ngayban.Enabled = false;
        }
    

        private void btn_them_Click(object sender, EventArgs e)
        {
       
            HOADONNHAP hdn = new HOADONNHAP();
            hdn.MAHD = txt_mahd.Text;
            
            hdn.NGAYNHAP = dt_ngayban.Value;
            hdn.MANV = manv;
            if (!dt_ngayban.Enabled == true)
            {
                if (bLLHDNhap.themhdn(hdn))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                    dataGridView1.DataSource = bLLHDNhap.dsHDNhap();
                }
                else
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
            }

            else
            {
                if (bLLHDNhap.suahdn(hdn))
                {
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
                    dataGridView1.DataSource = bLLHDNhap.dsHDNhap();
                }
                else
                    MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo");
            }
        }

        private void btn_suahdn_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            dt_ngayban.Enabled = true ;
            txt_mahd.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_mahd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_manv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string a = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt_ngayban.Value = DateTime.Parse(a);
            dt_ngayban.Text = dt_ngayban.Value.ToString("yyyy-MM-dd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xcthdn_Click(object sender, EventArgs e)
        {
            chitiethoadonxuat  a= new chitiethoadonxuat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            a.Show();
        }
    }
}
