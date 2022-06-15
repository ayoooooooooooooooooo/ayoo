using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALCTHDNHAP
    {
        QLXeMayDataContext qlxm=new QLXeMayDataContext();
         public DALCTHDNHAP() { }
        public List<CHITIETHDNHAP> lsthdn()
        {
            return qlxm.CHITIETHDNHAPs.Select(t=>t).ToList();
        }
        public bool xoacthdn(string mahd)
        {
            try
            {
                CHITIETHDNHAP cthdn = qlxm.CHITIETHDNHAPs.Single(t => t.MAHD.Equals(mahd));
                if (cthdn != null)
                {
                    qlxm.CHITIETHDNHAPs.DeleteOnSubmit(cthdn);
                    qlxm.SubmitChanges();
                }
                else
                    return false;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool suacthdn(CHITIETHDNHAP cthdn)
        {
            try
            {

                CHITIETHDNHAP cthoadonn = qlxm.CHITIETHDNHAPs.Single(t => t.MAHD.Equals(cthdn.MAHD));

                cthoadonn.MASP = cthdn.MASP;
                cthoadonn.SL = cthdn.SL;
                cthoadonn.DONGIA = cthdn.DONGIA;
                cthoadonn.THUE = cthdn.THUE;
                qlxm.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
        public bool themcthdn(CHITIETHDNHAP cthdn)
        {
            try
            {
                qlxm.CHITIETHDNHAPs.InsertOnSubmit(cthdn);
                qlxm.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
    }
}
