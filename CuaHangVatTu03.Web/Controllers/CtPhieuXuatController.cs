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
    public class CtPhieuXuatController : ControllerBase
    {
        private CtPhieuXuatSvc ctPhieuXuatSvc;
        public CtPhieuXuatController()
        {
            ctPhieuXuatSvc = new CtPhieuXuatSvc();

        }
        [HttpDelete("xoa-ct-phieu-xuat")]
        public IActionResult XoaCtPhieuXuat([FromBody] SimpleReq req)
        {
            var res = ctPhieuXuatSvc.XoaCtPhieuXuat(req.Id);
            return Ok(res);
        }
    }
}
