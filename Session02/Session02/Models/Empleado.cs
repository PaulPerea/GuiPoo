using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session02.Models
{
    public class Empleado
    {
        public int cod { set; get; }
        public string nom { set; get; }
        public string ape { set; get; }
        public string email { set; get; }
        public int hora { set; get; }
        public double tarifa { set; get; }

        public Empleado() { }

        public Empleado(int cod, string nom, string ape, string email, int hora, double tarifa)
        {
            this.cod = cod;
            this.nom = nom;
            this.ape = ape;
            this.email = email;
            this.hora = hora;
            this.tarifa = tarifa;
        }

        //
        public double sueldoBruto()
        {
            return (this.hora * this.tarifa);
        }
        public double descBruto()
        {
            return (sueldoBruto() / 0.12);
        }
        public double boniFamiliar()
        {
            return (sueldoBruto() / 0.09);
        }
        public double boniEsp()
        {
            double esp = sueldoBruto() / 0.10;
            double espM = sueldoBruto() / 0.045;
            if (this.hora > 40)
                return esp;
            else 
                return espM;
        }
        public double salNeto()
        {
            double desc = sueldoBruto() - descBruto();
            double boni = desc + boniFamiliar() + boniEsp();
            return boni;
        }
    }
}