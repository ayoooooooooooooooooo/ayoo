using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALCTHDXUAT
    {
        QLXeMayDataContext qlxm = new QLXeMayDataContext();
        public DALCTHDXUAT() { }
        public List<CHITIETHDXUAT> lsthdx()
        {
            return qlxm.CHITIETHDXUATs.Select(t => t).ToList();

        }
       
    }
}
