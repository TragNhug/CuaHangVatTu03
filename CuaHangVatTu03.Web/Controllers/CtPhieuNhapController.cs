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
    public class CtPhieuNhapController : ControllerBase
    {
        private CtPhieuNhapSvc ctPhieuNhapSvc;
        public CtPhieuNhapController()
        {
            ctPhieuNhapSvc = new CtPhieuNhapSvc();

        }
        [HttpDelete("xoa-ct-phieu-nhap")]
        public IActionResult XoaCtPhieuNhap([FromBody] SimpleReq req)
        {
            var res = ctPhieuNhapSvc.XoaCtPhieuNhap(req.Id);
            return Ok(res);
        }
    }
}
