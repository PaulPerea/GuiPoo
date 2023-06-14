using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session08.Models
{
    public class Estudiante
    {
        public int idestud { get; set; }
        public string nomb {  get; set; }
        public string ape {  get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(int idestud, string nomb, string ape, string telefono, string correo)
        {
            this.idestud = idestud;
            this.nomb = nomb;
            this.ape = ape;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}