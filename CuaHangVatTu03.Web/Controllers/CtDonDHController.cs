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
    public class CtDonDHController : ControllerBase
    {
        private CtDonDHSvc ctDonDHSvc;
        public CtDonDHController()
        {
            ctDonDHSvc = new CtDonDHSvc();

        }
        [HttpDelete("xoa-ct-don-dh")]
        public IActionResult XoaCtDonDH([FromBody] SimpleReq req)
        {
            var res = ctDonDHSvc.XoaCtDonDH(req.Id);
            return Ok(res);
        }
    }
}
