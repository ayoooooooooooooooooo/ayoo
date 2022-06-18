using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLCTHDXuat
    {
        public BLLCTHDXuat() { }
        DALCTHDXUAT dalctxuat= new DALCTHDXUAT();
        DALCTHDNHAP dalctnhap = new DALCTHDNHAP();
        public List<CHITIETHDXUAT> lstcthdxuat()
        { return dalctxuat.lsthdx(); }
        public List<CHITIETHDXUAT> lstcthdxuat(string mahd)
        {

            List<CHITIETHDXUAT> lstxuattheoma = new List<CHITIETHDXUAT>();

            foreach (CHITIETHDXUAT a in lstcthdxuat())
            {
                if (a.MAHD.Equals(mahd))
                    lstxuattheoma.Add(a);
            }
            return lstxuattheoma;
        }
        public bool xoahdx(string masp,string mahd)
        {
            return dalctxuat.xoacthdx(masp, mahd);

        }
        public bool suahdx(CHITIETHDXUAT hdx)
        {
            return dalctxuat.suacthdx(hdx);

        }
        public bool themhdx(CHITIETHDXUAT hdx)
        {
            return dalctxuat.themcthdx(hdx);

        }
       public double tinhtien(string mahd)
        
        {
            double kq = 0;
            if(mahd.Substring(0,3).Equals("HDX"))
            {
                foreach(CHITIETHDXUAT hdx in lstcthdxuat(mahd))
                {
                    kq += double.Parse(hdx.THANHTIEN.ToString());

                }    
            }    
            else
                foreach (CHITIETHDNHAP hdn in dalctnhap.lsthdn())
                {
                    if(hdn.MAHD.Equals(mahd))
                    kq += double.Parse(hdn.THANHTIEN.ToString());

                }
            return kq;
        }
        
    }
}
