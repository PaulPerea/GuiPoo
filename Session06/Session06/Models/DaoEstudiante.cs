using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Session06.Models
{
    public class DaoEstudiante
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);
        //busqueda de estudiante
        public Estudiante buscar(Estudiante obj)
        {
            string rpta = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_insertar_estudiante";
                cmd.Parameters.AddWithValue("@nombre", es.nom);
                cmd.Parameters.AddWithValue("@apellido", es.ape);
                cmd.Parameters.AddWithValue("@telefono", es.tel);
                cmd.Parameters.AddWithValue("@correo", es.email);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cmd.Dispose();
                rpta = "exito";

            }
            catch (SqlException ex)
            {

            }
            return rpta;
        }
    }
}