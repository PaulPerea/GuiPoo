using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//importar el proveedor de datos pra sql server
using System.Data.SqlClient;

namespace Session03.Models
{
    public class Conexion
    {
        //crear el objeto de conexion
        SqlConnection cn = new SqlConnection
            ("server=(local); database=cibertec2023; integrated security=true");
        //funcion de conexion
        public SqlConnection conectar()
        {
            cn.Open ();
            Console.WriteLine("Conexion Exitosa a la Base de Datos");
            cn.Close ();
            return cn;
        }
    }
}