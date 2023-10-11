using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;


namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.EndingBalance = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(BankAccount.Models.BankAccount model)
        {
            model.Withdraw();
            ViewBag.EndingBalance = model.Balance;
            return View(model);
        }
    }

    /*public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.AccountNumber = 1234;
            ViewBag.Balance = 100.0;
            return View();
        }
    }*/
}