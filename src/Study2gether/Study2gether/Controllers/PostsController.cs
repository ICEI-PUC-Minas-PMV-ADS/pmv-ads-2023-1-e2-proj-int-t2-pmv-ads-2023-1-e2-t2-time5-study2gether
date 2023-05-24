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
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

                
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

        public IActionResult Indicacoes(string searchText)
        {
            ViewData["Categories"] = _context.Category.ToList();
            ViewData["Axes"] = _context.Axis.ToList();
            ViewData["Microfoundations"] = _context.Microfoundation.ToList();
            ViewBag.ViewType = "Indicacoes";


            if (!string.IsNullOrEmpty(searchText))
            {
                ViewData["FilteredPostList"] = _context.Post
                    .Where(p => p.type == (Types)0)
                    .Where(p => p.title.Contains(searchText) || p.content.Contains(searchText))
                    .Include(p => p.Reactions)
                    .OrderByDescending(p => p.created_date)
                    .ToList();
            }

            else
            {
                ViewData["FilteredPostList"] = null;
            }

            ViewData["postList"] = _context.Post.Where(o => o.type == (Types)0).Include(o => o.Reactions).Include(o => o.Answers).OrderByDescending(o => o.created_date).ToList();

            var applicationDbContext = _context.Post.Include(p => p.User);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Indicacoes([Bind("idPost,title,content")] Post post, List<Guid> categoryId, List<Guid> axisId, List<Guid> microfoundationId)
        {
            
            if (ModelState.IsValid && User.IsInRole("admin"))
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

        public IActionResult Interacoes(string searchText)
        {
            var categories = _context.Category.ToList();
            var axes = _context.Axis.ToList();
            var microfoundations = _context.Microfoundation.ToList();
            ViewData["Categories"] = categories;
            ViewData["Axes"] = axes;
            ViewData["Microfoundations"] = microfoundations;
            ViewBag.ViewType = "Interacoes";

            if (!string.IsNullOrEmpty(searchText))
            {
                ViewData["FilteredPostList"] = _context.Post
                    .Where(p => p.type == (Types)1)
                    .Where(p => p.title.Contains(searchText) || p.content.Contains(searchText))
                    .Include(p => p.Reactions)
                    .OrderByDescending(p => p.created_date)
                    .ToList();
            }
            else
            {
                ViewData["FilteredPostList"] = null; 
            }

            ViewData["postList"] = _context.Post
                .Where(o => o.type == (Types)1)
                .Include(o => o.Reactions)
                .OrderByDescending(o => o.created_date)
                .ToList();

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
                return RedirectToAction(nameof(Interacoes));
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return RedirectToAction(nameof(Interacoes));
        }

    
        public IActionResult PostagemResposta()
        {
            return View();
        }

        public IActionResult Respostas(Guid id)
        {
            ViewData["perguntas"] = _context.Post.Include(p => p.Answers).Single(p => p.idPost == id);
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Respostas([Bind("title,content")] Answer resposta, Guid id)
        {
            
                if (ModelState.IsValid)
                {
                    resposta.idAnswer = Guid.NewGuid();
                    resposta.idPost = id;
                    resposta.idUser = Guid.Parse(User.FindFirstValue("idUser"));
                               
                    _context.Add(resposta);
                    _context.SaveChanges();
                    
                    return RedirectToAction("Respostas", "Posts", new { id = resposta.idPost });
                }
            
            
            return View(resposta);
        }
        public IActionResult Perguntas(string searchText)
        {

            ViewData["Categories"] = _context.Category.ToList();
            ViewData["Axes"] = _context.Axis.ToList();
            ViewData["Microfoundations"] = _context.Microfoundation.ToList();
            ViewBag.ViewType = "Perguntas";

            if (!string.IsNullOrEmpty(searchText))
            {
                ViewData["FilteredPostList"] = _context.Post
                    .Where(p => p.type == (Types)2)
                    .Where(p => p.title.Contains(searchText) || p.content.Contains(searchText))
                    .Include(p => p.Reactions)
                    .OrderByDescending(p => p.created_date)
                    .ToList();
            }

            else
            {
                ViewData["FilteredPostList"] = null;
            }

            ViewData["postList"] = _context.Post.Where(o => o.type == (Types)2).Include(o => o.Reactions).Include(o => o.Answers).OrderByDescending(o => o.created_date).ToList();
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
                post.type = (Types)2;
                post.idPost = Guid.NewGuid();
                post.idUser = Guid.Parse(User.FindFirstValue("idUser"));

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Perguntas));
            }
            ViewData["idUser"] = new SelectList(_context.Users, "idUser", "email", post.idUser);
            return View(post);
        }

        public IActionResult ReactToPost(Guid idPost, string reactioName)
        {
            var user = Guid.Parse(User.FindFirstValue("idUser"));

            if(reactioName == "Star")
            {
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
                    return Json(new { status = "success", message = "Post favoritado com successo", type = "FavAdd" });
                }
                else
                {
                    var reaction = _context.Reactions.First(m => m.Name == reactioName && m.idPost == idPost && m.idUser == user);
                    _context.Reactions.Remove(reaction);
                    _context.SaveChanges();
                    return Json(new { status = "success", message = "Post removido dos favoritos", type = "FavRemove" });
                }

            }

            var userReaction = _context.Reactions.FirstOrDefault(m => m.Name != "Star" &&  m.idPost == idPost && m.idUser == user);

            if (userReaction == null)
            {
                var reaction = new Reaction();
                reaction.Id = Guid.NewGuid();
                reaction.Name = reactioName;
                reaction.idUser = user;
                reaction.idPost = idPost;
                _context.Reactions.Add(reaction);
                _context.SaveChanges();
                return Json(new { status = "success", message = "Reação adiciona com sucesso", type="add" });
            }
            else if(userReaction.Name == reactioName)
            {
                var reaction = _context.Reactions.First(m => m.Name == reactioName && m.idPost == idPost && m.idUser == user);
                _context.Reactions.Remove(reaction);
                _context.SaveChanges();
                return Json(new { status = "success", message = "Reação removida com sucesso", type = "remove" });
            }
            else
            {
                return Json(new { status = "Error", message = "Você já reagiu a este post", type = "error" });
            }
        }
    }
}
