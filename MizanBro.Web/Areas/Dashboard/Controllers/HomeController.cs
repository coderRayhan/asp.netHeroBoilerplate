using MizanBro.Web.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace MizanBro.Web.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : BaseController<HomeController>
    {
        public IActionResult Index()
        {
            _notify.Information("Hi There!");
            return View();
        }
    }
}