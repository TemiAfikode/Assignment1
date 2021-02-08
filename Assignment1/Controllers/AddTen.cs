using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTenController : ControllerBase
    {
        [HttpGet("{id}")]
        public Int32 Get(Int32 id)
        {
            return id + 10;
        }
    }
}
