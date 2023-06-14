using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;


namespace Session11.Models
{
    
    public class Coordinador
    {
        [Display(Name = "ID"), Required] public int IdCoordinador { get; set; }
        [Display(Name = "Nombre"), Required] public string Nom { get; set; }
        [Display(Name = "Apellido"), Required] public string Apellido { get; set; }
        [Display(Name = "Dni"), Required] public string DNI { get; set; }
        [Display(Name = "Genero"), Required] public string Genero { get; set; }
        [Display(Name = "GradoCad"), Required] public string GradoCad { get; set; }
        [Display(Name = "Sueldo"), Required] public decimal Sueldo { get; set; }
        [Display(Name = "Fecha De Nacimiento"), Required] public DateTime FechaNac { get; set; }

        public Coordinador()
        {
            
        }

        public Coordinador(int idCoordinador, string nom, string apellido, string dNI, string genero, string gradoCad, decimal sueldo, DateTime fechaNac)
        {
            IdCoordinador = idCoordinador;
            Nom = nom;
            Apellido = apellido;
            DNI = dNI;
            Genero = genero;
            GradoCad = gradoCad;
            Sueldo = sueldo;
            FechaNac = fechaNac;
        }
    }

    
}