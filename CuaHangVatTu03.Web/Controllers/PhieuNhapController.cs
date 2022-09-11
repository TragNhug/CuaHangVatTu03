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
    public class PhieuNhapController : ControllerBase
    {
        private PhieuNhapSvc phieuNhapSvc;
        public PhieuNhapController()
        {
            phieuNhapSvc = new PhieuNhapSvc();

        }
        [HttpDelete("xoa-phieu-nhap")]
        public IActionResult XoaPhieuNhap([FromBody] SimpleReq req)
        {
            var res = phieuNhapSvc.XoaPhieuNhap(req.Id);
            return Ok(res);
        }
    }
}
