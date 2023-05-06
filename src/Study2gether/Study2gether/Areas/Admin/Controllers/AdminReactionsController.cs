using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Study2gether.Models;

namespace Study2gether.Controllers
{
    public class AdminReactionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminReactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reactions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reactions.Include(r => r.Answer).Include(r => r.Post).Include(r => r.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reactions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reaction = await _context.Reactions
                .Include(r => r.Answer)
                .Include(r => r.Post)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reaction == null)
            {
                return NotFound();
            }

            return View(reaction);
        }

        // GET: Reactions/Create
        public IActionResult Create()
        {
            ViewData["idAnswer"] = new SelectList(_context.Answers, "idAnswer", "content");
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content");
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email");
            return View();
        }

        // POST: Reactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,idUser,idAnswer,idPost")] Reaction reaction)
        {
            if (ModelState.IsValid)
            {
                reaction.Id = Guid.NewGuid();
                _context.Add(reaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idAnswer"] = new SelectList(_context.Answers, "idAnswer", "content", reaction.idAnswer);
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content", reaction.idPost);
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", reaction.idUser);
            return View(reaction);
        }

        // GET: Reactions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reaction = await _context.Reactions.FindAsync(id);
            if (reaction == null)
            {
                return NotFound();
            }
            ViewData["idAnswer"] = new SelectList(_context.Answers, "idAnswer", "content", reaction.idAnswer);
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content", reaction.idPost);
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", reaction.idUser);
            return View(reaction);
        }

        // POST: Reactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,idUser,idAnswer,idPost")] Reaction reaction)
        {
            if (id != reaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReactionExists(reaction.Id))
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
            ViewData["idAnswer"] = new SelectList(_context.Answers, "idAnswer", "content", reaction.idAnswer);
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content", reaction.idPost);
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", reaction.idUser);
            return View(reaction);
        }

        // GET: Reactions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reaction = await _context.Reactions
                .Include(r => r.Answer)
                .Include(r => r.Post)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reaction == null)
            {
                return NotFound();
            }

            return View(reaction);
        }

        // POST: Reactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var reaction = await _context.Reactions.FindAsync(id);
            _context.Reactions.Remove(reaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReactionExists(Guid id)
        {
            return _context.Reactions.Any(e => e.Id == id);
        }
    }
}
