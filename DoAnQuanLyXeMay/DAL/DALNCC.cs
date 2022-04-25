using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNCC
    {
        QLXeMayDataContext qL = new QLXeMayDataContext();
        public DALNCC() { }

        public List<NHACUNGCAP> dsNCC()
        {
            return qL.NHACUNGCAPs.Select(t => t).ToList();

        }
    }
}
