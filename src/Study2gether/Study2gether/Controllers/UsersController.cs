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

namespace Study2gether.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
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

        public IActionResult Historico()
        {
            return View();
        }

        //private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        
        public async Task<IActionResult> EditarPefil(string email)
        {
           
            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.email == email);
            /*
           
            User user = await _userManager.FindByEmailAsync(email);
           
            User user = await _userManager.FindByEmailAsync();
            */
            //var user = await GetCurrentUserAsync();

            if (user != null)
                return View(user);
            else
                return RedirectToAction("Historico");
        }

        public IActionResult EditarPerfil()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> EditarPerfil(Guid idUser, string name, string password, string email, string description, string imageLink, string socialMedia)
        {

            User user = await _userManager.FindByIdAsync(idUser.ToString());
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.email = email;
                else
                    ModelState.AddModelError("", "O E-mail não pode ser vazio");

                if (!string.IsNullOrEmpty(name))
                    user.name = name;
                else
                    ModelState.AddModelError("", "O Nome não pode ser vazio");

                if (!string.IsNullOrEmpty(password))
                    user.password = password;
                else
                    ModelState.AddModelError("", "A senha não pode ser vazia");

                if (!string.IsNullOrEmpty(description))
                    user.description = description;
                else
                    ModelState.AddModelError("", "A descrição não pode ser vazia");

                if (!string.IsNullOrEmpty(imageLink))
                    user.imageLink = imageLink;
                else
                    ModelState.AddModelError("", "A imagem do usuário não pode ser vazia");

                if (!string.IsNullOrEmpty(socialMedia))
                    user.socialMedia = socialMedia;
                else
                    ModelState.AddModelError("", "A rede social do usuário não pode ser vazia");



                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Historico");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "Usuário não encontrado");
            return View(user);
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
