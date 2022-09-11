using CuaHangVatTu03.BLL;
using CuaHangVatTu03.Common.Req;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangVatTu03.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonDHController : ControllerBase
    {
        private DonDHSvc donDHSvc;
        public DonDHController()
        {
            donDHSvc = new DonDHSvc();

        }
        [HttpDelete("xoa-don-dh")]
        public IActionResult XoaDonDH([FromBody] SimpleReq req)
        {
            var res = donDHSvc.XoaDH(req.Id);
            return Ok(res);
        }
    }
}

