using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalsp = new DALSanPham();
        public BLLSanPham() { }
        public List<SANPHAM> dsSanPham()
        {
            return dalsp.dsSanPham();
        }
    }
}
