using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLCTHDNhap
    {

        public BLLCTHDNhap() { }
        DALCTHDNHAP dalcthdn = new DALCTHDNHAP();
        public List<CHITIETHDNHAP> lstcthdnhap()
        { return dalcthdn.lsthdn(); }

        public List<CHITIETHDNHAP> lstcthdnhap(string mahd)
        {

            List<CHITIETHDNHAP> lstnhaptheoma = new List<CHITIETHDNHAP>();
            
            foreach (CHITIETHDNHAP a in lstcthdnhap())
            {
                if (a.MAHD.Equals(mahd))
                    lstnhaptheoma.Add(a);
            }
            return lstnhaptheoma;
        }
        public double tinhthanhtien(double dongia,double sl,double thue)
        {
            return dongia * sl + thue * dongia*sl;
        }
        public bool xoahdn(string masp,string mahd)
        {
            return dalcthdn.xoacthdn(masp,mahd);

        }
        public bool suahdn(CHITIETHDNHAP hdn)
        {
            return dalcthdn.suacthdn(hdn);

        }
        public bool themhdn(CHITIETHDNHAP hdn)
        {
            return dalcthdn.themcthdn(hdn);

        }
    }
}
