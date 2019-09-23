using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZORI_KIDS_KG.Model;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class UserController : Controller
    {
        private zori_kids_dbContext _db;

        public UserController (zori_kids_dbContext context)
        {
            _db = context;
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public IActionResult UploadPicture(List<IFormFile> pictures)
        {
            string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploaded\\user\\avatars");
            SaveFile(pictures, uploadPath);
            return RedirectToAction("Index","User");
        }

        [Authorize(Roles = "Utilizator")]
        [HttpGet]
        public ActionResult UploadPicture()
        {
            return View();
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public IActionResult UploadPictureCopil(List<IFormFile> pictures)
        {
            string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploaded\\user\\avatars\\copii");
            SaveFile(pictures, uploadPath);
            return RedirectToAction("Copil", "User");
        }
                
        private static void SaveFile(List<IFormFile> pictures, string uploadPath)
        {
            foreach (IFormFile picture in pictures)
            {
                string randomPart = Guid.NewGuid().ToString();
                string filename = randomPart + Path.GetExtension(picture.FileName);

                using (FileStream newFile = System.IO.File.OpenWrite(Path.Combine(uploadPath, filename)))
                {
                    picture.CopyTo(newFile);
                    newFile.Flush();                    
                }
            }
        }

        [Authorize(Roles = "Utilizator")]
        [HttpGet]
        public ActionResult UploadPictureCopil()
        {
            return View();
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public IActionResult UploadPictureAsociatie(List<IFormFile> pictures)
        {
            string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploaded\\user\\avatars\\asociatii");
            SaveFile(pictures, uploadPath);
            return RedirectToAction("Asociatie", "User");
        }

        [Authorize(Roles = "Utilizator")]
        [HttpGet]
        public ActionResult UploadPictureAsociatie()
        {
            return View();
        }

        [Authorize(Roles = "Utilizator")]
        public IActionResult Index()
        {
            var userid = User.Identity.Name;
            var result = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
            return View(result);
        }

        [Authorize(Roles = "Utilizator")]
        public ActionResult Copil()
        {
            try
            {
                var userid = User.Identity.Name;
                var parinte = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
                var copil = _db.ParinteCopil.Where(s => s.ParinteId == parinte.Id).FirstOrDefault();
                var result = _db.Copil.Where(s => s.Id == copil.CopilId).FirstOrDefault();

                return View(result);
            }
            catch(InvalidOperationException)
            {                
                return RedirectToAction("Index", "User");
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("Index", "User");
            }

        }

        [Authorize(Roles = "Utilizator")]
        public ActionResult Asociatie()
        {
            try
            {
                var userid = User.Identity.Name;
                var parinte = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
                var asoc = _db.AsocParinte.Where(s => s.ParinteId == parinte.Id).FirstOrDefault();
                var result = _db.Asociatie.Where(s => s.Id == asoc.AsociatieId).FirstOrDefault();
                return View(result);
            }
            catch(InvalidOperationException)
            {
                return RedirectToAction("Index", "User");
            }
            catch(NullReferenceException)
            {
                return RedirectToAction("Index", "User");
            }
        }

        [Authorize(Roles = "Utilizator")]
        public ActionResult Edit()
        {
            var userid = User.Identity.Name;
            var result2 = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();          
            return View(result2);            
        }

        [Authorize(Roles = "Utilizator")]
        public ActionResult EditCopil()
        {
            var userid = User.Identity.Name;
            var parinte = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
            var copil = _db.ParinteCopil.Where(s => s.ParinteId == parinte.Id).FirstOrDefault();
            var result = _db.Copil.Where(s => s.Id == copil.CopilId).FirstOrDefault();
            return View(result);
        }

        [Authorize(Roles = "Utilizator")]
        public ActionResult EditAsociatie()
        {
            var userid = User.Identity.Name;
            var parinte = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
            var asoc = _db.AsocParinte.Where(s => s.ParinteId == parinte.Id).FirstOrDefault();
            var result = _db.Asociatie.Where(s => s.Id == asoc.AsociatieId).FirstOrDefault();
            return View(result);
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public ActionResult ProfileEdit(Parinte parinte)
        {
            Parinte p = _db.Parinte.Where(s => s.Id == parinte.Id).FirstOrDefault();           
            p.Cnp = parinte.Cnp;
            p.Nume = parinte.Nume;
            p.Prenume = parinte.Prenume;
            p.Varsta = parinte.Varsta;
            p.Sex = parinte.Sex;
            p.Telefon = parinte.Telefon;
            p.Localitate = parinte.Localitate;
            p.Judet = parinte.Judet;
            p.Adresa = parinte.Adresa;            
            _db.SaveChanges();
            return RedirectToAction("Index", "User");
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public ActionResult ProfileEditCopil(Copil copil)
        {
            Copil p = _db.Copil.Where(s => s.Id == copil.Id).FirstOrDefault();
            p.Cnp = copil.Cnp;            
            p.Nume = copil.Nume;
            p.Prenume = copil.Prenume;
            p.Varsta = copil.Varsta;
            p.Sex = copil.Sex;
            p.Vorbeste = copil.Vorbeste;            
            _db.SaveChanges();
            return RedirectToAction("Copil", "User");
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public ActionResult ProfileEditAsociatie(Asociatie asoc)
        {
            Asociatie p = _db.Asociatie.Where(s => s.Id == asoc.Id).FirstOrDefault();
            p.Denumire = asoc.Denumire;
            p.CodFiscal = asoc.CodFiscal;
            p.NrRegCom = asoc.NrRegCom;
            p.DataInfintare = asoc.DataInfintare;
            p.Iban = asoc.Iban;
            p.Localitate = asoc.Localitate;
            p.Judet = asoc.Judet;
            p.Adresa = asoc.Adresa;            
            _db.SaveChanges();
            return RedirectToAction("Asociatie", "User");
        }

        [Authorize(Roles = "Utilizator")]
        [HttpGet]
        public ActionResult AddCopil()
        {
            return View();
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public ActionResult AddCopil(Copil model)
        {            
            var userid = User.Identity.Name;
            var parinte = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
            Copil asd2 = new Copil();
            asd2 = model;
            asd2.ParinteId = parinte.Id;
            _db.Copil.Add(asd2);
            _db.SaveChanges();
            
            ParinteCopil asd = new ParinteCopil();

            asd.Parinte = parinte;
            asd.Copil = model;

            _db.ParinteCopil.Add(asd);            
            _db.SaveChanges();            

            return RedirectToAction("Copil", "User");
        }

        [Authorize(Roles = "Utilizator")]
        [HttpGet]
        public ActionResult AddAsociatie()
        {
            return View();
        }

        [Authorize(Roles = "Utilizator")]
        [HttpPost]
        public ActionResult AddAsociatie(Asociatie model)
        {           
                        
            var userid = User.Identity.Name;
            var parinte = _db.Parinte.Where(s => s.Email == userid).FirstOrDefault();
            var copil = _db.ParinteCopil.Where(s => s.Parinte == parinte).FirstOrDefault();

            Asociatie asd3 = new Asociatie();
            asd3 = model;
            asd3.ParinteId = parinte.Id;
            asd3.CopilId = copil.CopilId;
            _db.Asociatie.Add(asd3);
            _db.SaveChanges();

            AsocParinte asd = new AsocParinte();

            asd.Parinte = parinte;
            asd.Asociatie = model;

            _db.AsocParinte.Add(asd);
            _db.SaveChanges();
                                    
            AsocCopil asd2 = new AsocCopil();
            asd2.AsocId = model.Id;
            asd2.CopilId = copil.CopilId;
            _db.AsocCopil.Add(asd2);
            _db.SaveChanges();

            return RedirectToAction("Asociatie", "User");
        }
    }
}