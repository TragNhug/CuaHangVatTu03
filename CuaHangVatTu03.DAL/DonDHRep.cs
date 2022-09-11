using CuaHangVatTu03.Common.DAL;
using CuaHangVatTu03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuaHangVatTu03.DAL
{
   
        public class DonDHRep : GenericRep<QLVTContext, Dondh>
        {
            public DonDHRep()
            {

            }
            public int XoaDonHang(int id)
            {
                var m = base.All.First(i => i.Sodh == id);
                Context.Dondhs.Remove(m);
                Context.SaveChanges();
                return m.Sodh;
            }
        }
    }

