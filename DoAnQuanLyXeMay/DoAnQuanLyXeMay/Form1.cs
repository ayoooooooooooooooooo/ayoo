﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }
        int count = 1;

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (count == 1)
            {
                button1.Location = new Point(32, 100 ); 

                count = 0;
            }
            else
            {
                button1.Location= new Point(32, 75); 
                count = 1;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Anh cũng yêu em");
        }
        
    }
}
