using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToyStore.Data;
using ToyStore.Models;

namespace ToyStore.Controllers
{
    [Authorize]
    public class NaplataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NaplataController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Naplata
        public async Task<IActionResult> Index()
        {
            return View(await _context.Naplata.ToListAsync());
        }

        // GET: Naplata/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naplata = await _context.Naplata
                .FirstOrDefaultAsync(m => m.NaplataId == id);
            if (naplata == null)
            {
                return NotFound();
            }

            return View(naplata);
        }

        // GET: Naplata/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Naplata/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NaplataId,Placeno,Datum")] Naplata naplata)
        {
            if (ModelState.IsValid)
            {
                naplata.Datum = DateTime.Now;
                _context.Add(naplata);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(naplata);
        }

        // GET: Naplata/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naplata = await _context.Naplata.FindAsync(id);
            if (naplata == null)
            {
                return NotFound();
            }
            return View(naplata);
        }

        // POST: Naplata/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NaplataId,Placeno,Datum")] Naplata naplata)
        {
            if (id != naplata.NaplataId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(naplata);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NaplataExists(naplata.NaplataId))
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
            return View(naplata);
        }

        // GET: Naplata/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naplata = await _context.Naplata
                .FirstOrDefaultAsync(m => m.NaplataId == id);
            if (naplata == null)
            {
                return NotFound();
            }

            return View(naplata);
        }

        // POST: Naplata/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var naplata = await _context.Naplata.FindAsync(id);
            _context.Naplata.Remove(naplata);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NaplataExists(int id)
        {
            return _context.Naplata.Any(e => e.NaplataId == id);
        }
    }
}
