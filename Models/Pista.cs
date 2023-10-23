using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_PrimerParcial.Utils;

namespace Proyecto_PrimerParcial.Models
{
    public class Pista
    {
        
        public int PistaId { get; set; }
        public string? PistaNombre {get;set;}
        public int PistaCodigo {get;set;}
        public PistaType PistaMaterial { get; set; }
        public bool PistaIluminacion {get;set;} = true;
        public bool PistaAprovisionamiento {get;set;} = true;

    }
}