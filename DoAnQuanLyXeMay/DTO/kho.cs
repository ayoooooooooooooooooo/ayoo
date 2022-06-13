using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class kho
    {
        string masp;
        int soluong;

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public kho(string masp, int soluong)
        {
            this.masp = masp;
            this.soluong = soluong;
        }

    
    }
}
