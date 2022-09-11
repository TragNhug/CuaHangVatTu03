using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    public class TonKhoSvc:GenericSvc<TonKhoRep, Tonkho>
    {
        private TonKhoRep tonKhoRep;
        public TonKhoSvc()
        {
            tonKhoRep = new TonKhoRep();
        }
        public SingleRsp XoaTonKho(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaTonKho(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
