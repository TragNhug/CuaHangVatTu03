using CuaHangVatTu03.Common.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using CuaHangVatTu03.DAL.Models;
using System.Linq;

namespace CuaHangVatTu03.DAL
{
    public class VattuRep:GenericRep<QLVTContext, Vattu>
    {
        public VattuRep()
        {

        }
        #region -- Overrides --
        public override Vattu Read(int id)
        {
            var res = All.FirstOrDefault(v => v.Mavtu == id);
            return res;
        }
        
        public int Remove(int id)
        {
            var m = base.All.First(i => i.Mavtu == id);
            m = base.Delete(m);
            return m.Mavtu;
        }

        #endregion
        public int XoaVattu(int id)
        {
            var m = base.All.First(i => i.Mavtu == id);
            Context.Vattus.Remove(m);
            Context.SaveChanges();
            return m.Mavtu;
        }
    }
}
