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
        public List<KHACHHANG> dskhachhang()
        {
            return dalkh.dsKhachHang();
        }
        public bool themkh(KHACHHANG kh)
        {
            return dalkh.themkh(kh);
        }
        public bool xoakh(string makh)
        {
            return dalkh.xoakh(makh);
        }
        public bool suakh(KHACHHANG kh)
        {
            return dalkh.suakh(kh);
        }
    }
}
