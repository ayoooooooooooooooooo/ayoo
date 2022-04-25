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
        BLLHDNhap qlHDXuat = new BLLHDNhap();
        public BLLHDNhap() { }
        public List<BLLHDNhap> dsNhanVien()
        {
            return qlHDXuat.dsNhanVien();
        }
    }
}
