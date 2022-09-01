namespace ProjetQarma.Models
{
    public class Service
    {
        public int Id { get; set; }
        public TypeService TypeService { get; set; }
        public Bisous Bisous { get; set; }
    }
    public enum TypeService
    {
        Equipement, Hebergement, Parking, Evenement, Prestation
    }
}