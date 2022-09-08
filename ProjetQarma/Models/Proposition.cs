using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ProjetQarma.Models
{
    public class Proposition
    {
        public int Id { get; set; }

        [Display(Name = "Type de proposition")]
        public TypeService TypeService { get; set; }

        [Display(Name = "Coût du service")]
        [RegularExpression("[0-9]+", ErrorMessage = " Veuillez saisir un nombre")]
        public int MontantBisous { get; set; }
        public int MontantQarma { get; set; }   
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public int InfosPersosId { get; set; }
        public  DateTime DateTime { get; set; }
        public string Titre { get; set; }
        public Equipement Equipement { get; set; }

    }
   


}
