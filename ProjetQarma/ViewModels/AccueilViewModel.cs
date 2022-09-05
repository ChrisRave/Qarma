using System;
using ProjetQarma.Models;

namespace ProjetQarma.ViewModels
{
    public class AccueilViewModel
    {
        public Utilisateur Utilisateur { get; set; }
        public Service Service { get; internal set; }
    }
}
