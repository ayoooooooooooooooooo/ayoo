using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHDNhap
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALHDNhap() { }

        public List<HOADONNHAP> dsHDNhap()
        {
            return qL.HOADONNHAPs.Select(t => t).ToList();

        }
    }
}
