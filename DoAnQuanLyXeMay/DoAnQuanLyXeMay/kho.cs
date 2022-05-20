using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyXeMay
{
    class kho
    {
        string masp;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        float dongia, thanhtien;

        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public kho() { }
    }
}
