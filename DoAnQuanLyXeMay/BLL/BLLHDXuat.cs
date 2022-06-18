using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLHDXuat
    {
        DALHDXuat daHDXuat = new DALHDXuat();
        public BLLHDXuat() { }
        public List<HOADONXUAT> dsHDXuat()
        {
            return daHDXuat.dsHDXuat();
        }
        DALCTHDNHAP dalcthdnhap = new DALCTHDNHAP();
        DALCTHDXUAT dalcthdxuat = new DALCTHDXUAT();
        public List<HOADONXUAT> dsHDXuattheongay(string ngay)
        {
            return daHDXuat.dsHDXuattheongay(ngay);
        }
        public double tinhdoanhthu(DateTime ngay)
        {
            double kq = 0;
            foreach (HOADONXUAT hdx in dsHDXuat())
            {
                DateTime ngayhdx = DateTime.Parse(hdx.NGAYBAN.ToString());
                if (ngayhdx.ToString("dd/MM/yyyy").Equals(ngay.ToString("dd/MM/yyyy")))
                {
                    foreach (CHITIETHDXUAT ctx in dalcthdxuat.lsthdx())
                    {
                        if (ctx.MAHD.Equals(hdx.MAHD))
                        {

                            kq += double.Parse(ctx.THANHTIEN.ToString());
                        }
                    }
                }
            }
            return kq;
        }
        public List<kho> tinhkho()
        {
            List<kho> lstk = new List<kho>();
            List<CHITIETHDNHAP> lsthdnhap = dalcthdnhap.lsthdn();
            List<CHITIETHDXUAT> lsthdxuat = dalcthdxuat.lsthdx();
            foreach (CHITIETHDNHAP cHITIETHDNHAP in lsthdnhap)
            {
                if (lstk.Count != 0)
                {
                    foreach (kho k in lstk)
                    {
                        if (k.Masp.Equals(cHITIETHDNHAP.MASP))
                        {
                            k.Soluong = (int)(k.Soluong + cHITIETHDNHAP.SL);
                            break;
                        }
                        else
                        {
                            kho a = new kho(cHITIETHDNHAP.MASP, (int)cHITIETHDNHAP.SL);
                            lstk.Add(a);
                            break;
                        }
                    }
                }
                else
                {
                    kho k1123 = new kho(cHITIETHDNHAP.MASP, (int)cHITIETHDNHAP.SL);
                    lstk.Add(k1123);
                }
            }
            foreach (CHITIETHDXUAT cHITIETHDXUAT in lsthdxuat)
            {
                foreach (kho k in lstk)
                {
                    if (k.Masp.Equals(cHITIETHDXUAT.MASP))
                    {
                        k.Soluong = (int)(k.Soluong - cHITIETHDXUAT.SL);
                        break;
                    }

                }
            }
            return lstk;
        }
        public bool Ktraxetrongkho(string masp,int sl) 
        {

            foreach (kho k in tinhkho())
                if (masp.Equals(k.Masp))
                        if (k.Soluong >= sl)
                            return true;
                        else
                            return false;

            return false;
         
        }
        public bool xoahdx(string mahd)
        {
            return daHDXuat.xoahdx(mahd);

        }
        public bool suahdx(HOADONXUAT hdx)
        {
            return daHDXuat.suahdx(hdx);

        }
        public bool themhdx(HOADONXUAT hdx)
        {
            return daHDXuat.themhdx(hdx);

        }
        public string mahdauto()
        {
            int kq=0;
            string mahd="HDX";
            foreach(HOADONXUAT hdx in dsHDXuat())
            {
                int mhdnow = int.Parse(hdx.MAHD.Substring(3));
                if(kq<mhdnow||kq==mhdnow)
                    kq=mhdnow+1;

            }
            return mahd + kq;

        }

    }
}
