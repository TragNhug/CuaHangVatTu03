using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    public class VattuSvc:GenericSvc<VattuRep, Vattu>
    {
        private VattuRep vattuRep;
        public VattuSvc()
        {
            vattuRep = new VattuRep();
        }

        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }
        
        public SingleRsp XoaVattu(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaVattu(id);
            }catch(Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
