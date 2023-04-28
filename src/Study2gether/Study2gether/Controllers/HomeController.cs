using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Study2gether.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Study2gether.Controllers
{
    public class HomeController : Controller
    {
        //Acresermos este construtor _userManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Historico()
        {
            return View();
        }

        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IActionResult> EditarPerfil()
        {
            /*
            var userDb = await _context.Users
                .FirstOrDefaultAsync(m => m.email == email);
           
            User user = await _userManager.FindByIdAsync(idUser.ToString());
           
            User user = await _userManager.FindByEmailAsync(email);
            */


            var user = await GetCurrentUserAsync();

            if (user != null)
                return View(user);
            else
                return RedirectToAction("Historico");
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

    }
}
