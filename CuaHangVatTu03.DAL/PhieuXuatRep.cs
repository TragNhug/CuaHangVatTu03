using CuaHangVatTu03.Common.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuaHangVatTu03.DAL
{

    public class PhieuXuatRep : GenericRep<QLVTContext, Phieuxuat>
    {
        public PhieuXuatRep()
        {

        }
        public int XoaPhieuXuat(int id)
        {
            var m = base.All.First(i => i.Sopx == id);
            Context.Phieuxuats.Remove(m);
            Context.SaveChanges();
            return m.Sopx;
        }
    }
}

