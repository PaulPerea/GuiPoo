using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Session03.Models
{
    public class myConexion
    {
        SqlConnection cn = new SqlConnection
            ("server=(local); database=cibertec2023; integrated security=true");
        public string rpta = null;

        public string ObtenerConexion()
        {
            try
            {
                cn.Open();
                rpta = "Conexion Exitosa al Servidor de BD sql Server";
                cn.Close();
            }catch (SqlException ex)
            {
                rpta = "Error de Conexcion: " + ex.Message;
            }
            return rpta;
        }
    }
}