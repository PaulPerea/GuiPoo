using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session08.Models
{
    public class Docente
    {
        public int idoc { get; set; }
        public string nomb { get; set; }
        public string ape { get; set; }
        public string dni { get; set; }
        public string especie { get; set; }
        public decimal sueldo { get; set; }
        public DateTime fin { get; set; }

        public Docente()
        {
        }

        public Docente(int idoc, string nomb, string ape, string dni, string especie, decimal sueldo, DateTime fin)
        {
            this.idoc = idoc;
            this.nomb = nomb;
            this.ape = ape;
            this.dni = dni;
            this.especie = especie;
            this.sueldo = sueldo;
            this.fin = fin;
        }
    }
}