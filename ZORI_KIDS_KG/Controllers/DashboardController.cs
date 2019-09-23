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
    public class DashboardController : Controller
    {
        private zori_kids_dbContext data;
        

        public DashboardController(zori_kids_dbContext context)
        {
            data = context;           
        }
        
        DashboardViewModel dashboard = new DashboardViewModel();

        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            dashboard.asociatie_count = data.Asociatie.Count();
            dashboard.parinte_count = data.Parinte.Count();
            dashboard.copil_count = data.Copil.Count();
            dashboard.admin_count = data.Admins.Count();

            //dashboard.Asociatie = data.Asociatie.ToList();
            //dashboard.Parinte = data.Parinte.ToList();
            //dashboard.Copil = data.Copil.ToList();
            
            return View(dashboard);
        }        
    }
}