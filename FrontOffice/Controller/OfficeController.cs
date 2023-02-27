using FrontOffice.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontOffice.NewFolder
{
    public class OfficeController : Controller
    {
        private readonly ILogger<OfficeController> _logger;

        public OfficeController(ILogger<OfficeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
