﻿using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class NoticeController : Controller
    {
        private readonly AppDbContext _context;
        public NoticeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Notices.Where(n=>n.IsDeleted==false).ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Notice notice =  _context.Notices.Where(n=>n.IsDeleted==false).FirstOrDefault(n=>n.Id==id);
            if (notice == null) return NotFound();
            return View(notice);
        }
        // GET: Notice/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Notice/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Notice notice)
        {
            if (notice == null)
            {
                ModelState.AddModelError("", "Xanani mutleq doldurmalisiniz");
                return View();
            }
            notice.AddedTime = DateTime.Now;
            notice.IsDeleted = false;
            await _context.Notices.AddAsync(notice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: Notice/Update/5
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Notice notice =  _context.Notices.Where(n=>n.IsDeleted==false).FirstOrDefault(n => n.Id == id);
            if (notice == null) return NotFound();
            return View(notice);
        }
        // POST: Notice/Update/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Notice notice)
        {
            if (id == null) return NotFound();
            Notice isExist = _context.Notices.Where(n => n.IsDeleted == false).FirstOrDefault(n => n.Id == id);
            if (isExist == null) return NotFound();
            if (notice == null)
            {
                ModelState.AddModelError("", "Yenilenecek data tapilmadi");
                return View();
            }
            isExist.Content = notice.Content;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: Notice/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Notice notice = _context.Notices.Where(n => n.IsDeleted == false).FirstOrDefault(n => n.Id == id);
            if (notice == null) return NotFound();
            return View(notice);
        }
        // POST: Notice/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Notice notice = _context.Notices.Where(n => n.IsDeleted == false).FirstOrDefault(n => n.Id == id);
            if (notice == null) return NotFound();
            notice.IsDeleted = true;
            notice.DeletedTime = DateTime.Now;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
