using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppUserService _appUserService;
        public HomeController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
