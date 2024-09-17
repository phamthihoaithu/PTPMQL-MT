using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class EntiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enti
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enti.ToListAsync());
        }

        // GET: Enti/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enti = await _context.Enti
                .FirstOrDefaultAsync(m => m.EntiID == id);
            if (enti == null)
            {
                return NotFound();
            }

            return View(enti);
        }

        // GET: Enti/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntiID,FullName,Address")] Enti enti)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enti);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enti);
        }

        // GET: Enti/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enti = await _context.Enti.FindAsync(id);
            if (enti == null)
            {
                return NotFound();
            }
            return View(enti);
        }

        // POST: Enti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EntiID,FullName,Address")] Enti enti)
        {
            if (id != enti.EntiID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enti);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntiExists(enti.EntiID))
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
            return View(enti);
        }

        // GET: Enti/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enti = await _context.Enti
                .FirstOrDefaultAsync(m => m.EntiID == id);
            if (enti == null)
            {
                return NotFound();
            }

            return View(enti);
        }

        // POST: Enti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var enti = await _context.Enti.FindAsync(id);
            if (enti != null)
            {
                _context.Enti.Remove(enti);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntiExists(string id)
        {
            return _context.Enti.Any(e => e.EntiID == id);
        }
    }
}
