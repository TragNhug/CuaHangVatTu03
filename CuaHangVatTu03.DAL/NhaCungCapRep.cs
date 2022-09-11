using CuaHangVatTu03.Common.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuaHangVatTu03.DAL
{
    
        public class NhaCungCapRep : GenericRep<QLVTContext, Nhacungcap>
        {
            public NhaCungCapRep()
            {

            }
            public int XoaNhaCungCap(int id)
            {
                var m = base.All.First(i => i.Manhacc == id);
                Context.Nhacungcaps.Remove(m);
                Context.SaveChanges();
                return m.Manhacc;
            }
        }
    }

