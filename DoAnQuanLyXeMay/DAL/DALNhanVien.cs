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

        public List<NHANVIEN> dsNhanVien()
        {
            return qL.NHANVIENs.Select(t=>t).ToList();

        }
    }
}
