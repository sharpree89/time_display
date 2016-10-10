using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Time_Display.Controllers
{
 public class HelloController : Controller                  
 {
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        DateTime CurrentTime = DateTime.Now;  
        @ViewBag.CurrentTime = CurrentTime;

        return View("index");
    }
    // [HttpPost]
    // [Route("")]
    // public IActionResult Other()
    // {
    //     return View();
    // }
 }
}