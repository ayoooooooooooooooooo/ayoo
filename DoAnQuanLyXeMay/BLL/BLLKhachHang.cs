using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLKhachHang
    {

        DALKhachHang dalkh = new DALKhachHang();
        public BLLKhachHang() { }
        public List<KHACHHANG> dsNhanVien()
        {
            return dalkh.dsKhachHang();
        }
    }
}
