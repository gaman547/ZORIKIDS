using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZORI_KIDS_KG.Model;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class AdminsController : Controller
    {
        private zori_kids_dbContext _db;

        public AdminsController(zori_kids_dbContext context)
        {
            _db = context;
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            var myDbContext = _db.Admins.Include(a => a.Roles);
            return View(await myDbContext.ToListAsync());
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            ViewBag.RolesId = new SelectList(_db.Roles, "Id", "Title");
            return View();
        }
                
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,FullName,Email,Password,RolesId")] Admins admins)
        {
            if (ModelState.IsValid)
            {
                _db.Add(admins);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["RolesId"] = new SelectList(_db.Roles, "Id", "Title", admins.RolesId);

            return View(admins);
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _db.Admins.SingleOrDefaultAsync(m => m.Id == id);

            if (admins == null)
            {
                return NotFound();
            }
            ViewData["RolesId"] = new SelectList(_db.Roles, "Id", "Title", admins.RolesId);
            return View(admins);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,RolesId")] Admins admins)
        {
            if (id != admins.Id)
            {
                return NotFound();
            }

            Admins admin = await _db.Admins.Where(s => s.Id == admins.Id).FirstOrDefaultAsync();
            admin.FullName = admins.FullName;
            admin.Email = admins.Email;
            admin.RolesId = admins.RolesId;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _db.Admins
                .Include(a => a.Roles)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (admins == null)
            {
                return NotFound();
            }

            return View(admins);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _db.Admins.SingleOrDefaultAsync(m => m.Id == id);
            _db.Admins.Remove(admins);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Admins adm = _db.Admins.Where(s => s.Id == id).First();
                _db.Admins.Remove(adm);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool AdminsExists(int id)
        {
            return _db.Admins.Any(e => e.Id == id);
        }
    }
}