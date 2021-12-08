using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "ProductName","SKU","Inventory","Import Date" };
        }
        [HttpGet("{id}")]

        public ActionResult<string> Get(int id)
        {
            return "id =" + id;
        }
        [HttpPost]
        public void Post([FromBody] string Product) {}

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Product) { }
        [HttpDelete("{id}")]
        public void Delete(int id) { }
        
    }
}
