using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLNCC
    {
        DALNCC dalncc = new DALNCC();
        public BLLNCC() { }
        public List<NHACUNGCAP> dsNhanVien()
        {
            return dalncc.dsNCC();
        }


    }
}
