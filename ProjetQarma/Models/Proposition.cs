using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ProjetQarma.Models
{
    public class Proposition
    {
        public int Id { get; set; }
        public TypeService TypeService { get; set; }
        public int MontantBisous { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public int InfosPersosId { get; set; }
        public  DateTime DateTime { get; set; }
        public string Titre { get; set; }
        public Equipement Equipement { get; set; }

    }
    public enum  Equipement
    {
        Bricolage, Jardinage
    }


}
