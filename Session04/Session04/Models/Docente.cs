using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session04.Models
{
    public class Docente
    {
        public int iddoc { get; set; }
        public string nom { get; set; }
        public string ap { get; set; }
        public string dni { get; set; }
        public string esp { get; set; }
        public double sue { get; set; }
        public DateTime fin { get; set; } = DateTime.Now;

        public Docente() { }

        public Docente(int iddoc, string nom, string ap, string dni, string esp, double sue, DateTime fin)
        {
            this.iddoc = iddoc;
            this.nom = nom;
            this.ap = ap;
            this.dni = dni;
            this.esp = esp;
            this.sue = sue;
            this.fin = fin;
        }
    }
}