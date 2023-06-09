﻿using System;
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
    [Authorize(Roles = "Admin")]
    public class UposlenikController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UposlenikController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Uposlenik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Uposlenik.ToListAsync());
        }

        // GET: Uposlenik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uposlenik = await _context.Uposlenik
                .FirstOrDefaultAsync(m => m.KorisnikId == id);
            if (uposlenik == null)
            {
                return NotFound();
            }

            return View(uposlenik);
        }

        // GET: Uposlenik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Uposlenik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Plata,KorisnikId,Ime,Prezime,KorisnickoIme,Email,Lozinka,Slika")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uposlenik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uposlenik);
        }

        // GET: Uposlenik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uposlenik = await _context.Uposlenik.FindAsync(id);
            if (uposlenik == null)
            {
                return NotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposlenik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Plata,KorisnikId,Ime,Prezime,KorisnickoIme,Email,Lozinka,Slika")] Uposlenik uposlenik)
        {
            if (id != uposlenik.KorisnikId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uposlenik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UposlenikExists(uposlenik.KorisnikId))
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
            return View(uposlenik);
        }

        // GET: Uposlenik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uposlenik = await _context.Uposlenik
                .FirstOrDefaultAsync(m => m.KorisnikId == id);
            if (uposlenik == null)
            {
                return NotFound();
            }

            return View(uposlenik);
        }

        // POST: Uposlenik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uposlenik = await _context.Uposlenik.FindAsync(id);
            _context.Uposlenik.Remove(uposlenik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UposlenikExists(int id)
        {
            return _context.Uposlenik.Any(e => e.KorisnikId == id);
        }
    }
}
