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
        public async Task<IActionResult> servicePage(string searchString)
        {
            var services = from m in _bddContext.Services select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                services = services.Where(s => s.Description!.Contains(searchString) || s.Titre!.Contains(searchString)); //|| s.TypeService.ToString().Contains(searchString));
            }
            services = services.OrderByDescending(s => s.DateTime);
            return View(await services.ToListAsync());
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public async Task<IActionResult> offrePage(string searchString)
        {
            var services = from m in _bddContext.Propositions select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                services = services.Where(s => s.Description!.Contains(searchString) || s.Titre!.Contains(searchString)); //|| s.TypeService.ToString().Contains(searchString));
            }
            services = services.OrderByDescending(s => s.DateTime);
            return View(await services.ToListAsync());
        }
        public async Task<IActionResult> userPage(string searchString)
        {
            var utilisateurs = from m in _bddContext.Utilisateur select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                utilisateurs = utilisateurs.Where(s => s.InfosPersos.Nom!.Contains(searchString) || s.InfosPersos.Prenom!.Contains(searchString)).Include(a => a.InfosPersos); //|| s.TypeService.ToString().Contains(searchString));
            }
            utilisateurs = utilisateurs.OrderByDescending(s => s.InfosPersos.Nom);
            return View(await utilisateurs.ToListAsync());
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

            return View("ConfirmationChangementRole");
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
            return View("ConfirmationChangementRole");
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
            return View("ConfirmationChangementRole");
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerServiceAdmin(int serviceASupprimerID)
        {
            dal.SupprimerService(serviceASupprimerID);
            return View();
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerPropositionAdmin(int propositionASupprimerID)
        {
            dal.SupprimerProposition(propositionASupprimerID);
            return View();
        }
    }

}