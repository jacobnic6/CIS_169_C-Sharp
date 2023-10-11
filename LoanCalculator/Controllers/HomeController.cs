using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoanCalculator.Models;

namespace LoanCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.LoanAmount = 0;
            ViewBag.InterestRate = 0;
            ViewBag.YearLoan = 0;
            ViewBag.MortgagePayment = 0;
            ViewBag.TotalCost = 0;
            ViewBag.InterestPaid = 0;

            return View();
        }
        [HttpPost]
        public IActionResult Index(LoanCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MortgagePayment = model.CalculatePayment();
                ViewBag.TotalCost = model.CalculateTotalCost();
                ViewBag.InterestPaid = model.CalculateInterestPaid();
            }
            else
            {
                ViewBag.MortgagePayment = 0;
                ViewBag.TotalCost = 0;
                ViewBag.InterestPaid = 0;
            }
            
            return View(model);
        }
    }
}