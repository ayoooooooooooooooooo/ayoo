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
    public partial class HoaDonXuat : Form
    {
        public HoaDonXuat()
        {
            InitializeComponent();
        }
        BLLHDXuat bllHDXuat= new BLLHDXuat();
        BLLKhachHang bLLKhachHang= new BLLKhachHang();
        BLLSanPham bllsp= new BLLSanPham();
        private void HoaDonXuat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllHDXuat.dsHDXuat();
            dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            txt_makh.DataSource = bLLKhachHang.dskhachhang();
            txt_makh.ValueMember = "MAKH";
            txt_makh.DisplayMember = "TENKH";
            txt_manv.Text = manv;
            txt_manv.Enabled = false;
            btn_luu.Enabled = false;
        }
       
        string manv;
         public HoaDonXuat(string manhanvien):this()
        {
            manv = manhanvien;

        }
      

         private void btn_xoahdx_Click(object sender, EventArgs e)
         {

            if (bllHDXuat.xoahdx(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                dataGridView1.DataSource = bllHDXuat.dsHDXuat();
            }
            else
                MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo");
        }

         private void btn_themhdx_Click(object sender, EventArgs e)
         {
             btn_luu.Enabled = true;
             txt_mahd.Text = bllHDXuat.mahdauto();txt_mahd.Enabled = false;
             txt_makh.Text = "";
             txt_manv.Enabled = false;
             txt_manv.Text = manv;
             txt_makh.Enabled = true;
                
             dt_ngayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
             dt_ngayban.Enabled = false;
         }

         private void btn_luu_Click(object sender, EventArgs e)
         {
            
                HOADONXUAT hdx=new HOADONXUAT();
            hdx.MAHD = txt_mahd.Text;
            hdx.MAKH= txt_makh.SelectedValue.ToString();
            hdx.NGAYBAN=dt_ngayban.Value;
            hdx.MANV = manv;
            if (!dt_ngayban.Enabled == true)
            {
                if (bllHDXuat.themhdx(hdx))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                    dataGridView1.DataSource = bllHDXuat.dsHDXuat();
                }
                else
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
            }

            else
            {
                if (bllHDXuat.suahdx(hdx))
                {
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
                    dataGridView1.DataSource = bllHDXuat.dsHDXuat();
                }
                else
                    MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo");
            }
          
        }

         private void btn_suahdx_Click(object sender, EventArgs e)
         {
             btn_luu.Enabled = true;

            txt_manv.Enabled=txt_mahd.Enabled = false;
            txt_makh.Enabled = dt_ngayban.Enabled = true;
         }

         private void dataGridView1_SelectionChanged(object sender, EventArgs e)
         {
             txt_makh.Enabled = false;
             txt_mahd.Enabled = false;

             btn_luu.Enabled = false;
             dt_ngayban.Enabled = false;
         }

         private void label6_Click(object sender, EventArgs e)
         {

         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
      
        }

        private void btn_xcthdx_Click(object sender, EventArgs e)
        {
            chitiethoadonxuat a = new chitiethoadonxuat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            a.Show();
            this.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_makh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_manv.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string a = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dt_ngayban.Value = DateTime.Parse(a);
            dt_ngayban.Text = dt_ngayban.Value.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
         {
             ////string mahd = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             //INHDcr a = new INHDcr();
             
             //xldl.inHD(dataGridView1.CurrentRow.Cells[1].Value.ToString());
         }
    }
}
