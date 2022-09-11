using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class CtDonDHSvc : GenericSvc<CtDonDHRep, Ctdondh>
    {
        private CtDonDHRep ctDonDHRep;
        public CtDonDHSvc()
        {
            ctDonDHRep = new CtDonDHRep();
        }
        public SingleRsp XoaCtDonDH(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaCtDonDH(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
