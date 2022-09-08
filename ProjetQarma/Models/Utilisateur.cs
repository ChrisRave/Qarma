using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ProjetQarma.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        

        public int? InfosPersosId { get; set; }
        public InfosPersos InfosPersos { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        [MaxLength(14)]
        public string Telephone { get; set; }
        public int SoldeBisous { get; set; }    
        public int Qarma { get; set; }
        public TypeUtilisateur TypeUtilisateur { get; set; }
        public string Password { get; set; }
        public string CentreInteret { get; set; }
        public string Propose { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Appartement { get; set; }
    }
    public enum TypeUtilisateur
    {
        Fournisseur, Consommateur, 
    }
}
