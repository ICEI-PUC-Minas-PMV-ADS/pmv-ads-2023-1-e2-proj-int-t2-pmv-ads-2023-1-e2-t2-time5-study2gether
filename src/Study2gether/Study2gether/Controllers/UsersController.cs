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
using SendGrid;
using SendGrid.Helpers.Mail;

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
                        new Claim(ClaimTypes.Thumbprint, userDb.imageLink ),
                        new Claim(ClaimTypes.NameIdentifier, userDb.name == null ? userDb.email : userDb.name),
                        new Claim(ClaimTypes.Role, userDb.isAdmin ? "admin" : "user"),
                        new Claim("idUser", userDb.idUser.ToString()),
                        new Claim("imageLink", userDb.imageLink.ToString()),
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
                TempData["success"] = "Sua conta foi criada com sucesso!";
                user.password = BCrypt.Net.BCrypt.HashPassword(user.password);
                user.idUser = Guid.NewGuid();
                user.name = user.email;
                user.imageLink = "https://cdn-icons-png.flaticon.com/512/6596/6596121.png";
                user.createdDate = DateTime.Now;
                _context.Add(user);
                await _context.SaveChangesAsync();
                return View();
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
                .Include(p => p.Posts)
                .Include(a => a.Answers)
                .Include(r => r.Reactions)
                .ThenInclude(r => r.Post)
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
                if (string.IsNullOrEmpty(previousPassword))
                {
                    ViewBag.Message = "Senha atual vazia.";
                }
                else
                {
                    bool ispasswordOk = BCrypt.Net.BCrypt.Verify(previousPassword, user.password);
                    if (ispasswordOk)
                    {
                        if (!string.IsNullOrEmpty(newPassword1) && !string.IsNullOrEmpty(newPassword2) && newPassword1 == newPassword2 && newPassword1.Length >= 8)
                        {
                            user.password = BCrypt.Net.BCrypt.HashPassword(newPassword1);
                            await _context.SaveChangesAsync();
                            TempData["success"] = "Sua Senha foi alterada com sucesso!";                       
                            return View();
                        }
                        else
                        {
                            ViewBag.Message = "Confirmação de senha inválida";
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Senha atual errada.";
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> DeleteUser()
        {
            var user = _context.Users.First(excluir => excluir.idUser == Guid.Parse(User.FindFirstValue("idUser")));
            _context.Users.Remove(user);
            _context.SaveChanges();
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }


        public IActionResult RecuperarSenha()
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RecuperarSenha(ForgotPassword model)
        {
            if (ModelState.IsValid)
            {
                var emailExists = _context.Users.FirstOrDefault(o => o.email == model.email);
                if (emailExists != null)
                {
                    try
                    {
                        model.idForgotPass = Guid.NewGuid();
                        model.emailSent = true;
                        model.email = emailExists.email;
                        model.passwordResetToken = Guid.NewGuid();
                        model.created_date = DateTime.Now;
                        _context.Add(model);
                        _context.SaveChanges();

                        var apiKey = "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";
                        var client = new SendGridClient(apiKey);

                        var from = new EmailAddress("study2gether7789@gmail.com", "Study2Gether");
                        var to = new EmailAddress(model.email, emailExists.email);
                        var subject = "[Study2Gether] Recuperação de senha";
                        var plainTextContent = "Para recuperar sua senha, por favor entre no link: http://studytwogether-001-site1.itempurl.com/Users/Recuperacao/"+ model.passwordResetToken;
                        var htmlContent = "<p>Para recuperar sua senha, por favor entre no link: http://studytwogether-001-site1.itempurl.com/Users/Recuperacao/" + model.passwordResetToken + "</p>";
                        var message = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

                        var response = await client.SendEmailAsync(message);

                        if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                        {
                            Console.WriteLine("Email sent successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Failed to send email. Error: " + response.StatusCode);
                        }


                    }
                    catch (Exception ex)
                    {
                        TempData["success"] = ("An error occurred while sending the email: " + ex.Message);
                    }
                   
                }
            }
            TempData["success"] = "Caso o e-mail exista, você recebera um email com mais instruções em breve!";

            return View(model);
        }

        public IActionResult Recuperacao()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Recuperacao(Guid id, User user)
        {
            DateTime yesterday = DateTime.Today.AddDays(-1);
            var validatePasswordLength = user.password.Length >= 8;
            var recovery = _context.ForgotPassword.FirstOrDefault(o => o.passwordResetToken == id && o.created_date > yesterday );
            if (validatePasswordLength && recovery != null)
            {
                var usuario = _context.Users.FirstOrDefault(o => o.email == recovery.email);
                usuario.password = BCrypt.Net.BCrypt.HashPassword(user.password);
                _context.Remove(recovery);
                _context.SaveChanges();

                TempData["messages"] = "Senha alterada com Sucesso!";
            }
            else
            {

                TempData["messages"] = "Um erro ocorreu, tente recuperar sua senha novamente!";
            }
            return View();
        }
    }
}
