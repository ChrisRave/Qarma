using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Cryptography.X509Certificates;

namespace ProjetQarma.Models
{
    public class Gmail
    {
        public string To { get; set; }  
        public string From { get; set; }        
        public string Subject { get; set; }
        public string Body { get; set; }    
    }
}
