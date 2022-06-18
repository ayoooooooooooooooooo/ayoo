using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNhanVien
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALNhanVien() { }
        public bool DALthemNV(NHANVIEN nv)
        {
            try
            {
                NHANVIEN a = new NHANVIEN();
                a.MANV = nv.MANV;
                a.TENNV = nv.TENNV;
                a.EMAILNV = nv.EMAILNV;
                a.DIACHI = nv.DIACHI;
                a.SDT = nv.SDT;
                a.NGAYSINH = nv.NGAYSINH;
                a.GIOITINH = nv.GIOITINH;
                a.TAIKHOAN = nv.TAIKHOAN;
                a.MATKHAU = nv.MATKHAU;
                a.PHANLOAI = nv.PHANLOAI;
                a.NGAYVL = nv.NGAYVL;
                a.CMND = nv.CMND;
                qL.NHANVIENs.InsertOnSubmit(a);
                qL.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool DALSuaNV(NHANVIEN nv)
        {
            
         
            NHANVIEN nhanvien = qL.NHANVIENs.Where(t => t.MANV ==nv.MANV).FirstOrDefault();
            if (nhanvien != null)
            {
               
                nhanvien.TENNV = nv.TENNV;
                nhanvien.EMAILNV = nv.EMAILNV;
                nhanvien.DIACHI = nv.DIACHI;
                nhanvien.SDT = nv.SDT;
                nhanvien.NGAYSINH = nv.NGAYSINH;
                nhanvien.GIOITINH = nv.GIOITINH;
                nhanvien.TAIKHOAN = nv.TAIKHOAN;
                nhanvien.MATKHAU = nv.MATKHAU;
                nhanvien.PHANLOAI = nv.PHANLOAI;
                nhanvien.NGAYVL = nv.NGAYVL;
                nhanvien.CMND = nv.CMND;
                qL.SubmitChanges();
                return true;
       
            }
            else
            {
              return false;
            }
        }
        public bool DALxoaNV(string manv)
        {

            try
            {
                NHANVIEN nhanvien = qL.NHANVIENs.Where(t => t.MANV == manv).FirstOrDefault();
                if (nhanvien != null)
                {

                    qL.NHANVIENs.DeleteOnSubmit(nhanvien);
                    qL.SubmitChanges();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
        public NHANVIEN DALLay1NV(string manv)
        {


            NHANVIEN nhanvien = qL.NHANVIENs.Where(t => t.MANV == manv).FirstOrDefault();
            return nhanvien;
        }

        public NHANVIEN DALLay1NV(string tk,string mk)
        {


            NHANVIEN nhanvien = qL.NHANVIENs.Where(t => t.TAIKHOAN == tk ).FirstOrDefault();
            return nhanvien;
        }
        public List<NHANVIEN> dsNhanVien()
        {
            return qL.NHANVIENs.Select(t=>t).ToList();

        }
    }
}
