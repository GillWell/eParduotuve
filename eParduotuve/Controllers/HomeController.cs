using eParduotuve.Data;
using eParduotuve.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace eParduotuve.Controllers
{
	public class HomeController : Controller
	{
		private NetDBContext _application;

		private readonly ILogger<HomeController> _logger;

		public HomeController(NetDBContext application, ILogger<HomeController> logger)
		{
			_application = application;
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