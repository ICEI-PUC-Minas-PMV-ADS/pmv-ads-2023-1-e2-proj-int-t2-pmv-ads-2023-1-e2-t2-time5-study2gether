using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Study2gether.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

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

        public async Task<IActionResult> Historico()
        {
            var user = await _context.Users
                .Include(teste => teste.Posts)
                .Include(teste => teste.Answers)
                .FirstOrDefaultAsync(user => user.idUser == Guid.Parse(User.FindFirstValue("idUser")));

            return View("Historico", user);
        }

        public async Task<IActionResult> EditarPerfil()
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(user => user.idUser == Guid.Parse(User.FindFirstValue("idUser")));

            return View("EditarPerfil", user);
        }

        [HttpPost]
        public async Task<IActionResult> EditarPerfil(string name, string description, string imageLink, string socialMedia)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(user => user.idUser == Guid.Parse(User.FindFirstValue("idUser")));

            if (user != null)
            {
                if (!string.IsNullOrEmpty(name))
                    user.name = name;

                user.description = description;
                user.socialMedia = socialMedia;

                if (!string.IsNullOrEmpty(imageLink))
                { 
                    user.imageLink = imageLink;
                }

                await _context.SaveChangesAsync();
            }
            else
            {
                //ModelState.AddModelError("", "Usuário não encontrado");
                ViewBag.Message = "Usuário não encontrado.";
                return View();
            }

            return RedirectToAction("Historico");
        }

        public async Task<IActionResult> AlterarSenha()
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(user => user.idUser == Guid.Parse(User.FindFirstValue("idUser")));

            return View("AlterarSenha", user);
        }

        [HttpPost]
        public async Task<IActionResult> AlterarSenha(string previousPassword, string newPassword1, string newPassword2)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(user => user.idUser == Guid.Parse(User.FindFirstValue("idUser")));

            if (user != null)
            {
                if (!string.IsNullOrEmpty(previousPassword))
                {
                    bool ispasswordOk = BCrypt.Net.BCrypt.Verify(previousPassword, user.password);
                    if (ispasswordOk)
                    {
                        if (!string.IsNullOrEmpty(newPassword1) && !string.IsNullOrEmpty(newPassword2) && newPassword1 == newPassword2)
                        {
                            user.password = BCrypt.Net.BCrypt.HashPassword(newPassword1);
                        }
                        else
                        {
                            ViewBag.Message = "Confirmação de senha inválida";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Senha atual errada.";
                        return View();
                    }
                }
            }
            return RedirectToAction("Historico");
        }


        public async Task<IActionResult> DeleteUser()
        {
            var user = _context.Users.First(excluir => excluir.idUser == Guid.Parse(User.FindFirstValue("idUser")));
            _context.Users.Remove(user);
            _context.SaveChanges();
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }



}