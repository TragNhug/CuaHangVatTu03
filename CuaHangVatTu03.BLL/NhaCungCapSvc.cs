using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class NhaCungCapSvc : GenericSvc<NhaCungCapRep, Nhacungcap>
    {
        private NhaCungCapRep nhaCungCapRep;
        public NhaCungCapSvc()
        {
            nhaCungCapRep = new NhaCungCapRep();
        }
        public SingleRsp XoaNhaCungCap(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaNhaCungCap(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
