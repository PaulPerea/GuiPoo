using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session06.Models
{
    public class Estudiante
    {
        public int idEstud { get; set; }
        public string nom { get; set; }
        public string ape { get; set; }
        public string tel { get; set; }
        public string correo { get; set; }
        public Estudiante()
        {

        }

        public Estudiante(int idEstud, string nom, string ape, string tel, string correo)
        {
            this.idEstud = idEstud;
            this.nom = nom;
            this.ape = ape;
            this.tel = tel;
            this.correo = correo;
        }
    }
}