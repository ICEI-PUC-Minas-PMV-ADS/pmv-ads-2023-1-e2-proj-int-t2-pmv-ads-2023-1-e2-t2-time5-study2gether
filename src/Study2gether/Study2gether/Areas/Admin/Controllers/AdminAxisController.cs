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
    public class AdminAxisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminAxisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Axis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Axis.ToListAsync());
        }

        // GET: Axis/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var axis = await _context.Axis
                .Include(o => o.Posts)
                .FirstOrDefaultAsync(m => m.idAxis == id);
            if (axis == null)
            {
                return NotFound();
            }

            return View(axis);
        }

        // GET: Axis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Axis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idAxis,name")] Axis axis)
        {
            if (ModelState.IsValid)
            {
                axis.idAxis = Guid.NewGuid();
                _context.Add(axis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(axis);
        }

        // GET: Axis/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var axis = await _context.Axis.FindAsync(id);
            if (axis == null)
            {
                return NotFound();
            }
            return View(axis);
        }

        // POST: Axis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("idAxis,name")] Axis axis)
        {
            if (id != axis.idAxis)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(axis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AxisExists(axis.idAxis))
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
            return View(axis);
        }

        // GET: Axis/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var axis = await _context.Axis
                .FirstOrDefaultAsync(m => m.idAxis == id);
            if (axis == null)
            {
                return NotFound();
            }

            return View(axis);
        }

        // POST: Axis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var axis = await _context.Axis.FindAsync(id);
            _context.Axis.Remove(axis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AxisExists(Guid id)
        {
            return _context.Axis.Any(e => e.idAxis == id);
        }
    }
}
