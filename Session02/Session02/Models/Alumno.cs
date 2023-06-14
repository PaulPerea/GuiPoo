using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session02.Models
{
    public class Alumno
    {
        public int codigo { set; get; }
        public string nombre { set; get; } 
        public int nt1 { set; get; }    
        public int nt2 { set; get; }

        public Alumno() { }

        public Alumno(int codigo, string nombre, int nt1, int nt2)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nt1 = nt1;
            this.nt2 = nt2;
        }
        //metodo de usuario
        public double Promedio()
        {
            return (this.nt1 + this.nt2) / 2.0;
        }
        public string Condicion()
        {
            if (this.Promedio() >= 12.5)
                return "Aprobado";
            else
                return "Desaprobado";
        }
    }
}