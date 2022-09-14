using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProjetQarma.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Qarma> Qarmas { get; set; }
        public DbSet<InfosPersos> InfosPersos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Proposition> Propositions { get; set; }
        public DbSet<Actu> Actus { get; set; } 




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
			
			if (System.Diagnostics.Debugger.IsAttached)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=RRRRR;database=utilisateurQarma");
            }
            else
            {
                IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            }
        }
        //
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Utilisateur.AddRange(

                new Utilisateur
                {
                    InfosPersosId = 1,
                    Id = 1,
                    Adresse = " 56 Rue des Voiliers, 34280 La Grande-Motte.",
                    Mail = "Jean.dupont@gmail.com",
                    Telephone = "000000000",
                    SoldeBisous = 600,
                    Qarma = 15,
                    Password = Dal.EncodeMD5("aaaaa"),

                    ImagePath = "/photos/profil/photoalbert.jpg",
                    Propose = "Service d'admin - montage meubles en kit - Installation electrique - garde animaux - Aide à domicile",    
                   CentreInteret ="Avec Marie Pierre nous sommes passionnés par les animaux. Je suis aussi passioné par l'informatique",
                    TypeUtilisateur = TypeUtilisateur.Consommateur,
                    Role = Role.SuperAdmin,
                    Appartement = "Ayant été dessinateur bâtiment génie civil et conducteur de travaux je réalise tous travaux de bricolage. Marie Pierre aime les animaux et peut s'en occuper pendant vos vacances. ",

                },
                new Utilisateur
                {
                    InfosPersosId = 2,
                    Id = 2,
                    Adresse = " 56 Rue des Voiliers, 34280 La Grande-Motte.",
                    Mail = "lisa88@gmail.com",
                    Telephone = "1464357890",
                    SoldeBisous = 200,
                    Qarma = 8,
                    Password = Dal.EncodeMD5("bbbbb"),
                    TypeUtilisateur = TypeUtilisateur.Consommateur,
                    Role = Role.User,
                    ImagePath = "/photos/profil/photoutil2.jpg",
                    Propose = "Cours d'anglais - cours de français",
                    CentreInteret = "J'aime voyager dans le monde et rencontrer de nouvelles personnes, j'ai vécu 5 ans au Royaume-Uni et je parle couramment l'anglais.",
                    Appartement = "Dans l'appartement 02A, nous sommes 2. Richard, moi et nos 2 enfants Oscar et Faustine."
                },
                 new Utilisateur
                 {
                     InfosPersosId = 3,
                     Id = 3,
                     Adresse = " 56 Rue des Voiliers, 34280 La Grande-Motte.",
                     Mail = "ben34@gmail.com",
                     Telephone = "0654983476",
                     SoldeBisous = 400,
                     Qarma = 8,
                     Password = Dal.EncodeMD5("ccccc"),
                     TypeUtilisateur = TypeUtilisateur.Consommateur,
                     CentreInteret = "J'aime le jazz et les ballades en foret.",
                     Propose = "Bricolage - Petits travaux - photos",
                     ImagePath = "/photos/profil/photoBenoit.jpg",
                     Appartement = "Je suis un professionnel expérimenté de la photographie de mode et de beauté. Je travaille régulièrement pour des magazines français et internationaux (Madame Figaro, Cosmopolitan, Biba, etc.). J'ai remporté de nombreux prix et mes photographies font partie des collections de la Bibliothèque nationale de France."


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
                    Nom = "Lisa",
                    Prenom = "beate"
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
                    MontantQarma = 1,
                    Description = "Je recherche à louer une place de parking pour une durée d'une semaine",
                    ImagePath = "/images/Parking.jpg",
                    DateTime = new DateTime(2021, 06, 13),

                }
            );

            this.Services.AddRange(
                new Service
                {
                    InfosPersosId = 1,
                    Id = 2,
                    Titre = "Promener mon chien",
                    MontantBisous = 3,
                    MontantQarma = 1,
                    TypeService = TypeService.Prestation,
                    Description = "Je recherche quelqu'un pour promener mon chien tous les dimanches matins",

                    ImagePath = "/photos/Service/chien1.jpg",
                    DateTime = new DateTime(2021, 12, 12)

                }
            );

            this.Services.AddRange(
                new Service
                {
                    InfosPersosId = 2,
                    Id = 3,
                    Titre = "Raclette !!!",
                    MontantBisous = 3,
                    MontantQarma = 1,
                    TypeService = TypeService.Evenement,
                    Description = "Quelqu'un pour organiser une soirée raclette ce vendredi entre voisins ?!!",
                    DateTime = new DateTime(2021, 05, 09),
                    ImagePath = "/photos/Service/raclette.jpg",

                }
            );
            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 2,
                   Id = 4,
                   Titre = "Place canapé",
                   MontantBisous = 3,
                   MontantQarma = 1,
                   TypeService = TypeService.Hebergement,
                   Description = "Yo ! Je peux emprunter un canapé pour 1 semaine? On manque de place avec les 7 nains à la maison^^",
                   ImagePath = "/images/Hebergement.jpg",
                   DateTime = new DateTime(2021, 08, 08),

               }
           );
            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 3,
                   Id = 5,

                   Titre = "Repassage",
                   MontantBisous = 3,
                   MontantQarma = 1,
                   TypeService = TypeService.Prestation,
                   Description = "Bonjour, Cherche une personne pour du repassage. Merci de me contacter et indiquer votre tarif pour deux panières par exemple",
                   ImagePath = "/photos/Service/ferARepasser.jpg",
                   DateTime = new DateTime(2021, 12, 03),

               }
           );

            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 3,
                   Id = 6,

                   Titre = "Cherche plombier",
                   MontantBisous = 3,
                   MontantQarma = 1,
                   TypeService = TypeService.Prestation,
                   Description = "Bonjour, je recherche un plombier pour mettre un raccord et un tuyau souple afin de remplacer un bout de tuyau tordu en cuivre. ",
                   ImagePath = "/photos/Service/plomberie.jpg",
                   DateTime = new DateTime(2021, 12, 12)

               }
           );
            this.Services.AddRange(
               new Service
               {
                   InfosPersosId = 3,
                   Id = 7,
                   Titre = "Outil",
                   MontantBisous = 3,
                   MontantQarma = 1,
                   TypeService = TypeService.Equipement,
                   Description = "Je prête ma tronçonneuse si vous avez besoin de couper quoi ce soit !",
                   ImagePath = "/images/Equipement.jpg",
                   DateTime = new DateTime(2021, 12, 05),

               }
           );
            this.Propositions.AddRange(
                new Proposition
                {
                    InfosPersosId = 2,
                    Id = 1,
                    Titre = "Repas",
                    MontantBisous = 10,
                    MontantQarma = 1,
                    TypeService = TypeService.Prestation,

                    Description = "Cours a domicile repas pour occasion soirees.anniversaire. ",
                    ImagePath = "/photos/Service/repas.jpg",
                    DateTime = new DateTime(2021, 12, 03),

                }
            );
            this.Propositions.AddRange(
                new Proposition
                {

                    InfosPersosId = 3,
                    Id = 2,
                    Titre = "Barbecue",
                    MontantBisous = 0,
                    MontantQarma = 1,
                    TypeService = TypeService.Evenement,
                    Description = "Bonjour, j'ai un nouveau barbecue et on doit fêter ça !!",

                    ImagePath = "/photos/Service/barbecue.jpg",
                    DateTime = new DateTime(2021, 10, 13),

                }
            );
            this.Propositions.AddRange(
                new Proposition
                {
                    InfosPersosId = 1,
                    Id = 3,
                    Titre = "Couture",
                    TypeService = TypeService.Prestation,

                    Description = "Je propose mes services pour des retouches ainsi que des cours de couture ",
                    MontantBisous = 8,
                    MontantQarma = 1,
                    ImagePath = "/photos/Service/couture.jpg",

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


                    MontantBisous = 5,
                    MontantQarma = 1,
                    ImagePath = "/photos/Service/veloParking.jpg",
                    DateTime = new DateTime(2021,12,12),

                }
            );
            this.SaveChanges();
        }
    }


}
