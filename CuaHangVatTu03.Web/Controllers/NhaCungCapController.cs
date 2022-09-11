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
    public class NhaCungCapController : ControllerBase
    {
        private NhaCungCapSvc nhaCungCapSvc;
        public NhaCungCapController()
        {
            nhaCungCapSvc = new NhaCungCapSvc();

        }
        [HttpDelete("xoa-nha-cung-cap")]
        public IActionResult XoaNhaCungCap([FromBody] SimpleReq req)
        {
            var res = nhaCungCapSvc.XoaNhaCungCap(req.Id);
            return Ok(res);
        }
    }
}
