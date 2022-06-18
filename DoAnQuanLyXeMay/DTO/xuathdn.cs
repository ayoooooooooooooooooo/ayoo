using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class xuathdn
    {
        string ngaylap, manv;
        List<CHITIETHDNHAP> lstct;
        public xuathdn(string ngaylap,string manv,List<CHITIETHDNHAP> lstct)
        {
            this.ngaylap = ngaylap;
            this.manv = manv;
            this.lstct = lstct;
        }
        public xuathdn()
        {
   
        }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Manv { get => manv; set => manv = value; }
        public List<CHITIETHDNHAP> Lstct { get => lstct; set => lstct = value; }
    }
}
