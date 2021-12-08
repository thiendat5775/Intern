using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Promotion_StoreController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Store name", "Address", "Country", "In capaign" };
        }

        [HttpGet("{thêm}")]

        public ActionResult<string> Get(int id)
        {
            return "id =" + id;
        }
        [HttpPost]
        public void Post([FromBody] string Promotion_Store) { }

        [HttpPut("{Sửa}")]
        public void Put(int id, [FromBody] string Promotion_Store) { }
        [HttpDelete("{Xóa}")]
        public void Delete(int id) { }

    }
}
