using System;
using System.Collections.Generic;
using Xunit;
using ProjetQarma.Models;


namespace TestUnit
{
    public class UnitTest1
    {
        /*[Fact]
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
        }*/

        [Fact]
        public void Transferer_Bisous_Verification()
        {
            using (Dal dal = new Dal())
            {
                dal.DeleteCreateDatabase();
                InfosPersos infosPersos1 = new InfosPersos() { Nom = "Dutronc", Prenom = "Jacques" }; int id1 = dal.CreerUtilisateur(infosPersos1, " 3 Rue des Peupliers, 75014 Paris", "Jean.dupont@gmail.com", "01341564", 200, 2, "aaaaa", TypeUtilisateur.Consommateur, "", "");
                InfosPersos infosPersos2 = new InfosPersos() { Nom = "Dubois", Prenom = "Robert" }; int id2 = dal.CreerUtilisateur(infosPersos2, " 3 Rue des Peupliers, 75014 Paris", "Jean.dupont@gmail.com", "01341564", 400, 2, "aaaaa", TypeUtilisateur.Consommateur, "", "");
                dal.CreerService(1, TypeService.Equipement, 100, 20, "Prêt de tondeuse", "", "", 1);
                List<Utilisateur> utilisateurs = dal.ObtientTousLesUtilisateurs();
                List<Service> services = dal.ObtientTousLesServices();
                dal.TransfererBisous(2, 1, 1);
                Assert.NotNull(utilisateurs);
                Assert.NotNull(services);
                Assert.Equal(2, utilisateurs.Count);
                Assert.Single(services);
                Assert.Equal(300, utilisateurs[0].SoldeBisous);
                Assert.Equal(300, utilisateurs[1].SoldeBisous);
            }
        }

        [Fact]
        public void Ajouter_Qarma_Verification()
        {
            using (Dal dal = new Dal())
            {
                dal.DeleteCreateDatabase();
                InfosPersos infosPersos1 = new InfosPersos() { Nom = "Dutronc", Prenom = "Jacques" }; int id1 = dal.CreerUtilisateur(infosPersos1, " 3 Rue des Peupliers, 75014 Paris", "Jean.dupont@gmail.com", "01341564", 200, 2, "aaaaa", TypeUtilisateur.Consommateur, "", "");
                dal.CreerService(1, TypeService.Equipement, 100, 20, "Prêt de tondeuse", "", "", 1);
                List<Utilisateur> utilisateurs = dal.ObtientTousLesUtilisateurs();
                List<Service> services = dal.ObtientTousLesServices();
                dal.AjouterQarma(1, 1);
                Assert.NotNull(utilisateurs);
                Assert.NotNull(services);
                Assert.Equal(22, utilisateurs[0].Qarma);

            }
        }
    }
}

