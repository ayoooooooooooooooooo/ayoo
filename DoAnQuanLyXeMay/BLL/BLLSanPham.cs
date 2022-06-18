using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalsp = new DALSanPham();
        public BLLSanPham() { }
        public List<SANPHAM> dsSanPham()
        {
            return dalsp.dsSanPham();
        }

        public bool xoasp(string masp)
        {
            return dalsp.xoasp(masp);

        }
        public bool suasp(SANPHAM sp)
        {
            return dalsp.suasp(sp);

        }
        public bool themsp(SANPHAM sp)
        {
            return dalsp.themsp(sp);

        }
        public string maspauto()
        {
            int kq = 0;
            string masp = "SP";
            foreach (SANPHAM sp in dsSanPham())
            {
                int maspnow = int.Parse(sp.MASP.Substring(2,2));
                if (kq < maspnow || kq == maspnow)
                    kq = maspnow + 1;

            }
            return masp + kq;

        }
    }
}
