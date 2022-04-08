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
    public class CotizarController : Controller
    {
        private readonly MVCGPContext _context;

        public CotizarController(MVCGPContext context)
        {
            _context = context;
        }

        // GET: Cotizar
        public async Task<IActionResult> Index()
        {
            var mVCGPContext = _context.Cotizar.Include(c => c.Producto).Include(c => c.Semanas);
            return View(await mVCGPContext.ToListAsync());
        }

        // GET: Cotizar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotizar = await _context.Cotizar
                .Include(c => c.Producto)
                .Include(c => c.Semanas)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cotizar == null)
            {
                return NotFound();
            }

            return View(cotizar);
        }

        // GET: Cotizar/Create
        public IActionResult Create()
        {
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "nombreProducto");
            ViewData["SemanasId"] = new SelectList(_context.Semanas, "Id", "Plazoss");
            return View();
        }

        // POST: Cotizar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductoId,SemanasId")] Cotizar cotizar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cotizar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "nombreProducto", cotizar.ProductoId);
            ViewData["SemanasId"] = new SelectList(_context.Semanas, "Id", "Plazoss", cotizar.SemanasId);
            return View(cotizar);
        }

        // GET: Cotizar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotizar = await _context.Cotizar.FindAsync(id);
            if (cotizar == null)
            {
                return NotFound();
            }
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "nombreProducto", cotizar.ProductoId);
            ViewData["SemanasId"] = new SelectList(_context.Semanas, "Id", "Plazoss", cotizar.SemanasId);
            return View(cotizar);
        }

        // POST: Cotizar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductoId,SemanasId")] Cotizar cotizar)
        {
            if (id != cotizar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cotizar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CotizarExists(cotizar.Id))
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
            ViewData["ProductoId"] = new SelectList(_context.Producto, "Id", "nombreProducto", cotizar.ProductoId);
            ViewData["SemanasId"] = new SelectList(_context.Semanas, "Id", "Plazoss", cotizar.SemanasId);
            return View(cotizar);
        }

        // GET: Cotizar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotizar = await _context.Cotizar
                .Include(c => c.Producto)
                .Include(c => c.Semanas)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cotizar == null)
            {
                return NotFound();
            }

            return View(cotizar);
        }

        // POST: Cotizar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cotizar = await _context.Cotizar.FindAsync(id);
            _context.Cotizar.Remove(cotizar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CotizarExists(int id)
        {
            return _context.Cotizar.Any(e => e.Id == id);
        }
    }
}
