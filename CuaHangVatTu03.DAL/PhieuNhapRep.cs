using CuaHangVatTu03.Common.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuaHangVatTu03.DAL
{
   
        public class PhieuNhapRep : GenericRep<QLVTContext, Phieunhap>
        {
            public PhieuNhapRep()
            {

            }
            public int XoaPhieuNhap(int id)
            {
                var m = base.All.First(i => i.Sopn == id);
                Context.Phieunhaps.Remove(m);
                Context.SaveChanges();
                return m.Sopn;
            }
        }
    }

