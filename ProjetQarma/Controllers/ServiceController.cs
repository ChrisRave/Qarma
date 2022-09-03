using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using ProjetQarma.ViewModels;
using System.Collections.Generic;
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
        public IActionResult PropositionDetail()
        {
            return View();
        }



    }
}







