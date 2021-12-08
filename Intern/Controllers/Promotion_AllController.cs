using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Promotion_AllController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Campaign", "Type", "Start date", "End date","Status" };
        }
        [HttpGet("{thêm}")]

        public ActionResult<string> Get(int id)
        {
            return "id =" + id;
        }
        [HttpPost]
        public void Post([FromBody] string Promotion_All) { }

        [HttpPut("{Sửa}")]
        public void Put(int id, [FromBody] string Promotion_All) { }
        [HttpDelete("{Xóa}")]
        public void Delete(int id) { }
    }
}
