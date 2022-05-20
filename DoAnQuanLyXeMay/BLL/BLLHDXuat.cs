using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLHDXuat
    {
        DALHDXuat daHDXuat = new DALHDXuat();
        public BLLHDXuat() { }
        public List<HOADONXUAT> dsHDXuat()
        {
            return daHDXuat.dsHDXuat();
        }
    }
}
