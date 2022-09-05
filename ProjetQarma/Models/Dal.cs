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
            return _bddContext.Utilisateur.Include(u=>u.InfosPersos).ToList();
        }
        public int CreerUtilisateur(InfosPersos infosPersos, String adresse, String mail, String telephone, int qarma, string password, TypeUtilisateur typeUtilisateur)
        {
            string motDePasse = EncodeMD5(password);
           
            Utilisateur utilisateur = new Utilisateur()
            {
                InfosPersos = infosPersos,
                Adresse = adresse,
                Mail = mail,
                Telephone = telephone,
                Qarma = qarma,
                Password = motDePasse,
                TypeUtilisateur = typeUtilisateur
            };
            _bddContext.Utilisateur.Add(utilisateur);
            _bddContext.SaveChanges();
            return utilisateur.Id;
        }
        public void ModifierUtilisateur(int id, InfosPersos infosPersos, String adresse, String mail, String telephone, int qarma, TypeUtilisateur typeUtilisateur)
        {
            Utilisateur utilisateur = _bddContext.Utilisateur.Find(id); if (utilisateur != null)
            {
                utilisateur.InfosPersos = infosPersos;
                utilisateur.Adresse = adresse;
                utilisateur.Mail = mail;
                utilisateur.Telephone = telephone;
                utilisateur.Qarma = qarma;
                utilisateur.TypeUtilisateur = typeUtilisateur; _bddContext.SaveChanges();
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
            Utilisateur utilisateur = this._bddContext.Utilisateur.FirstOrDefault(u => u.Mail == mail && u.Password == motDePasse);
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

        public void CreerService(int id, TypeService typeservice, int montantBisous, string description)
        {

            Service serviceToAdd = new Service
            {
                Id = id,
                TypeService = typeservice,
                MontantBisous = montantBisous,
                Description = description
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

        public void ModifierService(int id, TypeService typeservice, int montantBisous, string description)
        {
            Service serviceToUpdate = this._bddContext.Services.Find(id);
            if (serviceToUpdate != null)
            {
                serviceToUpdate.TypeService = typeservice;
                serviceToUpdate.MontantBisous = montantBisous;
                serviceToUpdate.Description = description;

                this._bddContext.SaveChanges();
            }
        }

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

        //Méthodes pour les propositions
        public List<Proposition> ObtientTousLesPropositions()
        {
            List<Proposition> listePropositions = this._bddContext.Propositions.ToList();
            return listePropositions;
        }

        public void ProposerService(int id, TypeService typeservice, int montantBisous, string description)
        {

            Proposition propositionToAdd = new Proposition
            {
                Id = id,
                TypeService = typeservice,
                MontantBisous = montantBisous,
                Description = description
            };
            if (id != 0)
            {
                propositionToAdd.Id = id;
            }

            this._bddContext.Propositions.Add(propositionToAdd);
            this._bddContext.SaveChanges();
        }
    }
}
