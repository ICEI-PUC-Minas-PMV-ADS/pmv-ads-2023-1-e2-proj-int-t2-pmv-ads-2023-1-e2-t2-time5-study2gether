using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Study2gether.Models;

namespace Study2gether.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminMicrofoundationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminMicrofoundationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Microfoundations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Microfoundation.ToListAsync());
        }

        // GET: Microfoundations/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var microfoundation = await _context.Microfoundation
                .FirstOrDefaultAsync(m => m.idMicrofoundation == id);
            if (microfoundation == null)
            {
                return NotFound();
            }

            return View(microfoundation);
        }

        // GET: Microfoundations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Microfoundations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idMicrofoundation,name")] Microfoundation microfoundation)
        {
            if (ModelState.IsValid)
            {
                microfoundation.idMicrofoundation = Guid.NewGuid();
                _context.Add(microfoundation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(microfoundation);
        }

        // GET: Microfoundations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var microfoundation = await _context.Microfoundation.FindAsync(id);
            if (microfoundation == null)
            {
                return NotFound();
            }
            return View(microfoundation);
        }

        // POST: Microfoundations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("idMicrofoundation,name")] Microfoundation microfoundation)
        {
            if (id != microfoundation.idMicrofoundation)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(microfoundation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MicrofoundationExists(microfoundation.idMicrofoundation))
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
            return View(microfoundation);
        }

        // GET: Microfoundations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var microfoundation = await _context.Microfoundation
                .FirstOrDefaultAsync(m => m.idMicrofoundation == id);
            if (microfoundation == null)
            {
                return NotFound();
            }

            return View(microfoundation);
        }

        // POST: Microfoundations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var microfoundation = await _context.Microfoundation.FindAsync(id);
            _context.Microfoundation.Remove(microfoundation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MicrofoundationExists(Guid id)
        {
            return _context.Microfoundation.Any(e => e.idMicrofoundation == id);
        }
    }
}
