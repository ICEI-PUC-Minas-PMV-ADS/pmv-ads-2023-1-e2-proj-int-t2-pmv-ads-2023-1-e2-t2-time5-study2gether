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
    public class AdminAnswersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminAnswersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Answers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Answers.Include(a => a.Post).Include(a => a.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Answers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers
                .Include(a => a.Post)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.idAnswer == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // GET: Answers/Create
        public IActionResult Create()
        {
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content");
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email");
            return View();
        }

        // POST: Answers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idAnswer,idPost,idUser,title,content")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.idAnswer = Guid.NewGuid();
                _context.Add(answer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content", answer.idPost);
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", answer.idUser);
            return View(answer);
        }

        // GET: Answers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content", answer.idPost);
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", answer.idUser);
            return View(answer);
        }

        // POST: Answers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("idAnswer,idPost,idUser,title,content")] Answer answer)
        {
            if (id != answer.idAnswer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerExists(answer.idAnswer))
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
            ViewData["idPost"] = new SelectList(_context.Post, "idPost", "content", answer.idPost);
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", answer.idUser);
            return View(answer);
        }

        // GET: Answers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers
                .Include(a => a.Post)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.idAnswer == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // POST: Answers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var answer = await _context.Answers.FindAsync(id);
            _context.Answers.Remove(answer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerExists(Guid id)
        {
            return _context.Answers.Any(e => e.idAnswer == id);
        }
    }
}
