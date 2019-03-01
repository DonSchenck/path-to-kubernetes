using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<String> Get()
        {
            return "Hello World!";
        }
    }
}
