using System;
using System.Collections.Generic;
namespace ProjetQarma.Models
{
    public interface IDal : IDisposable
    {        //*****Classe Utilisateur*****
        void DeleteCreateDatabase();

        List<Utilisateur> ObtientTousLesUtilisateurs();

        int CreerUtilisateur(InfosPersos infosPersos, string adresse, string mail, string telephone, int soldeBisous, int qarma, string password, TypeUtilisateur typeUtilisateur, string CentreInteret, string Propose, string Imagepath);        
        void ModifierUtilisateur(int id, InfosPersos infosPersos, string adresse, string mail, string telephone, int soldeBisous, int qarma, TypeUtilisateur typeUtilisateur, string CentreInteret, string Propose, string Imagepath);

        //***** Login *****//
        Utilisateur Authentifier(string mail, string password);
        Utilisateur ObtenirUtilisateur(int id);
        Utilisateur ObtenirProposition(string idStr);
        //***** Fin login *****//


        //***** Service*****//
        List<Service> ObtientTousLesServices();


        void CreerService(int id, TypeService typeservice, int montantBisous,int montantQarma, string description, string Imagepath, string titre, int infosPersosId);

        void SupprimerService(string nom);

        void SupprimerService(int id);

        void ModifierService(int id, TypeService typeservice, int montantBisous,int montantQarma, string description, string titre, string imagePath);

        //*****FIN  Service*****//


        //***** Proposition *****//
        List<Proposition> ObtientTousLesPropositions();

        void ProposerService(int id, TypeService typeservice, int montantBisous, int montantQarma, string description, string titre, int infosPersosId, string imagePath);


        void ModifierProposition(int id, TypeService typeservice, int montantBisous, int montantQarma, string description, string imagePath);

        void ModifierProposition(Proposition service);



        void SupprimerProposition(int id);

        public void SupprimerProposition(string nom);

        //***** FIN Proposition *****//


        //*****Classe Qarma*****
        List<Qarma> ObtientTousLesQarma();
        int CreerQarma(int nombreService, string badge);
        void ModifierQarma(int id, int nombreService, string badge);

        //***** Modifier solde bisous + modifier Qarma *****//
        public void TransfererBisous(int utilisateurADebiterID, int utilisateurACrediterID, int serviceID);

        public void AjouterQarma(int utilisateurACrediterID, int serviceID);
    }

}
        
    

