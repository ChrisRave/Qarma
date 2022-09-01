using System;
using Microsoft.EntityFrameworkCore;

namespace ProjetQarma.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Qarma> Qarmas { get; set; }
        public DbSet<Bisous> Bisous { get; set; }
        public DbSet<InfosPersos> InfosPersos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=utilisateurQarma");
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
                    TypeUtilisateur = TypeUtilisateur.Consommateur
                }
            ) ;
            this.InfosPersos.AddRange(
                new InfosPersos
                {
                    Id = 1,
                    Nom = "Jean",
                    Prenom = "Dupont"
                },
                new InfosPersos
                {
                    Id = 2,
                    Nom = "Alexis",
                    Prenom = "Crotal"
                }
            );
           this.SaveChanges();
        }
    }

    
}
