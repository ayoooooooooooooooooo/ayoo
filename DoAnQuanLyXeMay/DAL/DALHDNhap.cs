using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHDNhap
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALHDNhap() { }

        public List<HOADONNHAP> dsHDNhap()
        {
            return qL.HOADONNHAPs.Select(t => t).ToList();

        }
        public bool xoahdn(string mahd)
        {
            try
            {
                HOADONNHAP hdn = qL.HOADONNHAPs.Single(t => t.MAHD.Equals(mahd));
                if (hdn != null)
                {
                    qL.HOADONNHAPs.DeleteOnSubmit(hdn);
                    qL.SubmitChanges();
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
        public bool suahdn(HOADONNHAP hdn)
        {
            try
            {

                HOADONNHAP hoadonn = qL.HOADONNHAPs.Single(t => t.MAHD.Equals(hdn.MAHD));
               
                hoadonn.NGAYNHAP = hdn.NGAYNHAP;
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
        public bool themhdn(HOADONNHAP hdn)
        {
            try
            {
                qL.HOADONNHAPs.InsertOnSubmit(hdn);
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
    }
}
