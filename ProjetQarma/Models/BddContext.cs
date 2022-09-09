using System;
using Microsoft.EntityFrameworkCore;

namespace ProjetQarma.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Qarma> Qarmas { get; set; }
        public DbSet<InfosPersos> InfosPersos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Proposition> Propositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=RRRRR;database=utilisateurQarma");
        }

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Utilisateur.AddRange(

                new Utilisateur
                {
                    InfosPersosId = 1,
                    Id = 1,
                    Adresse = " 3 Rue des Peupliers, 75014 Paris",
                    Mail = "Jean.dupont@gmail.com",
                    Telephone = "000000000",
                    Qarma = 2,
                    Password = Dal.EncodeMD5("aaaaa"),
                    TypeUtilisateur = TypeUtilisateur.Consommateur,
                    Role = Role.SuperAdmin
                },
                new Utilisateur
                {
                    InfosPersosId = 2,
                    Id = 2,
                    Adresse = " 8 Rue des Peupliers, 75014 Paris",
                    Mail = "albert37@gmail.com",
                    Telephone = "1464357890",
                    SoldeBisous = 200,
                    Qarma = 8,
                    Password = Dal.EncodeMD5("bbbbb"),
                    TypeUtilisateur = TypeUtilisateur.Consommateur,
                    Role = Role.User
                },
                 new Utilisateur
                 {
                     InfosPersosId = 3,
                     Id = 3,
                     Adresse = " 10 Rue des Peupliers, 75014 Paris",
                     Mail = "ben34@gmail.com",
                     Telephone = "0654983476",
                     SoldeBisous = 400,
                     Qarma = 8,
                     Password = Dal.EncodeMD5("ccccc"),
                     TypeUtilisateur = TypeUtilisateur.Consommateur,
                     CentreInteret = "J'aime le jazz et les ballades en foret.",
                     Propose = "Bricolage - Petits travaux",
                     ImagePath = "/photos/profil/photoBenoit.jpg",
                     Appartement = "Dans l'appartement 37B, nous sommes 4. Lisa, moi et nos 2 enfants Oscar et Faustine. Lisa est institutrice et je suis cascadeur."


                 }
            );
            this.InfosPersos.AddRange(
                new InfosPersos
                {
                    Id = 1,
                    Nom = "Dupont",
                    Prenom = "Jean"
                },
                new InfosPersos
                {
                    Id = 2,
                    Nom = "Nachor",
                    Prenom = "guilhemjoual"
                },
                new InfosPersos
                {
                    Id = 3,
                    Nom = "Dubost",
                    Prenom = "Benoit"
                }
            );
            this.Services.AddRange(
                new Service
                {
 
                    InfosPersosId = 1,

                    Id = 1,
                    Titre = "Parking",
                    TypeService = TypeService.Parking,
                    MontantBisous = 100,
                    MontantQarma = 20,
                    Description = "Je recherche à louer une place de parking pour une durée d'une semaine",
                    ImagePath = "/images/Parking.jpg",

                }
            );

            this.Services.AddRange(
                new Service
                {
                    InfosPersosId = 1,
                    Id = 2,
                    Titre = "Promener mon chien",
                    TypeService = TypeService.Prestation,
                    Description = "Je recherche quelqu'un pour promener mon chien tous les dimanches matins",
                    ImagePath = "/images/Prestation.jpg",

                }
            );

            this.Services.AddRange(
                new Service
                {
                    InfosPersosId = 2,
                    Id = 3,
                    Titre = "Raclette !!!",
                    TypeService = TypeService.Evenement,
                    Description = "Quelqu'un pour organiser une soirée raclette ce vendredi entre voisins ?!!",
                    ImagePath = "/images/Evenement.jpg",

                }
            );
            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 2,
                   Id = 4,
                   Titre = "Place canapé",
                   TypeService = TypeService.Hebergement,
                   Description = "Yo ! Je peux emprunter un canapé pour 1 semaine? On manque de place avec les 7 nains à la maison^^",
                   ImagePath = "/images/Hebergement.jpg",

               }
           );
            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 3,
                   Id = 5,
                   Titre = "Besoin de toit ...",
                   TypeService = TypeService.Hebergement,
                   Description = "Salut les loulous !! Est-ce que quelqu'un a une pièce en plus à  squatter pendant les vacances d'été?",
                   ImagePath = "/images/Hebergement.jpg",

               }
           );

            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 3,
                   Id = 6,
                   Titre = "Hé José!!",
                   TypeService = TypeService.Equipement,
                   Description = "José tu as  un tout nouveau karcher,  tu me le prêtes pour nettoyer ma titine? ",
                   ImagePath = "/images/Equipement.jpg",

               }
           );
            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 3,
                   Id = 7,
                   Titre = "Outil",
                   TypeService = TypeService.Equipement,
                   Description = "Je prête ma tronçonneuse si vous avez besoin de couper quoi ce soit !",
                   ImagePath = "/images/Equipement.jpg",

               }
           );
            this.Propositions.AddRange(
                new Proposition
                {
                    InfosPersosId = 3,
                    Id = 1,
                    Titre = "Massage",
                    TypeService = TypeService.Prestation,
                    Description = "Bonjour, je propose des massages...",
                    ImagePath = "/images/Prestation.jpg",

                }
            );
            this.Propositions.AddRange(
                new Proposition
                {

                    InfosPersosId = 1,
                    Id = 2,
                    Titre = "Barbecue",
                    TypeService = TypeService.Evenement,
                    Description = "Bonjour, j'ai un nouveau barbecue et on doit fêter ça !!",
                    ImagePath = "/images/Evenement.jpg",

                }
            );
            this.Propositions.AddRange(
                new Proposition
                {
                    InfosPersosId = 1,
                    Id = 3,
                    Titre = "Marteau neuf",
                    TypeService = TypeService.Prestation,
                    Description = "Je peux prêter mon nouveau marteau !! Veuillez juste ne pas taper trop fort avec ! ",
                    ImagePath = "/images/Equipement.jpg",

                }
            );
            this.Propositions.AddRange(
                new Proposition
                {
                    InfosPersosId = 3,
                    Id = 4,
                    Titre = "Parking libre",
                    TypeService = TypeService.Parking,
                    Description = "Je laisse ma place dans le local à vélo pendant 2 mois cet été. Avis aux interéssés !",
                    ImagePath = "/images/Parking.jpg",
                    DateTime = new DateTime(2021,12,12)

                }
            );
            this.SaveChanges();
        }
    }


}
