using System;
using System.Collections.Generic;
namespace ProjetQarma.Models
{
    public interface IDal : IDisposable
    {        //*****Classe Utilisateur*****
        void DeleteCreateDatabase();

        List<Utilisateur> ObtientTousLesUtilisateurs();

        int CreerUtilisateur(InfosPersos infosPersos, String adresse, String mail, String telephone, int qarma, TypeUtilisateur typeUtilisateur);        //*****Classe Qarma*****
        List<Qarma> ObtientTousLesQarma();
        int CreerQarma(int nombreService, string badge);
        void ModifierQarma(int id, int nombreService, string badge);
    }
}
