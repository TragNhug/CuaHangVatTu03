using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class CtPhieuNhapSvc : GenericSvc<CtPhieuNhapRep, Ctphieunhap>
    {
        private CtPhieuNhapRep ctPhieuNhapRep;
        public CtPhieuNhapSvc()
        {
            ctPhieuNhapRep = new CtPhieuNhapRep();
        }
        public SingleRsp XoaCtPhieuNhap(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaCtPhieuNhap(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
