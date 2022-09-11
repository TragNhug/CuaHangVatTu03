using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class PhieuNhapSvc : GenericSvc<PhieuNhapRep, Phieunhap>
    {
        private PhieuNhapRep phieuNhapRep;
        public PhieuNhapSvc()
        {
            phieuNhapRep = new PhieuNhapRep();
        }
        public SingleRsp XoaPhieuNhap(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaPhieuNhap(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
