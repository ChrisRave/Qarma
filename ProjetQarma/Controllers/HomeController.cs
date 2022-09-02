using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetQarma.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Landing()
        {
           // faire référence à viewModels(Home == > nom de la view)
            InfosPersos infosPersos = new InfosPersos { Nom = "Dupont", Prenom = "Jean" };
            Utilisateur utilisateur = new Utilisateur { InfosPersos = infosPersos, Adresse = " 3 Rue des Peupliers, 75014 Paris", Mail = "Jean.dupont@gmail.com", Telephone = "01341564", Qarma = 2, TypeUtilisateur = TypeUtilisateur.Consommateur };
           
                 
            Service service = new Service { Id = 1, TypeService = TypeService.Equipement, MontantBisous=10 };
             AccueilViewModel avm = new AccueilViewModel
            {
                Utilisateur = utilisateur,
                Service = service,
            }; 
            return View(avm); //retourner la view créer (HomeViewModel)
        }
        public IActionResult Demande()
        {
            return View();
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
