using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZORI_KIDS_KG.Model;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class CopilController : Controller
    {
        private zori_kids_dbContext _db;

        public CopilController(zori_kids_dbContext context)
        {
            _db = context;
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            var result = _db.Copil.ToList();
            return View(result);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            ViewBag.ParinteId = new SelectList(_db.Parinte, "Id", "Nume");
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult CreateCopil(Copil copil)
        {
            _db.Copil.Add(copil);
            _db.SaveChanges();

            ParinteCopil obj = new ParinteCopil();

            obj.ParinteId = copil.ParinteId;
            obj.CopilId = copil.Id;

            _db.ParinteCopil.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index", "Copil");
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {              
                
                Copil copil = _db.Copil.Where(s => s.Id == id).FirstOrDefault();

                ParinteCopil pac2 = _db.ParinteCopil.Where(s => s.Copil == copil).FirstOrDefault();
                _db.ParinteCopil.Remove(pac2);
                _db.SaveChanges();

                _db.Copil.Remove(copil);
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
            ViewBag.ParinteId = new SelectList(_db.Parinte, "Id", "Nume");
            return View(_db.Copil.Where(s => s.Id == id).FirstOrDefault());
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult UpdateCopil(Copil copil)
        {
            Copil c = _db.Copil.Where(s => s.Id == copil.Id).FirstOrDefault();
            c.Nume = copil.Nume;
            c.Prenume = copil.Prenume;
            c.Cnp = copil.Cnp;
            c.Varsta = copil.Varsta;
            c.Sex = copil.Sex;
            c.Vorbeste = copil.Vorbeste;
            c.ParinteId = copil.ParinteId;
            _db.SaveChanges();
            return RedirectToAction("Index", "Copil");
        }
    }
}