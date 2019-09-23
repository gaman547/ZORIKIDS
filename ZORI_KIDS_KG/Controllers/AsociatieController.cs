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
    public class AsociatieController : Controller
    {
        private zori_kids_dbContext _db;

        public AsociatieController(zori_kids_dbContext context)
        {
            _db = context;
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            var result = _db.Asociatie.ToList();
            return View(result);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            ViewBag.ParinteId = new SelectList(_db.Parinte, "Id", "Nume");
            ViewBag.CopilId = new SelectList(_db.Copil, "Id", "Nume");
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult CreateAsociatie(Asociatie asoc)
        {
            _db.Asociatie.Add(asoc);
            _db.SaveChanges();

            AsocCopil obj = new AsocCopil();

            obj.AsocId = asoc.Id;
            obj.CopilId = asoc.CopilId;

            _db.AsocCopil.Add(obj);
            _db.SaveChanges();

            AsocParinte obj2 = new AsocParinte();

            obj2.AsociatieId = asoc.Id;
            obj2.ParinteId = asoc.ParinteId;

            _db.AsocParinte.Add(obj2);
            _db.SaveChanges();

            return RedirectToAction("Index", "Asociatie");
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Asociatie asoc = _db.Asociatie.Where(s => s.Id == id).FirstOrDefault();
                AsocCopil asc = _db.AsocCopil.Where(s => s.Asoc == asoc).FirstOrDefault();
                AsocParinte asc2 = _db.AsocParinte.Where(s => s.Asociatie == asoc).FirstOrDefault();

                _db.AsocCopil.Remove(asc);
                _db.SaveChanges();
                
                _db.AsocParinte.Remove(asc2);
                _db.SaveChanges();
                                             
                _db.Asociatie.Remove(asoc);
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
            ViewBag.CopilId = new SelectList(_db.Copil, "Id", "Nume");
            return View(_db.Asociatie.Where(s => s.Id == id).FirstOrDefault());
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult UpdateAsociatie(Asociatie asoc)
        {
            Asociatie a = _db.Asociatie.Where(s => s.Id == asoc.Id).FirstOrDefault();
            a.Denumire = asoc.Denumire;
            a.CodFiscal = asoc.CodFiscal;
            a.NrRegCom = asoc.NrRegCom;
            a.DataInfintare = asoc.DataInfintare;
            a.Iban = asoc.Iban;
            a.Localitate = asoc.Localitate;
            a.Judet = asoc.Judet;
            a.Adresa = asoc.Adresa;
            a.CopilId = asoc.CopilId;
            a.ParinteId = asoc.ParinteId;
            _db.SaveChanges();
            return RedirectToAction("Index", "Asociatie");
        }
    }
}