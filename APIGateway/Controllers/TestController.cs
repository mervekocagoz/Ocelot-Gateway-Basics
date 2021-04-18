using Microsoft.AspNetCore.Mvc;
using System;

namespace APIGateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "App is Working";
        }
    }
}