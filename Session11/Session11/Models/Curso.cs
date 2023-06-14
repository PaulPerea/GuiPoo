using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session11.Models
{
    public class Curso
    {
        [Display (Name = "ID"), Required]public int idcurso { get; set; }
        [Display(Name = "Nombre"), Required] public string nombre { get; set; }
        [Display(Name = "Creditos"), Required] public int creditos { get; set; }
        [Display(Name = "Ciclo"), Required] public string ciclo { get; set; }
        [Display(Name = "Descripcion"), Required] public string descripcion { get; set; }

        public Curso()
        {
        }

        public Curso(int idcurso, string nombre, int creditos, string ciclo, string descripcion)
        {
            this.idcurso = idcurso;
            this.nombre = nombre;
            this.creditos = creditos;
            this.ciclo = ciclo;
            this.descripcion = descripcion;
        }
    }
}