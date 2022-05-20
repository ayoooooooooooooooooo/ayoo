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
    public partial class HoaDonXuat : Form
    {
        public HoaDonXuat()
        {
            InitializeComponent();
        }
 BLLHDXuat bLLHDXuat=new BLLHDXuat();
        private void HoaDonXuat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bLLHDXuat.dsHDXuat();
            //Databingding(bLLHDXuat.dsHDXuat());
            txt_manv.Enabled = false;
            btn_luu.Enabled = false;
        }
        void Databingding(DataTable pDT)
        {
            txt_mahd.DataBindings.Clear();
            txt_masp.DataBindings.Clear();
            txt_makh.DataBindings.Clear();
            txt_manv.DataBindings.Clear();
            dt_ngayban.DataBindings.Clear();

            txt_masp.DataBindings.Add("Text", pDT, "MASP");
            txt_mahd.DataBindings.Add("Text", pDT, "MAHD");
            txt_makh.DataBindings.Add("Text", pDT, "MAKH");
            txt_manv.DataBindings.Add("Text", pDT, "MANV");
            dt_ngayban.DataBindings.Add("Text", pDT, "NGAYBAN");

        }
        string manv,mkh;
         public HoaDonXuat(string manhanvien):this()
        {
            manv = manhanvien;

        }
      

         private void btn_xoahdx_Click(object sender, EventArgs e)
         {
             //xldl.loadhdx();
             //if (xldl.xoahdx(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
             //    MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
             //else
             //    MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo");
         }

         private void btn_themhdx_Click(object sender, EventArgs e)
         {
             btn_luu.Enabled = true;
             txt_mahd.Text = txt_masp.Text = txt_makh.Text = null;
             txt_manv.Enabled = false;
             txt_manv.Text = manv;
             txt_mahd.Enabled = txt_masp.Enabled = txt_makh.Enabled = true;
             txt_gia.Enabled = true;
             dt_ngayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
             dt_ngayban.Enabled = false;
         }

         private void btn_luu_Click(object sender, EventArgs e)
         {
             //List<kho> lstkhoban = xldl.loadkhoban();
             //List<kho> lstkhonhap = xldl.loadkho();
             //xldl.tinhxeconlai(lstkhoban, lstkhonhap);
             //int dem=0;
             //foreach(kho a in lstkhonhap)
             //{
             //    if (a.Masp.Equals(txt_masp.Text))
             //        if (a.Soluong < 1)
             //        {
             //            dem++;
             //            break;
             //        }
             //}
             //if (dem != 0)
             //{
             //    MessageBox.Show("Xe hiện tại đã hết không thể tạo hóa đơn.", "Thông báo");

             //}
             //else
             //{
             //    if (txt_mahd.Enabled == true)
             //    {
                     
             //        if (xldl.themhdx(txt_mahd.Text, txt_manv.Text, txt_masp.Text, txt_makh.Text))
             //        {

             //            xldl.loadcthdx();
             //            if (xldl.themcthdx(txt_mahd.Text, txt_masp.Text, 1, float.Parse(txt_gia.Text)))
             //                MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
             //            else
             //                MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
             //        }
             //        else
             //            MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
             //    }
             //    else
             //    {
             //        if (xldl.suahdx(txt_mahd.Text, txt_masp.Text, txt_makh.Text))
             //            MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
             //        else
             //            MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo");
             //    }
             //}
         }

         private void btn_suahdx_Click(object sender, EventArgs e)
         {
             btn_luu.Enabled = true;
             dt_ngayban.Enabled = txt_masp.Enabled = txt_makh.Enabled = true;
             txt_mahd.Enabled = false;
         }

         private void dataGridView1_SelectionChanged(object sender, EventArgs e)
         {
             txt_makh.Enabled = false;
             txt_mahd.Enabled = false;
             txt_masp.Enabled = false;
             btn_luu.Enabled = false;
             dt_ngayban.Enabled = false;
         }

         private void label6_Click(object sender, EventArgs e)
         {

         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {
             ////string mahd = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             //INHDcr a = new INHDcr();
             
             //xldl.inHD(dataGridView1.CurrentRow.Cells[1].Value.ToString());
         }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctx_hdxuat_Opening(object sender, CancelEventArgs e)
         {

         }
    }
}
