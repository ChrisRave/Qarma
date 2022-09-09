using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using System.Reflection.Metadata.Ecma335;

namespace ProjetQarma.Controllers
{
    public class AdministrationController : Controller
    {
        private IDal dal;

        BddContext _bddContext = new BddContext();


        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult AdminPage()
        {
            return View();
        }

        // ***** Methodes d'administration ***** // 

        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult BannirUser(int utilisateurABannirID)
        {
            Utilisateur utilisateurABannir = _bddContext.Utilisateur.Find(utilisateurABannirID);
            if (utilisateurABannir.Role != Role.SuperAdmin)
            {
                utilisateurABannir.Role = Role.Banned;
            }
            utilisateurABannir.Role = Role.Banned;
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult PromoteAdmin(int utilisateurToPromoteAdminID)
        {

            Utilisateur utilisateurToPromoteAdmin = _bddContext.Utilisateur.Find(utilisateurToPromoteAdminID);
            if (utilisateurToPromoteAdmin.Role != Role.SuperAdmin)
            {
                utilisateurToPromoteAdmin.Role = Role.Admin;
            }
            else
            {
                return View("Error");
            }
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult DemoteAdmin(int utilisateurToDemoteAdminID)
        {

            Utilisateur utilisateurToDemoteAdmin = _bddContext.Utilisateur.Find(utilisateurToDemoteAdminID);
            if (utilisateurToDemoteAdmin.Role != Role.SuperAdmin)
            {
                utilisateurToDemoteAdmin.Role = Role.User;
            }
            else
            {
                return View("Error");
            }
            return View();
        }
        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerServiceAdmin(int serviceASupprimerID)
        {

            dal.SupprimerService(serviceASupprimerID);
            return View();
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        public IActionResult SupprimerPropositionAdmin (int propositionASupprimerID)
        {
            dal.SupprimerProposition(propositionASupprimerID);   
            return View();

        }
    }
}