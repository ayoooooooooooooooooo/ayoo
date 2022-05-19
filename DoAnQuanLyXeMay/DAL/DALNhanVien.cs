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
            NHANVIEN a = new NHANVIEN();
            a.MANV=nv.MANV;
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
        public List<NHANVIEN> dsNhanVien()
        {
            return qL.NHANVIENs.Select(t=>t).ToList();

        }
    }
}
