using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Polynomtech.Models;
using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomtechEntities;

namespace Polynomtech.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParfumeBusiness ParfumeBusiness;
        public HomeController(IParfumeBusiness ParfumeBusiness)
        {
            this.ParfumeBusiness = ParfumeBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Basket(Parfume parfume)
        {

            ParfumeBusiness.ParfumeAdd(parfume);
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
