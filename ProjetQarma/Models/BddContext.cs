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
                    InfosPersosId= 1,
                    Id = 1,
                    Adresse = " 3 Rue des Peupliers, 75014 Paris",
                    Mail = "Jean.dupont@gmail.com",
                    Telephone = "000000000",
                    Qarma = 2,
                    Password = Dal.EncodeMD5("aaaaa"),
                    TypeUtilisateur = TypeUtilisateur.Consommateur
                },
                new Utilisateur
                {
                    InfosPersosId = 2,
                    Id = 2,
                    Adresse = " 8 Rue des Peupliers, 75014 Paris",
                    Mail = "albert37@gmail.com",
                    Telephone = "1464357890",
                    Qarma = 8,
                    Password = Dal.EncodeMD5("bbbbb"),
                    TypeUtilisateur = TypeUtilisateur.Consommateur
                },
                 new Utilisateur
                 {
                     InfosPersosId = 3,
                     Id = 3,
                     Adresse = " 10 Rue des Peupliers, 75014 Paris",
                     Mail = "ben34@gmail.com",
                     Telephone = "0654983476",
                     Qarma = 8,
                     Password = Dal.EncodeMD5("ccccc"),
                     TypeUtilisateur = TypeUtilisateur.Consommateur,
                     CentreInteret = "J'aime le jazz et les ballades en foret.",
                     Propose = "Bricolage - Petits travaux"
                 }
            ) ;
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
                    Id = 1,
                    TypeService = TypeService.Parking,
                    Description = "Je recherche à louer une place de parking pour une durée d'une semaine",
                    ImagePath = "~/photos/SolidevLogo.png",

                }
            );
            this.Propositions.AddRange(
                new Proposition
                {
                    Id = 1,
                    InfosPersosId = 2, 
                    TypeService = TypeService.Prestation,
                    Description = "Bonjour, je propose des massages...",
                    ImagePath = "~/photos/SolidevLogo.png",
                    DateTime = DateTime.Now,

        }
            );
            this.SaveChanges();
        }
    }

    
}
