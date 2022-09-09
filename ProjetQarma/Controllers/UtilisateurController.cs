using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using System;
using System.Linq;
using System.Security.Claims;

namespace projetQarma.Controllers
{
    public class UtilisateurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ModifierUtilisateur(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Utilisateur utilisateur = dal.ObtientTousLesUtilisateurs().Where(r => r.Id == id).FirstOrDefault();
                    if (utilisateur == null)
                    {
                        return View("Error");
                    }
                    return View(utilisateur);
                }
            }
            return View("Error");
        }
        [HttpPost]
        public IActionResult ModifierUtilisateur(Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
                return View(utilisateur); if (utilisateur.Id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifierUtilisateur(utilisateur.Id,
                        utilisateur.InfosPersos,
                        utilisateur.Adresse,
                        utilisateur.Mail,
                        utilisateur.Telephone,
                        utilisateur.SoldeBisous,
                        utilisateur.Qarma,
                        utilisateur.TypeUtilisateur,
                        utilisateur.CentreInteret,
                        utilisateur.Propose,
                        utilisateur.ImagePath,
                        utilisateur.Appartement);
                    return RedirectToAction("ModifierUtilisateur", new { @id = utilisateur.Id });
                }
            }
            else
            {
                return View("Error");
            }
        }
        public int getSoldeBisous(string id)
        {
            Dal dal = new Dal();
            Utilisateur utilisateur = dal.ObtenirUtilisateur(Convert.ToInt32(id));
            return utilisateur.SoldeBisous;

        }
        public int getSoldeQarma(string id)
        {
            Dal dal = new Dal();
            Utilisateur utilisateur = dal.ObtenirUtilisateur(Convert.ToInt32(id));
            return utilisateur.Qarma;

        }
    }
}


