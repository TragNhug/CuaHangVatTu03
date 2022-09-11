using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class PhieuXuatSvc : GenericSvc<PhieuXuatRep, Phieuxuat>
    {
        private PhieuXuatRep phieuXuatRep;
        public PhieuXuatSvc()
        {
            phieuXuatRep = new PhieuXuatRep();
        }
        public SingleRsp XoaPhieuXuat(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaPhieuXuat(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
