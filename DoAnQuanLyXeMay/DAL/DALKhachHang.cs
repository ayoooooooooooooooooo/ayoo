using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhachHang
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALKhachHang() { }

        public List<KHACHHANG> dsKhachHang()
        {
            return qL.KHACHHANGs.Select(t => t).ToList();

        }
        public bool xoakh(string makh)
        {
            try
            {
                KHACHHANG kh = qL.KHACHHANGs.Single(t => t.MAKH.Equals(makh));
                if (kh != null)
                {
                    qL.KHACHHANGs.DeleteOnSubmit(kh);
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
        public bool suakh(KHACHHANG kh)
        {
            try
            {

                KHACHHANG khh = qL.KHACHHANGs.Single(t => t.MAKH.Equals(kh.MAKH));
                khh.TENKH = kh.TENKH;
                khh.DIACHI = kh.DIACHI;
                khh.SDT = kh.SDT;
                khh.DIACHI = kh.DIACHI;
                khh.GIOITINH=kh.GIOITINH;
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
        public bool themkh(KHACHHANG kh)
        {
            try
            {
                qL.KHACHHANGs.InsertOnSubmit(kh);
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
    }
}
