using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHDXuat
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALHDXuat() { }
        DALCTHDNHAP dalcthdnhap= new DALCTHDNHAP();
        DALCTHDXUAT dalcthdxuat= new DALCTHDXUAT();
       
        public List<HOADONXUAT> dsHDXuat()
        {
            return qL.HOADONXUATs.Select(t => t).ToList();

        }
        public List<HOADONXUAT> dsHDXuattheongay(string ngay)
        {
            return qL.HOADONXUATs.Select(t => t).Where(t=>t.NGAYBAN.ToString().Equals(ngay)).ToList();
        }
        public bool xoahdx(string mahd)
        {
            try
            {
                HOADONXUAT hdx = qL.HOADONXUATs.Single(t => t.MAHD.Equals(mahd));
                if (hdx != null)
                {
                    qL.HOADONXUATs.DeleteOnSubmit(hdx);
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
        public bool suahdx(HOADONXUAT hdx)
        {
            try
            {

                HOADONXUAT hoadonx = qL.HOADONXUATs.Single(t => t.MAHD.Equals(hdx.MAHD));
                hoadonx.MAKH = hdx.MAKH;
                hoadonx.NGAYBAN = hdx.NGAYBAN;
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
        public bool themhdx(HOADONXUAT hdx)
        {
            try
            {
                qL.HOADONXUATs.InsertOnSubmit(hdx);
                qL.SubmitChanges();
                return true;
            }
            catch { return false; };


        }

    }
}
