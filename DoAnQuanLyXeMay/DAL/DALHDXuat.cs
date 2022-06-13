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
        DALCTHDNHAP dalcthdnhap= new DALCTHDNHAP();
        DALCTHDXUAT dalcthdxuat= new DALCTHDXUAT();
       
        public List<HOADONXUAT> dsHDXuat()
        {
            return qL.HOADONXUATs.Select(t => t).ToList();

        }
        public List<HOADONXUAT> dsHDXuattheongay(string ngay)
        {
            return qL.HOADONXUATs.Select(t => t).Where(t=>t.NGAYBAN.ToString().Equals(ngay)).ToList();
        }
    }
}
