using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetQarma.Models
{
    public class Service
    {
        public int Id { get; set; }
        public TypeService TypeService { get; set; }
        public int MontantBisous { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }

    public enum TypeService
    {
        Equipement, Hebergement, Parking, Evenement, Prestation
    }
}

