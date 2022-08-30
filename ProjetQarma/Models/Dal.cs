using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public List<Utilisateur> ObtientTousLesUtilisateurs()
        { //mettre include pour charger clés étrangéres
            return _bddContext.Utilisateur.Include(u=>u.InfosPersos).ToList();
        }
        public int CreerUtilisateur(String nom, String prenom, String adresse, String mail, String telephone, int qarma, TypeUtilisateur typeUtilisateur)
        {
            InfosPersos infosPersos = new InfosPersos() { Nom = nom, Prenom = prenom };
            Utilisateur utilisateur = new Utilisateur()
            {
                InfosPersos = infosPersos,
                Adresse = adresse,
                Mail = mail,
                Telephone = telephone,
                Qarma = qarma,
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

        public int CreerUtilisateur(InfosPersos infosPersos, string adresse, string mail, string telephone, int qarma, TypeUtilisateur typeUtilisateur)
        {
            throw new NotImplementedException();
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
    }
}
