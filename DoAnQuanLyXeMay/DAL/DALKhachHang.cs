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
    }
}
