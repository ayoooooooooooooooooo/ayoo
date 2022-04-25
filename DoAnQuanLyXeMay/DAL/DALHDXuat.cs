using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHDXuat
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALHDXuat() { }

        public List<HOADONXUAT> dsHDXuat()
        {
            return qL.HOADONXUATs.Select(t => t).ToList();

        }
    }
}
