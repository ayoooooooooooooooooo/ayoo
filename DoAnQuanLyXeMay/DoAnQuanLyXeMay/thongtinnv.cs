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
        void Databingding(List<NHANVIEN> pDT)
        {
            txt_manv.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_ngaysinh.DataBindings.Clear();
            txt_ngayvl.DataBindings.Clear();
            txt_phanloai.DataBindings.Clear();
            txt_sodt.DataBindings.Clear();
            txt_gt.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_cmnd.DataBindings.Clear();


            txt_manv.DataBindings.Add("Text", pDT, "MANV");
            txt_hoten.DataBindings.Add("Text", pDT, "TENNV");
            txt_ngaysinh.DataBindings.Add("Text", pDT, "NGAYSINH");
            txt_ngayvl.DataBindings.Add("Text", pDT, "NGAYVL");
            txt_phanloai.DataBindings.Add("Text", pDT, "PHANLOAI");
            txt_sodt.DataBindings.Add("Text", pDT, "SDT");
            txt_gt.DataBindings.Add("Text", pDT, "GIOITINH");
            txt_email.DataBindings.Add("Text", pDT, "EMAILNV");
            txt_diachi.DataBindings.Add("Text", pDT, "DIACHI");
            txt_cmnd.DataBindings.Add("Text", pDT, "CMND");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllnv.dsNhanVien();
            Databingding(bllnv.dsNhanVien());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            themnv a = new themnv();
            a.Show();
            a.MdiParent = this.MdiParent;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            txt_manv.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_ngaysinh.DataBindings.Clear();
            txt_ngayvl.DataBindings.Clear();
            txt_phanloai.DataBindings.Clear();
            txt_sodt.DataBindings.Clear();
            txt_gt.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_cmnd.DataBindings.Clear();
            //if (xldl.suanv(txt_hoten.Text, txt_manv.Text, txt_email.Text, txt_diachi.Text, txt_sodt.Text, txt_ngaysinh.Text, txt_gt.Text,txt_phanloai.Text, txt_ngayvl.Text, txt_cmnd.Text))
            //    MessageBox.Show("Sửa thành công", "Thông báo");
            //else
            //    MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //if (xldl.xoanv(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            //    MessageBox.Show("Xóa thành công", "Thông báo");
            //else
            //    MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = false;
        }
        string mnv; 
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
            Databingding(bllnv.dsNhanVien());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
