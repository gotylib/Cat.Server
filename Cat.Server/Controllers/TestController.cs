using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cat.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("TestServer")]
        public ActionResult TestServer()
        {
            return Ok("Всё хорошо");
        }

    }
}
