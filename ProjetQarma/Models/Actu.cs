using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjetQarma.Models
{
    public class Actu
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        [Display(Name = "Catégorie")]
        public string Categorie { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}