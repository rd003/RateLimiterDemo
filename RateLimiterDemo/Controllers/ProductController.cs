using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace RateLimiterDemo.Controllers
{
    [EnableRateLimiting("fixed")]
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("data fetched");
        }

        [HttpGet("/api/products/test")]
        public IActionResult test()
        {
            return Ok("test....");
        }
    }
}
