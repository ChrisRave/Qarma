﻿using System;
using System.ComponentModel.DataAnnotations;

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
        public int Qarma { get; set; }
        public TypeUtilisateur TypeUtilisateur { get; set; }
        public string Password { get; set; }
        public string CentreInteret { get; set; }
        public string Propose { get; set; }
    }
    public enum TypeUtilisateur
    {
        Fournisseur, Consommateur, 
    }
}
