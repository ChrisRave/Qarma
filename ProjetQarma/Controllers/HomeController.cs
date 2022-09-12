using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetQarma.Controllers
{
    public class HomeController : Controller

    {

        private Dal dal;
        public HomeController()
        {
            dal = new Dal();
        }
        // GET: /<controller>/
        public IActionResult Landing()
        {
            // faire référence à viewModels(Home == > nom de la view)
            InfosPersos infosPersos = new InfosPersos { Nom = "Dupont", Prenom = "Jean" };
            Utilisateur utilisateur = new Utilisateur { InfosPersos = infosPersos, Adresse = " 3 Rue des Peupliers, 75014 Paris", Mail = "Jean.dupont@gmail.com", Telephone = "01341564", Qarma = 2, TypeUtilisateur = TypeUtilisateur.Consommateur };


            Service service = new Service { Id = 1, TypeService = TypeService.Equipement, MontantBisous = 10 };
            AccueilViewModel avm = new AccueilViewModel
            {
                Utilisateur = utilisateur,
                Service = service,
            };
            return View(avm); //retourner la view crée (HomeViewModel)
        }

        public IActionResult Demande()
        {
            UtilisateurViewModel viewModel = new UtilisateurViewModel { Authentifie = HttpContext.User.Identity.IsAuthenticated };
            if (viewModel.Authentifie)
            {
                viewModel.Utilisateur = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);
                return View(viewModel);
            }
            return View(viewModel);

        }
        public IActionResult Accueil()
        {
            return View();
        }
        public IActionResult Proposition()
        {
            return View();
        }




    }
}
