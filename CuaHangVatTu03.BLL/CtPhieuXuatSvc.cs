using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class CtPhieuXuatSvc : GenericSvc<CtPhieuXuatRep, Ctphieuxuat>
    {
        private CtPhieuXuatRep ctPhieuXuatRep;
        public CtPhieuXuatSvc()
        {
            ctPhieuXuatRep = new CtPhieuXuatRep();
        }
        public SingleRsp XoaCtPhieuXuat(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaCtPhieuXuat(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
