using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public  class BLLNHhanVien
    {
        DALNhanVien dalnv= new DALNhanVien();
        public BLLNHhanVien() { }
        
        public bool BLLthemNV(NHANVIEN nv)
        {
            dalnv.DALthemNV(nv);

            return true;
        }
        public bool BLLSuaNV(NHANVIEN nv)
        {
            dalnv.DALSuaNV(nv);
            return true;
        }
        public NHANVIEN BLLLay1NV(string manv)
        {
            
            return dalnv.DALLay1NV(manv);
        }

        public NHANVIEN BLLLay1NV(string tk,string mk)
        {

            return dalnv.DALLay1NV(tk,mk);
        }
        public List<NHANVIEN> dsNhanVien()
        {
            return dalnv.dsNhanVien();
        }

        public string BLLlayTenNV(string manv)
        {
            NHANVIEN nv= BLLLay1NV(manv);
            if(nv==null)
                return null;
            else
            
                return nv.TENNV; 
            

        }   

        public bool dangNhapNV(string tk,string mk)
        {
            List<NHANVIEN> listnv = dsNhanVien();
            foreach(NHANVIEN a in listnv)
            {
                if (tk.Equals(a.TAIKHOAN) && mk.Equals(a.MATKHAU))
                    return true;
            }    
            return false;
        }
       
    }
}
