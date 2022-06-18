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
    public partial class thongtinnv : Form
    {
        public thongtinnv()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllnv.dsNhanVien();
            List<string> listgt = new List<string>();
            List<string> listpl = new List<string>();
            listgt.Add("Nam");
            listgt.Add("Nữ");
            listpl.Add("ql");
            listpl.Add("nv"); 
            txt_gt.DataSource= listgt;
            txt_pl.DataSource= listpl; 
            btn_sua.Enabled = btn_xoa.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            themnv a = new themnv();
            a.Show();
            a.MdiParent = this.MdiParent;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();

            nv.MANV = txt_manv.Text;
            nv.TENNV = txt_hoten.Text;
            nv.SDT = txt_sodt.Text;
            nv.EMAILNV = txt_email.Text;
            nv.NGAYVL = txt_ngayvl.Value;
            nv.CMND = txt_cmnd.Text;
            nv.DIACHI = txt_diachi.Text;
            nv.GIOITINH = txt_gt.SelectedItem.ToString();
            nv.MATKHAU = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            nv.TAIKHOAN = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            nv.NGAYSINH = txt_ngaysinh.Value;
            nv.PHANLOAI = txt_pl.SelectedItem.ToString();
            txt_manv.Enabled = false;
            if (bllnv.BLLSuaNV(nv))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                dataGridView1.DataSource = bllnv.dsNhanVien();
            }
            else
                MessageBox.Show("Sửa nhân viên thất bại");
            btn_luu.Enabled=btn_sua.Enabled = btn_xoa.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (bllnv.BLLxoaNV(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                dataGridView1.DataSource=bllnv.dsNhanVien();
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = false;
            btn_luu.Enabled = true;
        
      
        }
        string mnv=""; 
            bool loai=true;
        public thongtinnv(string manv):this()
        {
            manv = mnv;
            
        }
        private void btn_tv_Click(object sender, EventArgs e)
        {
            nhanvien a = new nhanvien(loai,mnv);
            a.Show();
            this.Close();

        }
        BLLNHhanVien bllnv=new BLLNHhanVien();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_cmnd.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txt_gt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_manv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txt_phanloai.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_sodt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string ns = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string nvl = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txt_ngaysinh.Value = DateTime.Parse(ns);
            txt_ngaysinh.Text = txt_ngaysinh.Value.ToString("yyyy-MM-dd");
            txt_ngayvl.Value = DateTime.Parse(nvl);
            txt_ngayvl.Text = txt_ngayvl.Value.ToString("yyyy-MM-dd");
            btn_sua.Enabled = btn_xoa.Enabled = true;
        }
    }
}
