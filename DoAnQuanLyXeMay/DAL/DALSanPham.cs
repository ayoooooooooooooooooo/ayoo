using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSanPham
    {

        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALSanPham() { }

        public List<SANPHAM> dsSanPham()
        {
            return qL.SANPHAMs.Select(t => t).ToList();

        }
        public bool xoasp(string masp)
        {
            try
            {
                SANPHAM sp = qL.SANPHAMs.Single(t => t.MASP.Equals(masp));
                if (sp != null)
                {
                    qL.SANPHAMs.DeleteOnSubmit(sp);
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
        public bool suasp(SANPHAM sp)
        {
            try
            {

                SANPHAM spp = qL.SANPHAMs.Single(t => t.MASP.Equals(sp.MASP));

                spp.TENSP = sp.TENSP;
                spp.NAMBH = sp.NAMBH;
                spp.NGAYSX = sp.NGAYSX;
                spp.MOTASP = sp.MOTASP;
                spp.LOAISP= sp.LOAISP;  
                spp.NGAYXUATKHAU = sp.NGAYXUATKHAU;
                spp.NHASX= sp.NHASX;    
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
        public bool themsp(SANPHAM sp)
        {
            try
            {
                qL.SANPHAMs.InsertOnSubmit(sp);
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
    }
}
