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
    }
}
