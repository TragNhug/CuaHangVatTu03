using CuaHangVatTu03.BLL;
using CuaHangVatTu03.Common.Req;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangVatTu03.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TonKhoController : ControllerBase
    {
        private TonKhoSvc tonKhoSvc;
        public TonKhoController()
        {
            tonKhoSvc = new TonKhoSvc();

        }
        [HttpDelete("xoa-ton-kho")]
        public IActionResult XoaTonKho([FromBody] SimpleReq req)
        {
            var res = tonKhoSvc.XoaTonKho(req.Id);
            return Ok(res);
        }
    }
}
