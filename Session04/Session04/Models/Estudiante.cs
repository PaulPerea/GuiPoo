using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session04.Models
{
    public class Estudiante
    {
        //propiedades
        public int idestudiante { get; set; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }
        //constructores
        public Estudiante() { }

        public Estudiante(int idestudiante, string nombre, string apellido, string telefono, string correo)
        {
            this.idestudiante = idestudiante;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}