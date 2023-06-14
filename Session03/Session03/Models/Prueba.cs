using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session03.Models
{
    public class Prueba
    {
        public static void Main(string[] args)
        {
            //Conexion obj = new Conexion();
            //obj.conectar();

            conexionXML obj = new conexionXML();
            obj.conectar();

        }
    }
}