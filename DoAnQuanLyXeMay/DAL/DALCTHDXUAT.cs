using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALCTHDXUAT
    {
        QLXeMayDataContext qlxm = new QLXeMayDataContext();
        public DALCTHDXUAT() { }
        public List<CHITIETHDXUAT> lsthdx()
        {
            return qlxm.CHITIETHDXUATs.Select(t => t).ToList();

        }
        public bool xoacthdx(string mahd)
        {
            try
            {
                CHITIETHDXUAT cthdx = qlxm.CHITIETHDXUATs.Single(t => t.MAHD.Equals(mahd));
                if (cthdx != null)
                {
                    qlxm.CHITIETHDXUATs.DeleteOnSubmit(cthdx);
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
        public bool suacthdx(CHITIETHDXUAT cthdx)
        {
            try
            {

                CHITIETHDXUAT cthoadonx = qlxm.CHITIETHDXUATs.Single(t => t.MAHD.Equals(cthdx.MAHD));

                cthoadonx.MASP = cthdx.MASP;
                cthoadonx.SL = cthdx.SL;
                cthoadonx.DONGIA = cthdx.DONGIA;
                cthoadonx.THUE = cthdx.THUE;
                qlxm.SubmitChanges();
                return true;
            }
            catch { return false; };


        }
        public bool themcthdx(CHITIETHDXUAT cthdx)
        {
            try
            {
                qlxm.CHITIETHDXUATs.InsertOnSubmit(cthdx);
                qlxm.SubmitChanges();
                return true;
            }
            catch { return false; };


        }

    }
}
