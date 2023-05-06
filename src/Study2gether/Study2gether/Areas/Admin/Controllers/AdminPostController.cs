using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Study2gether.Models;

namespace Study2gether.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminPostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminPostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Post
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Post.Include(p => p.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Post/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.User)
                .Include(o => o.Axes)
                .Include(o => o.Microfoundations)
                .Include(o => o.Categories)
                .FirstOrDefaultAsync(m => m.idPost == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Post/Create
        public IActionResult Create()
        {
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email");
            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPost,type,title,content,views,created_date,idUser")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.idPost = Guid.NewGuid();
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return View(post);
        }

        // GET: Post/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return View(post);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("idPost,type,title,content,views,created_date,idUser")] Post post)
        {
            if (id != post.idPost)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.idPost))
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
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return View(post);
        }

        // GET: Post/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.idPost == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var post = await _context.Post.FindAsync(id);
            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(Guid id)
        {
            return _context.Post.Any(e => e.idPost == id);
        }

        public IActionResult Interacoes()
        {
            var categories = _context.Category.ToList();
            var axes = _context.Axis.ToList();
            var microfoundations = _context.Microfoundation.ToList();
            ViewData["Categories"] = categories;
            ViewData["Axes"] = axes;
            ViewData["Microfoundations"] = microfoundations;
            //ViewData["postList"] = _context.Post.Where(c => c.type == (Types)1).ToList();
            var applicationDbContext = _context.Post.Include(p => p.User);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Interacoes([Bind("idPost,title,content")] Post post, List<Guid> categoryId, List<Guid> axisId, List<Guid> microfoundationId)
        {

            if (ModelState.IsValid)
            {
                var category = await _context.Category.Where(c => categoryId.Contains(c.idCategory)).ToListAsync();
                var axis = await _context.Axis.Where(c => axisId.Contains(c.idAxis)).ToListAsync();
                var microfoundation = await _context.Microfoundation.Where(c => microfoundationId.Contains(c.idMicrofoundation)).ToListAsync();

                foreach (var obj in category) { post.Categories.Add(obj); }
                foreach (var obj in axis) { post.Axes.Add(obj); }
                foreach (var obj in microfoundation) { post.Microfoundations.Add(obj); }

                post.views = 0;
                post.created_date = DateTime.Now;
                post.type = (Types)1;
                post.idPost = Guid.NewGuid();
                post.idUser = Guid.Parse(User.FindFirstValue("idUser"));

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return View(post);
        }

    }
}
