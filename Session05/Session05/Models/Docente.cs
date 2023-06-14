using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session05.Models
{
    public class Docente
    {
        public int iddoc { get; set; }
        public string nom { get;set; }
        public string ape { get; set; }
        public string dni { get; set; }
        public string esp { get; set; }
        public double sue { get; set; }
        public string fingDate { get; set; }

        public Docente()
        {

        }
        public Docente(int iddoc, string nom, string ape, string dni, string esp, double sue, string fingDate)
        {
            this.iddoc = iddoc;
            this.nom = nom;
            this.ape = ape;
            this.dni = dni;
            this.esp = esp;
            this.sue = sue;
            this.fingDate = fingDate;
        }
    }
}