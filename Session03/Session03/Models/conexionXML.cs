using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Session03.Models
{
    public class conexionXML
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection cn = new SqlConnection(cadena);

        public SqlConnection conectar()
        {
            cn.Open();
            Console.Write("Conexion con XML");
            cn.Close();
            return cn;
        }
    }
}