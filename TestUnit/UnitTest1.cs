using System;
using System.Collections.Generic;
using Xunit;
using ProjetQarma.Models;


namespace TestUnit
{
    /*public class UnitTest1
    {
        [Fact]
        public void Creation_Utilisateur_Verification()
        {

            using (Dal dal = new Dal())
            {
                dal.DeleteCreateDatabase(); dal.CreerUtilisateur("Dupont", "Jean", " 3 Rue des Peupliers, 75014 Paris", "Jean.dupont@gmail.com", "01341564", 2, TypeUtilisateur.Consommateur); List<Utilisateur> utilisateurs = dal.ObtientTousLesUtilisateurs();
                Assert.NotNull(utilisateurs);
                Assert.Single(utilisateurs);
                Assert.Equal("Dupont", utilisateurs[0].InfosPersos.Nom);
                Assert.Equal("Jean", utilisateurs[0].InfosPersos.Prenom);
            }
        }

        [Fact]
        public void Modifier_Utilisateur_Verification()
        {
            using (Dal dal = new Dal())
            {
                dal.DeleteCreateDatabase(); int id = dal.CreerUtilisateur("Dupont", "Jean", " 3 Rue des Peupliers, 75014 Paris", "Jean.dupont@gmail.com", "01341564", 2, TypeUtilisateur.Consommateur); InfosPersos infosPersos = new InfosPersos() { Nom = "Dutronc", Prenom = "Jacques" };
                dal.ModifierUtilisateur(id, infosPersos, "32 Rue des Oliviers, 31000 Toulouse", "Dutronc.Jacques@gmail.com", "0178564", 6, TypeUtilisateur.Locataire); List<Utilisateur> utilisateurs = dal.ObtientTousLesUtilisateurs();
                Assert.NotNull(utilisateurs);
                Assert.Single(utilisateurs);
                Assert.Equal("Dutronc", utilisateurs[0].InfosPersos.Nom);
                Assert.Equal("32 Rue des Oliviers, 31000 Toulouse", utilisateurs[0].Adresse);
            }
        }
    }*/
}
