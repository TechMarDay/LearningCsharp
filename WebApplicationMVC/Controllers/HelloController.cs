using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HelloController : Controller
    {
        //pattern: "{controller=Home}/{action=Index}/{id?}");

        //Hello/index
        //Hello
        public IActionResult Index()
        {
            //ViewData: Send data from controller to view
            //ViewData: Dictionary (key/value)

            //object, string, int, double... dynamic

            ViewData["Message"] = "Hello Long";
            ViewData["Numbers"] = 10;

            //return "This is my default action...";
            return View();
        }

        //Hello/welcome?name=..
        public string Welcome(string name)
        {
            return $"Hello {name} !";
        }
    }
}
