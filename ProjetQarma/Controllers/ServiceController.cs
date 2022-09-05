using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;
using System.Collections.Generic;
using System.Linq;
using static ProjetQarma.Models.Service;
namespace ProjetQarma.Controllers
{
    public class ServiceController : Controller
    {

        private IDal dal;

        private IWebHostEnvironment _webEnv;
        public ServiceController(IWebHostEnvironment environment)
        {
            _webEnv = environment;
            this.dal = new Dal();
        }

        public ActionResult Index()
        {
            List<Service> listeServices = dal.ObtientTousLesServices();
            return View(listeServices);
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
            dal.CreerService(service.Id, service.TypeService, service.MontantBisous, service.Description);
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
            dal.ModifierService(service.Id, service.TypeService, service.MontantBisous, service.Description);
            return RedirectToAction("Index");
        }


        //Méthodes Proposition de services 
        public ActionResult Proposition()
        {
            List<Proposition> listePropositions = dal.ObtientTousLesPropositions();
            return View(listePropositions);
        }
        public ActionResult Proposer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Proposer(Proposition proposition)
        {
            dal.ProposerService(proposition.Id, proposition.TypeService, proposition.MontantBisous, proposition.Description);
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
            dal.ModifierProposition(service.Id, service.TypeService, service.MontantBisous, service.Description);
            return RedirectToAction("Proposition");
        }
        public IActionResult PropositionDetail()
        {
           
            return View();


        }
    }

}








