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
    public class PhieuXuatController : ControllerBase
    {
        private PhieuXuatSvc phieuXuatSvc;
        public PhieuXuatController()
        {
            phieuXuatSvc = new PhieuXuatSvc();

        }
        [HttpDelete("xoa-phieu-xuat")]
        public IActionResult XoaPhieuXuat([FromBody] SimpleReq req)
        {
            var res = phieuXuatSvc.XoaPhieuXuat(req.Id);
            return Ok(res);
        }
    }
    }
