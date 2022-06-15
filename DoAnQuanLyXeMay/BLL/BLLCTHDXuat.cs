﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLCTHDXuat
    {
        public BLLCTHDXuat() { }
        DALCTHDXUAT dalctxuat= new DALCTHDXUAT();
        public List<CHITIETHDXUAT> lstcthdxuat()
        { return dalctxuat.lsthdx(); }
        public List<CHITIETHDXUAT> lstcthdxuat(string mahd)
        {

            List<CHITIETHDXUAT> lstxuattheoma = new List<CHITIETHDXUAT>();

            foreach (CHITIETHDXUAT a in lstcthdxuat())
            {
                if (a.MAHD.Equals(mahd))
                    lstxuattheoma.Add(a);
            }
            return lstxuattheoma;
        }
        public bool xoahdn(string mahd)
        {
            return dalctxuat.xoacthdx(mahd);

        }
        public bool suahdn(CHITIETHDXUAT hdx)
        {
            return dalctxuat.suacthdx(hdx);

        }
        public bool themhdn(CHITIETHDXUAT hdx)
        {
            return dalctxuat.themcthdx(hdx);

        }

    }
}
