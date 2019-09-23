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
    public class ParinteController : Controller
    {
        private zori_kids_dbContext _db;

        public ParinteController(zori_kids_dbContext context)
        {
            _db = context;
        }        

        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            var result = _db.Parinte.ToList();
            return View(result);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {            
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult CreateParinte(Parinte parinte)
        {
            _db.Parinte.Add(parinte);
            _db.SaveChanges();
            return RedirectToAction("Index", "Parinte");
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Parinte parinte = _db.Parinte.Where(s => s.Id == id).FirstOrDefault();

                _db.Parinte.Remove(parinte);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Update(int id)
        {
            return View(_db.Parinte.Where(s => s.Id == id).FirstOrDefault());
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult UpdateParinte(Parinte parinte)
        {
            Parinte p = _db.Parinte.Where(s => s.Id == parinte.Id).FirstOrDefault();
            p.Email = parinte.Email;
            p.Password = parinte.Password;
            p.Cnp = parinte.Cnp;
            p.Nume = parinte.Nume;
            p.Prenume = parinte.Prenume;
            p.Varsta = parinte.Varsta;
            p.Sex = parinte.Sex;
            p.Telefon = parinte.Telefon;
            p.Localitate = parinte.Localitate;
            p.Judet = parinte.Judet;
            p.Adresa = parinte.Adresa;
            p.RolesId = parinte.RolesId;
            _db.SaveChanges();
            return RedirectToAction("Index", "Parinte");
        }
    }
}