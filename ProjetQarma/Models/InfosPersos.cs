using System;
namespace ProjetQarma.Models
{
    public class InfosPersos
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public static implicit operator InfosPersos(string v)
        {
            throw new NotImplementedException();
        }
    }
}
