using CuaHangVatTu03.Common.BLL;
using CuaHangVatTu03.Common.Rsp;
using CuaHangVatTu03.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu03.BLL
{
    
    public class DonDHSvc : GenericSvc<DonDHRep, Dondh>
    {
        private DonDHRep donDHRep;
        public DonDHSvc()
        {
            donDHRep = new DonDHRep();
        }
        public SingleRsp XoaDH(int id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.XoaDonHang(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
