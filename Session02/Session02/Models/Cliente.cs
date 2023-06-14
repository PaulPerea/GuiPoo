using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session02.Models
{
    public class Cliente
    {
        //propiedades
        public int codigo { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get;}
        public string email { set; get; }

        //constructor
        public Cliente() { }

        public Cliente(int codigo, string nombre, string apellido, string email)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }
    }
}