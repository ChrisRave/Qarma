using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;
using static ProjetQarma.Models.Service;
namespace ProjetQarma.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Landing()
        {
            return View();
        }
            public IActionResult Service()
        {
            InfosPersos infosPersos = new InfosPersos { Nom = "Dupont", Prenom = "Jean" };
            Utilisateur utilisateur = new Utilisateur { InfosPersos = infosPersos, Adresse = " 3 Rue des Peupliers, 75014 Paris", Mail = "Jean.dupont@gmail.com", Telephone = "01341564", Qarma = 2, TypeUtilisateur = TypeUtilisateur.Consommateur };
            Bisous bisous = new Bisous() { Id = 1, MontantBisous = 10 };
            Service service = new Service { Id = 1, TypeService = TypeService.Equipement, Bisous = bisous };
            ServiceViewModels svm = new ServiceViewModels
            {
                Utilisateur = utilisateur,
                Service = service,
            };
            return View(svm);
        }
    }
}







