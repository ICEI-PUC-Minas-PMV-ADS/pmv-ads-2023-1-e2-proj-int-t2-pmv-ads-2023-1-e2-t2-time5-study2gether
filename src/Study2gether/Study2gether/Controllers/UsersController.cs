using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Study2gether.Models;

namespace Study2gether.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login([Bind("email,password")] User userForm)
        {
            var userDb = await _context.Users
                .FirstOrDefaultAsync(m => m.email == userForm.email);

            if (userDb == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            bool ispasswordOk = BCrypt.Net.BCrypt.Verify(userForm.password, userDb.password);

            if (ispasswordOk)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, userDb.name == null ? userDb.email : userDb.name),
                        new Claim(ClaimTypes.NameIdentifier, userDb.name == null ? userDb.email : userDb.name),
                        new Claim(ClaimTypes.Role, userDb.isAdmin ? "admin" : "user"),
                        new Claim("idUser", userDb.idUser.ToString()),
                    };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();
        }

        public async Task<IActionResult> Logout() 
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



        public IActionResult AccessDenied()
        {
            return View();
        }


        public IActionResult Cadastro()
        {
            return View();
        }
        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro([Bind("idUser,email,password,createdDate")] User user)
        {
            var validateEmail = user.email.EndsWith("@sga.pucminas.br");
            var checkExistingEmail = _context.Users.FirstOrDefault(stored => stored.email == user.email);
            var validatePasswordLength = user.password.Length >= 8;
            if (!validateEmail)
{
    ModelState.AddModelError("email", "O e-mail deve ser um endereço de e-mail da PUC Minas.");
}

if (checkExistingEmail != null)
{
    ModelState.AddModelError("email", "Este e-mail já está em uso. Por favor, use outro e-mail.");
}

if (!validatePasswordLength)
{
    ModelState.AddModelError("password", "A senha deve ter pelo menos 8 caracteres.");
}
            if (ModelState.IsValid)
            {
                user.password = BCrypt.Net.BCrypt.HashPassword(user.password);
                user.idUser = Guid.NewGuid();
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.idUser == id);
        }
    }
}
