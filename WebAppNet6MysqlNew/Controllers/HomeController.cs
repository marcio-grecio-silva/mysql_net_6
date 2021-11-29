using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppNet6MysqlNew.Models;

namespace WebAppNet6MysqlNew.Controllers
{
    public class HomeController : Controller
    {
        public readonly Conexao _Db = new Conexao();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var result = _Db.ServiceStats.ToList();
            return View(result);
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