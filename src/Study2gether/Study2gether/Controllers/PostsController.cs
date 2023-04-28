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
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Views INDICAÇÕES, INTERAÇÕES E PERGUNTAS
        
        public IActionResult PostagemPergunta()
        {
            return View();
        }

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

        public IActionResult Indicacoes()
        {
            //Provavelmente não é a melhor forma de fazer isso
            //Mas eu não vou estudar .net tão a fundo assim
            ViewData["Categories"] = _context.Category.ToList();
            ViewData["Axes"] = _context.Axis.ToList();
            ViewData["Microfoundations"] = _context.Microfoundation.ToList();
            ViewData["postList"] = _context.Post.Include(o => o.Reactions).ToList();
            var applicationDbContext = _context.Post.Include(p => p.User);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Indicacoes([Bind("idPost,title,content")] Post post, List<Guid> categoryId, List<Guid> axisId, List<Guid> microfoundationId)
        {
            
            if (ModelState.IsValid)
            {
                var category = await _context.Category.Where(c => categoryId.Contains(c.idCategory)).ToListAsync();
                var axis = await _context.Axis.Where(c => axisId.Contains(c.idAxis)).ToListAsync();
                var microfoundation = await _context.Microfoundation.Where(c => microfoundationId.Contains(c.idMicrofoundation)).ToListAsync();

                foreach (var obj in category) { post.Categories.Add(obj); }
                foreach (var obj in axis){post.Axes.Add(obj);}
                foreach (var obj in microfoundation) {post.Microfoundations.Add(obj);}

                post.views = 0;
                post.created_date = DateTime.Now;
                post.type = (Types)0;
                post.idPost = Guid.NewGuid();
                post.idUser = Guid.Parse(User.FindFirstValue("idUser"));

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Indicacoes));
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return RedirectToAction(nameof(Indicacoes));
        }

        public IActionResult Interacoes()
        {
            return View();
        }

        public IActionResult PostagemInteracoes()
        {
            return View();
        }

        public IActionResult PostagemResposta()
        {
            return View();
        }

        public IActionResult Respostas()
        {
            return View();
        }

        public IActionResult Perguntas()
        {
            //Provavelmente não é a melhor forma de fazer isso
            //Mas eu não vou estudar .net tão a fundo assim
            ViewData["Categories"] = _context.Category.ToList();
            ViewData["Axes"] = _context.Axis.ToList();
            ViewData["Microfoundations"] = _context.Microfoundation.ToList();
            ViewData["postList"] = _context.Post.ToList();
            var applicationDbContext = _context.Post.Include(p => p.User);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Perguntas([Bind("idPost,title,content")] Post post, List<Guid> categoryId, List<Guid> axisId, List<Guid> microfoundationId)
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
                post.type = (Types)0;
                post.idPost = Guid.NewGuid();
                post.idUser = Guid.Parse(User.FindFirstValue("idUser"));

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return View(post);
        }

        public IActionResult ReactToPost(Guid idPost, string reactioName)
        {
            // isso devia na verdade ser um request por ajax ou coisa do tipo
            // visto que assim a page do usuario vai atulizar toda vez que
            // ele fizer uma nova reação, mas meu tempo é limitado.
            // talvez tenha alguma forma de fazer sem ser por ajax tbm.
            var user = Guid.Parse(User.FindFirstValue("idUser"));
            var shouldCreate = _context.Reactions.Any(m => m.Name == reactioName && m.idPost == idPost && m.idUser == user);
            if (!shouldCreate)
            {
                var reaction = new Reaction();
                reaction.Id = Guid.NewGuid();
                reaction.Name = reactioName;
                reaction.idUser = user;
                reaction.idPost = idPost;
                _context.Reactions.Add(reaction);
                _context.SaveChanges();
            }
            else
            {
                // talvez valesse mais apena eu já pegar a reação no shouldCreate pra evitar uma segunda query, mas vamo que vamo.
                var reaction = _context.Reactions.First(m => m.Name == reactioName && m.idPost == idPost && m.idUser == user);
                _context.Reactions.Remove(reaction);
                _context.SaveChanges();
            }
           
            return RedirectToAction(nameof(Indicacoes));
        }
    }
}
