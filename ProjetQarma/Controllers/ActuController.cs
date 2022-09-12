
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjetQarma.Models;
using System.Collections.Generic;
using System.IO;

namespace ProjetQarma.Controllers
{
    public class ActuController : Controller
    {


        private IDal dal;

        BddContext _bddContext = new BddContext();

        private IWebHostEnvironment _webEnv;


        public ActuController(IWebHostEnvironment environment)
        {
            _webEnv = environment;

            this.dal = new Dal();
        }


        public ActionResult Index()
           {
               List<Actu> listeActus = dal.ObtientTousLesActus();
               return View(listeActus);
           }

        public ActionResult CreerActu()
        {
            return View();
        }

       /* [Authorize(Roles = "Admin")]*/

        [HttpPost]

        public ActionResult CreerActu(Actu actu)
        {
            if (!ModelState.IsValid)
                return View(actu);

            if (actu.Image != null)
            {
                if (actu.Image.Length != 0)
                {
                    string uploads = Path.Combine(_webEnv.WebRootPath, "images");
                    string filePath = Path.Combine(uploads,actu.Image.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                       actu.Image.CopyTo(fileStream);
                    }

                    dal.CreerActu(actu.Id, actu.Titre, actu.Categorie, actu.Description, "/images/" + actu.Image.FileName);


                }
            }

            else
            {

                dal.CreerActu(actu.Id, actu.Titre, actu.Categorie, actu.Description, actu.ImagePath);

            }

            return RedirectToAction("Index");
        }



        public ActionResult SupprimerActu(int id)
        {
            dal.SupprimerActu(id);
            return RedirectToAction("Index");
        }

    }
}

