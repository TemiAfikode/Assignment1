using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        [HttpPost]
        public String Post ()
        {
            return "Hello World!";
        }

        [HttpGet("{id}")]
        public String Get(Int32 id)
        {
            return String.Format("Greetings to {0} people!", id);
        }
    }
}
