using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using XSystem.Security.Cryptography;

namespace ProjetQarma.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext; public Dal()
        {
            _bddContext = new BddContext();
        }
        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }
        public void Dispose()
        {
            _bddContext.Dispose();
        }
        //Méthodes pour les utilisateurs

        public List<Utilisateur> ObtientTousLesUtilisateurs()
        { //mettre include pour charger clés étrangéres
            return _bddContext.Utilisateur.Include(u => u.InfosPersos).ToList();
        }

        public int CreerUtilisateur(InfosPersos infosPersos, String adresse, String mail, String telephone, int soldeBisous, int qarma, string password,
            TypeUtilisateur typeUtilisateur, string centreInteret, string propose,Role role, string imagePath, string appartement)

        {
            string motDePasse = EncodeMD5(password);

            Utilisateur utilisateur = new Utilisateur()
            {
                InfosPersos = infosPersos,
                Adresse = adresse,
                Mail = mail,
                Telephone = telephone,
                SoldeBisous = soldeBisous,
                Qarma = qarma,
                Password = motDePasse,
                TypeUtilisateur = typeUtilisateur,
                CentreInteret = centreInteret,
                Propose = propose,
                Role = Role.User,
                ImagePath = imagePath,
                Appartement = appartement);

            };
            _bddContext.Utilisateur.Add(utilisateur);
            _bddContext.SaveChanges();
            return utilisateur.Id;
        }



        public void ModifierUtilisateur(int id, InfosPersos infosPersos, String adresse, String mail, String telephone, int soldeBisous, int qarma, TypeUtilisateur typeUtilisateur, string centreInteret
            , string propose,Role role, string imagePath, string appartement)

        {
            Utilisateur utilisateur = _bddContext.Utilisateur.Find(id); if (utilisateur != null)
            {
                utilisateur.InfosPersos = infosPersos;
                utilisateur.Adresse = adresse;
                utilisateur.Mail = mail;
                utilisateur.Telephone = telephone;
                utilisateur.SoldeBisous = soldeBisous;
                utilisateur.Qarma = qarma;
                utilisateur.TypeUtilisateur = typeUtilisateur;
                utilisateur.CentreInteret = centreInteret;
                utilisateur.Propose = propose;
                utilisateur.Role = role;
                utilisateur.ImagePath = imagePath;
                utilisateur.Appartement = appartement;

                _bddContext.SaveChanges();
            };
        }

        /* public int CreerUtilisateur(InfosPersos infosPersos, string adresse, string mail, string telephone, int qarma, TypeUtilisateur typeUtilisateur)
         {
             throw new NotImplementedException();
         } */
        // Méthodes login // 

        public Utilisateur Authentifier(string mail, string password)
        {
            string motDePasse = EncodeMD5(password);
            Utilisateur utilisateur = this._bddContext.Utilisateur.Include(u => u.InfosPersos).FirstOrDefault(u => u.Mail == mail && u.Password == motDePasse);
            return utilisateur;
        }

        public Utilisateur ObtenirUtilisateur(int id)
        {
            return this._bddContext.Utilisateur.Include(u => u.InfosPersos).FirstOrDefault(u => u.Id == id);
        }

        public Utilisateur ObtenirUtilisateur(string idStr)
        {
            int id;
            if (int.TryParse(idStr, out id))
            {
                return this.ObtenirUtilisateur(id);
            }
            return null;
        }

        public static string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "ChoixResto" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        //Méthodes pour les services
        public List<Service> ObtientTousLesServices()
        {
            List<Service> listeServices = this._bddContext.Services.ToList();
            return listeServices;
        }


        public void CreerService(int id, TypeService typeservice, int montantBisous, int montantQarma, string description, string Imagepath, string titre, int infosPersosId)
        {

            Service serviceToAdd = new Service
            {
                Id = id,
                TypeService = typeservice,
                MontantBisous = montantBisous,
                MontantQarma = montantQarma,
                Description = description,
                ImagePath = Imagepath,
                Titre = titre,
                InfosPersosId = infosPersosId,

            };
            if (id != 0)
            {
                serviceToAdd.Id = id;
            }
            
           
            this._bddContext.Services.Add(serviceToAdd);
            this._bddContext.SaveChanges();
        }


        public void SupprimerService(int id)
        {
            Service serviceToDelete = this._bddContext.Services.Find(id);
            this._bddContext.Services.Remove(serviceToDelete);
            this._bddContext.SaveChanges();
        }

        public void SupprimerService(string nom)
        {
            Service serviceToDelete = this._bddContext.Services.Where(t => t.Description == nom).FirstOrDefault();
            if (serviceToDelete != null)
            {
                this._bddContext.Services.Remove(serviceToDelete);
                this._bddContext.SaveChanges();
            }
        }

        public void ModifierService(int id, TypeService typeservice, int montantBisous, int montantQarma, string description, string titre, string imagePath)
        {
            Service serviceToUpdate = this._bddContext.Services.Find(id);
            if (serviceToUpdate != null)
            {
                serviceToUpdate.TypeService = typeservice;
                serviceToUpdate.MontantBisous = montantBisous;
                serviceToUpdate.MontantQarma = montantQarma;
                serviceToUpdate.Description = description;
                serviceToUpdate.Titre = titre;
                serviceToUpdate.ImagePath = imagePath;

                this._bddContext.SaveChanges();
            }
        }



        //Méthodes pour les propositions
        public List<Proposition> ObtientTousLesPropositions()
        {
            List<Proposition> listePropositions = this._bddContext.Propositions.ToList();
            return listePropositions;
        }

        public void ProposerService(int id, TypeService typeservice, int montantBisous, int montantQarma, string description, string titre, int infosPersosId, string imagePath)
        {

            Proposition propositionToAdd = new Proposition
            {
                Id = id,
                TypeService = typeservice,
                MontantBisous = montantBisous,
                MontantQarma = montantQarma,
                Description = description,
                Titre = titre,
                InfosPersosId = infosPersosId,
                ImagePath = imagePath,
                DateTime = DateTime.Now
            };
            if (id != 0)
            {
                propositionToAdd.Id = id;
            }

            this._bddContext.Propositions.Add(propositionToAdd);
            this._bddContext.SaveChanges();
        }

        public Utilisateur ObtenirProposition(string idStr)
        {
            throw new NotImplementedException();
        }


        public void ModifierProposition(int id, TypeService typeservice, int montantBisous, int montantQarma, string description, string imagePath)
        {
            Proposition serviceToUpdate = this._bddContext.Propositions.Find(id);
            if (serviceToUpdate != null)
            {
                serviceToUpdate.TypeService = typeservice;
                serviceToUpdate.MontantBisous = montantBisous;
                serviceToUpdate.MontantQarma = montantQarma;
                serviceToUpdate.Description = description;
                serviceToUpdate.ImagePath = imagePath;

                this._bddContext.SaveChanges();
            }
        }

        public void ModifierProposition(Proposition service)
        {
            throw new NotImplementedException();
        }

        public void SupprimerProposition(int id)
        {
            Proposition serviceToDelete = this._bddContext.Propositions.Find(id);
            this._bddContext.Propositions.Remove(serviceToDelete);
            this._bddContext.SaveChanges();
        }

        public void SupprimerProposition(string nom)
        {
            Proposition serviceToDelete = this._bddContext.Propositions.Where(t => t.Description == nom).FirstOrDefault();
            if (serviceToDelete != null)
            {
                this._bddContext.Propositions.Remove(serviceToDelete);
                this._bddContext.SaveChanges();
            }
        }


        //Fonctionnalités à développer
        public List<Qarma> ObtientTousLesQarma()
        {
            throw new NotImplementedException();
        }

        public int CreerQarma(int nombreService, string badge)
        {
            throw new NotImplementedException();
        }

        public void ModifierQarma(int id, int nombreService, string badge)
        {
            throw new NotImplementedException();
        }
        //Méthodes pour les échanges de bisous et modification de Qarma 

        public void TransfererBisous(int utilisateurADebiterID, int utilisateurACrediterID, int serviceID)
        {
            Utilisateur utilisateurADebiter = _bddContext.Utilisateur.Find(utilisateurADebiterID);
            Utilisateur utilisateurACrediter = _bddContext.Utilisateur.Find(utilisateurACrediterID);
            Service service = _bddContext.Services.Find(serviceID);

            utilisateurADebiter.SoldeBisous = utilisateurADebiter.SoldeBisous - service.MontantBisous;
            utilisateurACrediter.SoldeBisous = utilisateurACrediter.SoldeBisous + service.MontantBisous;

        }

        public void AjouterQarma(int utilisateurACrediterID, int serviceID)
        {
            Utilisateur utilisateurACrediter = _bddContext.Utilisateur.Find(utilisateurACrediterID);
            Service service = _bddContext.Services.Find(serviceID);

            utilisateurACrediter.Qarma = utilisateurACrediter.Qarma + service.MontantQarma;
        }


        

        public void ModifierUtilisateur(int id, InfosPersos infosPersos, string adresse, string mail, string telephone, int soldeBisous, int qarma, TypeUtilisateur typeUtilisateur, string CentreInteret, string Propose,Role role, string Imagepath) // appartement? 
        {
            throw new NotImplementedException();
        }

    }
}
