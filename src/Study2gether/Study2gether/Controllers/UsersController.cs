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
            ClaimsPrincipal claimIdentity = User;
            String identityName = claimIdentity.Identity.Name;

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.email == identityName);

            return View("Historico", user);
        }

        public async Task<IActionResult> EditarPerfil()
        {
            ClaimsPrincipal claimIdentity = User;
            String identityName = claimIdentity.Identity.Name;

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.email == identityName);

            return View("EditarPerfil", user);
        }

        [HttpPost]
        public async Task<IActionResult> EditarPerfil(string name, string previousPassword, string newPassword1, string newPassword2, string description, string imageLink, string socialMedia)
        {
            ClaimsPrincipal claimIdentity = HttpContext.User;

            String identityName = claimIdentity.Identity.Name;

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.email == identityName);

            if (user != null)
            {
                if (!string.IsNullOrEmpty(name))
                    user.name = name;

                if (!string.IsNullOrEmpty(previousPassword))
                {
                    previousPassword = BCrypt.Net.BCrypt.HashPassword(previousPassword);
                    bool ispasswordOk = BCrypt.Net.BCrypt.Verify(previousPassword, user.password);
                    if (ispasswordOk)
                    {
                        if (!string.IsNullOrEmpty(newPassword1) && !string.IsNullOrEmpty(newPassword2) && newPassword1 == newPassword2)
                            user.password = newPassword1;
                    }
                    else
                    {
                        ModelState.AddModelError("", "Senha atual errada.");
                        return View();
                    }
                }

                if (!string.IsNullOrEmpty(description))
                    user.description = description;

                if (!string.IsNullOrEmpty(imageLink))
                    user.imageLink = imageLink;

                if (!string.IsNullOrEmpty(socialMedia))
                    user.socialMedia = socialMedia;

                await _context.SaveChangesAsync();

                /*if (!string.IsNullOrEmpty(identityName) && !string.IsNullOrEmpty(password))
                {
                    await _context.SaveChangesAsync();
                    if (result.Succeeded)
                        return RedirectToAction("Historico");
                    else
                        Errors(result);*/
            }
            else {
                ModelState.AddModelError("", "Usuário não encontrado");
                return View();
            }

            return View("Historico", user);
        }
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }


        /*
        // Rascunho - EditarPeril
        // Primeiro precisamos utilizar o método GET: para obter os dados e depois Editá-los.
        public IActionResult EditarPerfil(Guid? idUser)


        {

            User.Identity.GetUserId();
            return View();
        }

        
        // Obtidos os dados (pelo GET:) vamos ao método POST:
        [HttpPost]
        
        public IActionResult EditarPerfil([Bind("name,password,email,description,imageLink,socialMedia")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
                return View("Views/Home/Historico.cshtml");
            }
            return View(user);
        } 
        */



        //Segundo Teste - 27/04/23


    }
}
