using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Data;

namespace KooliProjekt.Controllers
{
    public class TestPäevikController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestPäevikController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Päevik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Päevik.ToListAsync());
        }

        // GET: Päevik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Päevik == null)
            {
                return NotFound();
            }

            var päevik = await _context.Päevik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (päevik == null)
            {
                return NotFound();
            }

            return View(päevik);
        }

        // GET: Päevik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Päevik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Kuupäev,Harjutus, Kordused")] Päevik päevik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(päevik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(päevik);
        }

        // GET: Päevik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Päevik == null)
            {
                return NotFound();
            }

            var päevik = await _context.Päevik.FindAsync(id);
            if (päevik == null)
            {
                return NotFound();
            }
            return View(päevik);
        }

        // POST: Päevik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] Päevik päevik)
        {
            if (id != päevik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(päevik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PäevikExists(päevik.Id))
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
            return View(päevik);
        }

        // GET: Päevik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Päevik == null)
            {
                return NotFound();
            }

            var päevik = await _context.Päevik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (päevik == null)
            {
                return NotFound();
            }

            return View(päevik);
        }

        // POST: Päevik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Päevik == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Päevik'  is null.");
            }
            var päevik = await _context.Päevik.FindAsync(id);
            if (päevik != null)
            {
                _context.Päevik.Remove(päevik);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PäevikExists(int id)
        {
            return _context.Päevik.Any(e => e.Id == id);
        }
    }
}
