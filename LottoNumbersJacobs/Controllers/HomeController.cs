using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LottoNumbersJacobs.Models;


namespace LottoNumbersJacobs.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {



            ViewBag.LottoNumOne = 0; 
            ViewBag.LottoNumTwo = 0; 
            ViewBag.LottoNumThree = 0; 
            ViewBag.LottoNumFour = 0; 
            ViewBag.NumbersMatching = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LottoNumberModel model)
        {
            if (ModelState.IsValid) 
            { 
                ViewBag.NumbersMatching = model.CalculateNumbersMatching(); 
            }
            else 
            {
                ViewBag.NumbersMatching = 0;
            }
            
            return View(model);
        }
    }
}