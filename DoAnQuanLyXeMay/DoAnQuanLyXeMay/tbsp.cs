using BLL;
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
namespace DoAnQuanLyXeMay
{
    public partial class tbsp : Form
    {
        public tbsp()
        {
            InitializeComponent();
        }
        string nhasx="";
        public tbsp(string hangxe)
            : this()
        {
            nhasx = hangxe;

        }
        BLLSanPham bLLSanPham = new BLLSanPham();
        private void XeHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bLLSanPham.dsSanPham();
            txt_nsx.DataSource = bLLNCC.dsNhanVien();
            txt_nsx.ValueMember = "MANCC";
            txt_nsx.DisplayMember = "TENNCC";
            btn_sua.Enabled = btn_xoa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_mota.Text  = txt_loaisp.Text = txt_nambh.Text = txt_nsx.Text = txt_tensp.Text = "";
            txt_masp.Text = bLLSanPham.maspauto();
            btn_tv.Enabled = true;
            txt_masp.Enabled = true;
        }
        BLLNCC bLLNCC= new BLLNCC();
        private void btn_tv_Click(object sender, EventArgs e)
        {
            SANPHAM sp = new SANPHAM();
            sp.MASP = txt_masp.Text;
            sp.LOAISP= txt_loaisp.Text;
            sp.NAMBH = int.Parse(txt_nambh.Text);
            sp.NHASX=txt_nsx.SelectedValue.ToString();
            sp.TENSP = txt_tensp.Text;
            sp.NGAYSX =DateTime.Parse( txt_ngaysx.Text);
            sp.NGAYXUATKHAU = DateTime.Parse(txt_ngayxuatkhau.Text);
            sp.MOTASP = txt_mota.Text;
            if (txt_masp.Enabled == false)
            {
                if (bLLSanPham.suasp(sp))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dataGridView1.DataSource = bLLSanPham.dsSanPham();
                }
                else
                    MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            else
            {
                if (bLLSanPham.themsp(sp))
                {

                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dataGridView1.DataSource = bLLSanPham.dsSanPham();
                } 
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (bLLSanPham.xoasp(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                MessageBox.Show("Xóa thành công", "Thông báo");
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_masp.Enabled = false;
            btn_tv.Enabled = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_loaisp.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_masp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_mota.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_nambh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
         
            txt_nsx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tensp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            string nsx = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_ngaysx.Value = DateTime.Parse(nsx);
            txt_ngaysx.Text = txt_ngaysx.Value.ToString("yyyy-MM-dd");
            string nxk = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_ngayxuatkhau.Value = DateTime.Parse(nxk);
            txt_ngayxuatkhau.Text = txt_ngayxuatkhau.Value.ToString("yyyy-MM-dd");
            btn_sua.Enabled = btn_xoa.Enabled = true;
          
        }
    }
}
