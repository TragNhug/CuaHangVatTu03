using CuaHangVatTu03.BLL;
using CuaHangVatTu03.Common.Req;
using CuaHangVatTu03.Common.Rsp;
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
    public class VattuController : ControllerBase
    {
        private VattuSvc vattuSvc;
        public VattuController()
        {
            vattuSvc = new VattuSvc();

        }
        [HttpPost("get-by-id")]
        public IActionResult GetVattuByID([FromBody] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res = vattuSvc.Read(simpleReq.Id);

            return Ok(res);
        }

        [HttpDelete("xoa-vattu")]
        public IActionResult XoaVattu([FromBody] SimpleReq req)
        {
            var res = vattuSvc.XoaVattu(req.Id);
            return Ok(res);
        }
    }
}
