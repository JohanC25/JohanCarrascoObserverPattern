using JohanCarrascoObserverPattern.Departamentos;
using JohanCarrascoObserverPattern.Models;
using JohanCarrascoObserverPattern.Subject;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JohanCarrascoObserverPattern.Controllers
{
	public class HomeController : Controller
	{
		private readonly IAsset _it;
		private readonly IFinanzas _finance;
		private readonly IResignation _resignation;

		public HomeController(IAsset it, IFinanzas finance,
			IResignation resignation)
		{
			_it = it;
			_finance = finance;
			_resignation = resignation;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ITDept()
		{
			_it.AllocateAsset();

			ViewBag.Dept = "IT - Allocated assets";
			return View("Index");
		}

		[HttpPost]
		public IActionResult Finance()
		{
			_finance.CalcularSalario();

			ViewBag.Dept = "Finance - Calculated salary";
			return View("Index");
		}

		[HttpPost]
		public void EmployeeSeparate(string EmployeeId)
		{

			_resignation.NotifyObserver(EmployeeId);
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