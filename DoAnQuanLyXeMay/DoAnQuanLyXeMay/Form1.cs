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
           
            comboBox1.DisplayMember = "TENNV";
            comboBox1.ValueMember = "MANV";
            comboBox1.DataSource = bllnv.dsNhanVien();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhapNV a = new DangNhapNV();
            a.Show();
        }
       
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            


        }
        
    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
         
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonDN1_Click(object sender, EventArgs e)
        {
            DangNhapNV a = new DangNhapNV();
            a.Show();
            
        }

        private void buttonDN2_Click(object sender, EventArgs e)
        {
            doimknv a = new doimknv(bllnv.BLLLay1NV(comboBox1.SelectedValue.ToString()));

            a.Show();
        }
    }
}
