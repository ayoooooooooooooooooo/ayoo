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
        public List<NHANVIEN> dsNhanVien()
        {
            return dalnv.dsNhanVien();
        }

    }
}
