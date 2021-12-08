using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Promotion_CollectionController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Collection name", "Campaign", "Total of product", "Inventory" };
        }
        [HttpPost]
        public void Post([FromBody] string Promotion_Collection) { }

        [HttpPut("{Sửa}")]
        public void Put(int id, [FromBody] string Promotion_Collection) { }
    }
}
