using ProjetQarma.Models;
using ProjetQarma.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ChoixSejour.Controllers
{
    public class LoginController : Controller
    {
        private Dal dal;

        BddContext _bddContext = new BddContext();

        public LoginController()
        {
            dal = new Dal();
        }
        public IActionResult Index()
        {
            UtilisateurViewModel viewModel = new UtilisateurViewModel { Authentifie = HttpContext.User.Identity.IsAuthenticated };
            if (viewModel.Authentifie)
            {
                viewModel.Utilisateur = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);

                return View(viewModel);
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(UtilisateurViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                Utilisateur utilisateur = dal.Authentifier(viewModel.Utilisateur.Mail, viewModel.Utilisateur.Password);
                if (utilisateur != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, utilisateur.Id.ToString()),
                         new Claim("Prenom" ,utilisateur.InfosPersos.Prenom.ToString()),
                      new Claim("Nom", utilisateur.InfosPersos.Nom.ToString()),
                       new Claim(ClaimTypes.Role, utilisateur.Role.ToString()),
                       new Claim(ClaimTypes.Email, utilisateur.Mail.ToString()),
                    };

                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                    var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });

                    HttpContext.SignInAsync(userPrincipal);

                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return Redirect("/Home/Demande");
                }
                ModelState.AddModelError("Utilisateur.Mail", "Mail et/ou mot de passe incorrect(s)");
            }
            return View(viewModel);
        }

        public IActionResult CreerCompte()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreerCompte(Utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {

                int id = dal.CreerUtilisateur(utilisateur.InfosPersos, utilisateur.Adresse, utilisateur.Mail, utilisateur.Telephone, utilisateur.SoldeBisous, utilisateur.Qarma, utilisateur.Password, utilisateur.TypeUtilisateur, utilisateur.CentreInteret, utilisateur.Propose, utilisateur.Role, utilisateur.ImagePath, utilisateur.Appartement);


                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, id.ToString()),
                     new Claim("Prenom", utilisateur.InfosPersos.Prenom.ToString()),
                      new Claim("Nom", utilisateur.InfosPersos.Nom.ToString()),
                };

                var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return Redirect("/");
            }
            return View(utilisateur);
        }

        public ActionResult Deconnexion()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult MesDemandes()
        {
            Utilisateur utilisateur = dal.ObtenirUtilisateur(Convert.ToInt32(User.FindFirst(ClaimTypes.Name).Value));
            List<Proposition> listePropositions = dal.ObtientTousLesPropositions().Where(p => p.InfosPersosId == utilisateur.InfosPersosId).ToList();
            List<Service> listeservices = dal.ObtientTousLesServices().Where(p => p.InfosPersosId == utilisateur.InfosPersosId).ToList();
            ServicePropositionViewModel spvm = new ServicePropositionViewModel { Propositions = listePropositions, Services = listeservices };
            return View(spvm);
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(Utilisateur model)
        {
            if (model.Mail != null)
            {
                Utilisateur utilisateurARetournerMdp = dal.ObtientTousLesUtilisateurs().Where(u => u.Mail == model.Mail).FirstOrDefault();
                if (utilisateurARetournerMdp == null)
                {
                    return View("Error");
                }
                else
                {
                    MailMessage mm = new MailMessage("projetqarma@gmail.com", utilisateurARetournerMdp.Mail);
                    mm.Subject = "Mot de passe oublié";
                    mm.Body = "Vous avez demandé la réinitialisation de votre mot de passe. Veuillez cliquer sur le lien suivant https://localhost:5001/login/ChangerMdp/" + utilisateurARetournerMdp.Id;
                    mm.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    NetworkCredential nc = new NetworkCredential("projetqarma@gmail.com", "vohyuconbhysobwe");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Send(mm);
                }
            }
            return View("ConfirmationForgotPassword");
        }

        public IActionResult ChangerMdp(int id)
        {
            Utilisateur utilisateurAChangerMdp = _bddContext.Utilisateur.Find(id);
            ForgotPasswordViewModel fpvm = new ForgotPasswordViewModel { Email = utilisateurAChangerMdp.Mail, userID = utilisateurAChangerMdp.Id };

            return View("ChangerMdp", fpvm);

        }
        [HttpPost]
        public IActionResult ChangerMdp(ForgotPasswordViewModel fpvm)
        {
            Utilisateur utilisateurAChangerMdp = _bddContext.Utilisateur.Find(fpvm.userID);
            if (fpvm.NewPassword == fpvm.NewPasswordConfirmation)
            {
                utilisateurAChangerMdp.Password = Dal.EncodeMD5(fpvm.NewPassword);
                this._bddContext.Utilisateur.Update(utilisateurAChangerMdp);
                this._bddContext.SaveChanges();
                return View("ConfirmationChangementPassword");
            } else
            {
                ModelState.AddModelError("ForgotPasswordViewModel.Mail", "Les password ne sont pas identiques");
                return View("ChangerMdp");
            }
        }
    }
}
