using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Threading.Tasks;
namespace ProjetQarma.Controllers
{
    public class AdministrationController : Controller
    {
        private IDal dal;
        BddContext _bddContext = new BddContext();
        //Méthode affichage des pages

        private IWebHostEnvironment _webEnv;
        public AdministrationController(IWebHostEnvironment environment)
        {
            _webEnv = environment;

            this.dal = new Dal();
        }

        public ActionResult Index()
        {
          
            return View();
        }
        public IActionResult servicePage()
        {
            List<Service> listeServices = dal.ObtientTousLesServices();
            return View(listeServices);
        }


        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult offrePage()
        {
            List<Proposition> listePropositions = dal.ObtientTousLesPropositions();
            return View(listePropositions);
        }
        public IActionResult userPage()
        {
            List<Utilisateur> listeUtilisateur = dal.ObtientTousLesUtilisateurs();
            return View(listeUtilisateur);
        }


        // ***** Methodes d'administration ***** //
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult BannirUser(int utilisateurABannirID)
        {
            Utilisateur utilisateurABannir = _bddContext.Utilisateur.Find(utilisateurABannirID);
            if (utilisateurABannir.Role != Role.SuperAdmin && utilisateurABannir.Role != Role.Admin)
            {
                utilisateurABannir.Role = Role.Banned;
          
            }
        
            this._bddContext.SaveChanges();

            return View("Index");
        }
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult PromoteAdmin(int utilisateurToPromoteAdminID)
        {
            Utilisateur utilisateurToPromoteAdmin = _bddContext.Utilisateur.Find(utilisateurToPromoteAdminID);
            if (utilisateurToPromoteAdmin.Role != Role.SuperAdmin)
            {
                utilisateurToPromoteAdmin.Role = Role.Admin;
                this._bddContext.SaveChanges();
            }
            else
            {
                return View("Error");
            }
            return View("Index");
        }
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult DemoteAdmin(int utilisateurToDemoteAdminID)
        {
            Utilisateur utilisateurToDemoteAdmin = _bddContext.Utilisateur.Find(utilisateurToDemoteAdminID);
            if (utilisateurToDemoteAdmin.Role != Role.SuperAdmin)
            {
                utilisateurToDemoteAdmin.Role = Role.User;
                this._bddContext.SaveChanges();

            }
            else
            {
                return View("Error");
            }
            return View("Index");
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerServiceAdmin(int serviceASupprimerID)
        {
            dal.SupprimerService(serviceASupprimerID);
            return View("Index");
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerPropositionAdmin(int propositionASupprimerID)
        {
            dal.SupprimerProposition(propositionASupprimerID);
            return View("Index");
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerUserAdmin(int userASupprimerID)
        {
            dal.SupprimerService(userASupprimerID);
            return View("Index");
        }
    }

}