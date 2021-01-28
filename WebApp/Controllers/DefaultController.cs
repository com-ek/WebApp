using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    //[Route("api/[controller]")]

    [Route("api/[action]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public IActionResult GetCourseName()
        {
            return Ok("ASCS404");
        }
    }
}
