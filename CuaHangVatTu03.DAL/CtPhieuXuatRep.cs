using CuaHangVatTu03.Common.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuaHangVatTu03.DAL
{
   
    public class CtPhieuXuatRep : GenericRep<QLVTContext, Ctphieuxuat>
    {
        public CtPhieuXuatRep()
        {

        }
        public int XoaCtPhieuXuat(int id)
        {
            var m = base.All.First(i => i.Sopx == id);
            Context.Ctphieuxuats.Remove(m);
            Context.SaveChanges();
            return m.Sopx;
        }
    }
}
