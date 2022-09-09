using ProjetQarma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetQarma.ViewModels
{
    public class ServicePropositionViewModel
    {
        public List<Proposition> Propositions { get; set; }
        public List<Service> Services { get; set; }

    }
}
