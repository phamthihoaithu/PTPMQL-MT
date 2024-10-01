using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.Data;
namespace MVC.Controllers;
public class PersonController : Controller
{
    private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
    public async Task<IActionResult> Index()
    {
        return View(await _context.Person.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Person ps)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ps);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ps);
    }

    public async Task<IActionResult> Edit(string id)
    {
        if (id == null || _context.Person == null)
         {
            return NotFound();
        }

        var ps = await _context.Person.FindAsync(id);
        if (ps == null)
        {
            return NotFound();
        }
        return View(ps);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, Person ps)
    {
        if (id != ps.CCCD)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ps);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(ps.CCCD))
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
        return View(ps);
    }
    public async Task<IActionResult> Delete(string id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ps = await _context.Person
            .FirstOrDefaultAsync(m => m.CCCD == id);
        if (ps == null)
        {
            return NotFound();
        }
        return View(ps);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        var ps = await _context.Person.FindAsync(id);
        if (ps != null)
        {
            _context.Person.Remove(ps);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    private bool PersonExists(string id)
    {
        return _context.Person.Any(e => e.CCCD == id);
    }
}