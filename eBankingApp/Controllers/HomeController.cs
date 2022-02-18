using eBankingApp.Models;
using eBankingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace eBankingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoanService _loanService;

        public HomeController(ILogger<HomeController> logger, ILoanService loanService)
        {
            _logger = logger;
            _loanService = loanService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult loanValue([FromQuery]LoanDetails loanDetails)
        {
            loanDetails.firstName = loanDetails.firstName ?? "";
            loanDetails.lastName = loanDetails.lastName ?? "";
            loanDetails.email = loanDetails.email ?? "";
            loanDetails.loanType = loanDetails.loanType ?? "";
            loanDetails.loanDuration = loanDetails.loanDuration;

            var loanValue = _loanService.GetLoanStringValue(loanDetails);
            ViewData["Success"] = _loanService.GetLoanHashCode(loanDetails);
            return View("Success");
        }

        [HttpPost]
        public IActionResult loan(LoanDetails loanDetails)
        {
            var loanValue = _loanService.GetLoanStringValue(loanDetails);
            TempData["success"] = _loanService.GetLoanHashCode(loanDetails);  
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            var success = Convert.ToInt32(TempData["success"]);
            ViewData["Success"] = success;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}