using CuaHangVatTu03.Common.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuaHangVatTu03.DAL
{
    public class TonKhoRep : GenericRep<QLVTContext, Tonkho>
    {
        public TonKhoRep()
        {
            
        }
        public int XoaTonKho(int id)
        {
            var m = base.All.First(i => i.Maso == id);
            Context.Tonkhos.Remove(m);
            Context.SaveChanges();
            return m.Maso;
        }
    }
}
