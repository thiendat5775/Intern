using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Redemtioncode", "Phone no", "Day of Redemption", "Gift", "Status","Store" };
        }
        [HttpGet("{id}")]

        public ActionResult<string> Get(int id)
        {
            return "id =" + id;
        }
        [HttpPost]
        public void Post([FromBody] string Customer) { }

    }
}
