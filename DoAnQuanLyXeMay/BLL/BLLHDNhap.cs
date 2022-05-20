using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLHDNhap
    {
        DALHDNhap qlHDXuat = new DALHDNhap();
        public BLLHDNhap() { }
        public List<HOADONNHAP> dsHDNhap()
        {
            return qlHDXuat.dsHDNhap();
        }
    }
}
