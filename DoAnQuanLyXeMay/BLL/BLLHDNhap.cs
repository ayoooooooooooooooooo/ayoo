using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLHDNhap
    {
        DALHDNhap dALHDNhap = new DALHDNhap();
        public BLLHDNhap() { }
        public List<HOADONNHAP> dsHDNhap()
        {
            return dALHDNhap.dsHDNhap();
        }
        public bool xoahdn(string mahd)
        {
            return dALHDNhap.xoahdn(mahd);

        }
        public bool suahdn(HOADONNHAP hdn)
        {
            return dALHDNhap.suahdn(hdn);

        }
        public bool themhdn(HOADONNHAP hdn)
        {
            return dALHDNhap.themhdn(hdn);

        }
        public string mahdauto()
        {
            int kq = 0;
            string mahd = "HDN";
            foreach (HOADONNHAP hdn in dsHDNhap())
            {
                int mhdnow = int.Parse(hdn.MAHD.Substring(3));
                if (kq < mhdnow || kq == mhdnow)
                    kq = mhdnow + 1;

            }
            return mahd + kq;

        }
    }
}
