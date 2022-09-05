using System;
using System.Collections.Generic;
namespace ProjetQarma.Models
{
    public interface IDal : IDisposable
    {        //*****Classe Utilisateur*****
        void DeleteCreateDatabase();

        List<Utilisateur> ObtientTousLesUtilisateurs();

        int CreerUtilisateur(InfosPersos infosPersos, String adresse, String mail, String telephone, int qarma, string password, TypeUtilisateur typeUtilisateur);        //*****Classe Qarma*****
        void ModifierUtilisateur(int id, InfosPersos infosPersos, String adresse, String mail, String telephone, int qarma, TypeUtilisateur typeUtilisateur);

        //***** Login *****//
        Utilisateur Authentifier(string mail, string password);
        Utilisateur ObtenirUtilisateur(int id);
        Utilisateur ObtenirUtilisateur(string idStr);
        //***** Fin login *****//
        List<Service> ObtientTousLesServices();

        void CreerService(int id, TypeService typeservice, int montantBisous, string description);

        void SupprimerService(string nom);

        void ModifierService(int id, TypeService typeservice, int montantbisous, String description);

        void ModifierProposition(int id, TypeService typeservice, int montantBisous, string description);

        void ModifierProposition(Proposition service);
        List<Qarma> ObtientTousLesQarma();
        int CreerQarma(int nombreService, string badge);
        void ModifierQarma(int id, int nombreService, string badge);


        //***** Proposition *****//
        List<Proposition> ObtientTousLesPropositions();

        void ProposerService(int id, TypeService typeservice, int montantBisous, string description);

        //***** FIN Proposition *****//
    }
}
