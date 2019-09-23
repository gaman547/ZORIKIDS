﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZORI_KIDS_KG.Model;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class RolesController : Controller
    {
        private zori_kids_dbContext _db;

        public RolesController(zori_kids_dbContext context)
        {
            _db = context;
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return View(await _db.Roles.ToListAsync());
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }
                
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                _db.Add(roles);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _db.Roles.SingleOrDefaultAsync(m => m.Id == id);
            if (roles == null)
            {
                return NotFound();
            }

            DataSet ds = new DataSet();
            List<string> menus_id = _db.LinkRolesMenus.Where(s => s.RolesId == id).Select(s => s.MenusId.ToString()).ToList();
            ds = ToDataSet(_db.Menus.ToList());
            DataTable table = ds.Tables[0];
            DataRow[] parentMenus = table.Select("ParentId = 0");

            var sb = new StringBuilder();
            string unorderedList = GenerateUL(parentMenus, table, sb, menus_id);
            ViewBag.menu = unorderedList;

            return View(roles);
        }
                
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Roles roles)
        {
            if (id != roles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(roles);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RolesExists(roles.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _db.Roles
                .SingleOrDefaultAsync(m => m.Id == id);
            if (roles == null)
            {
                return NotFound();
            }

            return View(roles);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            foreach (var role in _db.LinkRolesMenus.Where(s => s.RolesId == id))
            {
                _db.LinkRolesMenus.Remove(role);
            }
            await _db.SaveChangesAsync();

            var roles = await _db.Roles.SingleOrDefaultAsync(m => m.Id == id);
            _db.Roles.Remove(roles);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Update(int id, List<int> roles)
        {
            var temp = _db.LinkRolesMenus.Where(s => s.RolesId == id);
            foreach (var item in temp)
            {
                _db.LinkRolesMenus.Remove(item);
            }

            foreach (var role in roles)
            {
                _db.LinkRolesMenus.Add(new LinkRolesMenus { MenusId = role, RolesId = id });
            }

            _db.SaveChanges();

            return Json(new { status = true, message = "Success!" });
        }

        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Roles rol = _db.Roles.Where(s => s.Id == id).First();
                _db.Roles.Remove(rol);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool RolesExists(int id)
        {
            return _db.Roles.Any(e => e.Id == id);
        }
        
        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb, List<string> menus_id)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string id = dr["id"].ToString();
                    string handler = dr["url"].ToString();
                    string menuText = dr["name"].ToString();
                    string icon = dr["icon"].ToString();

                    string pid = dr["id"].ToString();
                    string parentId = dr["ParentId"].ToString();

                    string status = (menus_id.Contains(id)) ? "Checked" : "";

                    DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string line = String.Format(@"<li class=""has""><input type=""checkbox"" name=""subdomain[]"" id=""{5}"" value=""{1}"" {4}><label>> {1}</label>", handler, menuText, icon, "target", status, id);
                        sb.Append(line);

                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(String.Format(@"<ul>"));
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder, menus_id));
                        sb.Append("</ul>");
                    }
                    else
                    {
                        string line = String.Format(@"<li class=""""><input type=""checkbox"" name=""subdomain[]"" id=""{5}"" value=""{1}"" {4}><label>{1}</label>", handler, menuText, icon, "target", status, id);
                        sb.Append(line);
                    }
                    sb.Append("</li>");
                }
            }
            return sb.ToString();
        }

        public DataSet ToDataSet<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {                
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            return ds;
        }
    }
}