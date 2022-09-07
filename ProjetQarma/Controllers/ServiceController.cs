﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static ProjetQarma.Models.Service;
namespace ProjetQarma.Controllers
{
    public class ServiceController : Controller
    {

        private IDal dal;

        BddContext _bddContext = new BddContext();

        private IWebHostEnvironment _webEnv;
        public ServiceController(IWebHostEnvironment environment)
        {
            _webEnv = environment;

            this.dal = new Dal();
        }

        /*    public ActionResult Index()
            {
                List<Service> listeServices = dal.ObtientTousLesServices();
                return View(listeServices);
            }*/

        public async Task<IActionResult> Index(string searchString)
        {
            var services = from m in _bddContext.Services select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                services = services.Where(s => s.Description!.Contains(searchString) || s.Titre!.Contains(searchString)); //|| s.TypeService.ToString().Contains(searchString));
            }

            return View(await services.ToListAsync());
        }

        public ActionResult Service()
        {
            return View();
        }


        //Méthodes Création de services 
        public ActionResult Creer()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Creer(Service service)
        {
            if (!ModelState.IsValid)
                return View(service);

            if (service.Image != null)
            {
                if (service.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, service.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        service.Image.CopyTo(fileStream);
                    }

                    dal.CreerService(service.Id, service.TypeService, service.MontantBisous, service.Description, service.Titre, service.InfosPersosId, "/images/" + service.Image.FileName);

                }
            }


            else
            {
                dal.CreerService(service.Id, service.TypeService, service.MontantBisous, service.Description,service.Titre, service.InfosPersosId, service.ImagePath);

            }

            return RedirectToAction("Index");
        }


        public ActionResult Modifier(int? id)
        {

            if (id.HasValue)
            {
                Service service = dal.ObtientTousLesServices().FirstOrDefault(r => r.Id == id.Value);
                if (service == null)
                    return View("Error");

                return View(service);
            }
            else
                return NotFound();

        }

        [HttpPost]
        public ActionResult Modifier(Service service)
        {
            if (!ModelState.IsValid)
                return View(service);

            if (service.Image != null)
            {
                if (service.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, service.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        service.Image.CopyTo(fileStream);
                    }

                    dal.ModifierService(service.Id, service.TypeService, service.MontantBisous, service.Description, service.Titre, "/images/" + service.Image.FileName);

                }
            }
            else
            {
                dal.ModifierService(service.Id, service.TypeService, service.MontantBisous, service.Description,service.Titre, service.ImagePath);
            }
            return RedirectToAction("Index");
        }


        public ActionResult Supprimer(int id)
        {
            dal.SupprimerService(id);
            return RedirectToAction("Index");
        }






        //Méthodes Proposition de services 
        /*  public ActionResult Proposition()
          {
              Utilisateur utilisateur = dal.ObtenirUtilisateur(Convert.ToInt32(User.FindFirst(ClaimTypes.Name).Value));
              List<Proposition> listePropositions = dal.ObtientTousLesPropositions().Where(p=>p.InfosPersosId == utilisateur.InfosPersosId).ToList();
              return View(listePropositions);
          }*/


        public async Task<IActionResult> Proposition(string searchString)
        {
            var services = from m in _bddContext.Propositions select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                services = services.Where(s => s.Description!.Contains(searchString)); //|| s.TypeService.ToString().Contains(searchString));
            }

            return View(await services.ToListAsync());
        }

        public ActionResult Proposer()
        {
            return View();
        }


        [HttpPost]

        public ActionResult Proposer(Proposition proposition)
        {
            if (!ModelState.IsValid)
                return View(proposition);

            if (proposition.Image != null)
            {
                if (proposition.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, proposition.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        proposition.Image.CopyTo(fileStream);
                    }

                    dal.ProposerService(proposition.Id, proposition.TypeService, proposition.MontantBisous, proposition.Description,proposition.Titre, proposition.InfosPersosId, "/images/" + proposition.Image.FileName);

                }
            }


            else
            {
                dal.ProposerService(proposition.Id, proposition.TypeService, proposition.MontantBisous, proposition.Description,proposition.Titre, proposition.InfosPersosId, proposition.ImagePath);

            }

            return RedirectToAction("Proposition");

        }


        public ActionResult ModifierProposition(int? id)
        {

            if (id.HasValue)
            {
                Proposition service = dal.ObtientTousLesPropositions().FirstOrDefault(r => r.Id == id.Value);
                if (service == null)
                    return View("Error");

                return View(service);
            }
            else
                return NotFound();

        }

        [HttpPost]
        public ActionResult ModifierProposition(Proposition service)
        {
            if (!ModelState.IsValid)
                return View(service);

            if (service.Image != null)
            {
                if (service.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, service.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        service.Image.CopyTo(fileStream);
                    }

                    dal.ModifierProposition(service.Id, service.TypeService, service.MontantBisous, service.Description, "/images/" + service.Image.FileName);

                }
            }
            else
            {
                dal.ModifierProposition(service.Id, service.TypeService, service.MontantBisous, service.Description, service.ImagePath);
            }

            return RedirectToAction("Proposition");
        }
        public IActionResult PropositionDetail(int id)

        {
            Utilisateur utilisateur = dal.ObtientTousLesUtilisateurs().FirstOrDefault(r => r.Id == id);
            Proposition service = dal.ObtientTousLesPropositions().FirstOrDefault(r => r.Id == id);
            PropositionViewModel pvm = new PropositionViewModel { Proposition = service, Utilisateur = utilisateur };
            return View(pvm);
        }

        public ActionResult SupprimerProposition(int id)
        {
            dal.SupprimerProposition(id);
            return RedirectToAction("Proposition");
        }
    }

}








