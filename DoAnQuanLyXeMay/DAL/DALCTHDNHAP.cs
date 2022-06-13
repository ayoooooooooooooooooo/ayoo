using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALCTHDNHAP
    {
        QLXeMayDataContext qlxm=new QLXeMayDataContext();
         public DALCTHDNHAP() { }
        public List<CHITIETHDNHAP> lsthdn()
        {
            return qlxm.CHITIETHDNHAPs.Select(t=>t).ToList();
        }
    }
}
