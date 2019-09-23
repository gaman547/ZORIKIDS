using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZORI_KIDS_KG.Model;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class HomeController : Controller
    {        
        private zori_kids_dbContext _db;

        public HomeController(zori_kids_dbContext context)
        {
            _db = context;            
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Despre()
        {
            return View();
        }

        public IActionResult AboutME()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Maps()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}