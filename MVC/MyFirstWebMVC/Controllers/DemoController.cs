namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

namespace DemoMVCWeb.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            string name = "Nguyen Thi Bach Duong";
            string msv = "2121050053";

            ViewBag.Message = $"Hello {name} - {msv}";
            return View();
        }
    }
}
}