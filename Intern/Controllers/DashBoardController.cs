using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : Controller
    {
       [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "PhoneNumber","Redeem for Product","Amount","Date","Store","Status" };
        }
        //get api/values/S
        [HttpGet("{id}")]

        public ActionResult<string>Get(int id)
        {
            return "id =" + id;
        }
        [HttpPost]
        public void Post([FromBody] string DashBoard) { }
    }
}
