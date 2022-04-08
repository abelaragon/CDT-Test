using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCGP.Data;
using MVCGP.Models;

namespace MVCGP.Controllers
{
    public class SemanasController : Controller
    {
        private readonly MVCGPContext _context;

        public SemanasController(MVCGPContext context)
        {
            _context = context;
        }

        // GET: Semanas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Semanas.ToListAsync());
        }

        // GET: Semanas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semanas = await _context.Semanas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (semanas == null)
            {
                return NotFound();
            }

            return View(semanas);
        }

        // GET: Semanas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Semanas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KeySemana,Plazoss,TasaP,TasaN")] Semanas semanas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(semanas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(semanas);
        }

        // GET: Semanas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semanas = await _context.Semanas.FindAsync(id);
            if (semanas == null)
            {
                return NotFound();
            }
            return View(semanas);
        }

        // POST: Semanas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KeySemana,Plazoss,TasaP,TasaN")] Semanas semanas)
        {
            if (id != semanas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(semanas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SemanasExists(semanas.Id))
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
            return View(semanas);
        }

        // GET: Semanas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var semanas = await _context.Semanas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (semanas == null)
            {
                return NotFound();
            }

            return View(semanas);
        }

        // POST: Semanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var semanas = await _context.Semanas.FindAsync(id);
            _context.Semanas.Remove(semanas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SemanasExists(int id)
        {
            return _context.Semanas.Any(e => e.Id == id);
        }
    }
}
