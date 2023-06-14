using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Session05.Models
{
    public class DaoDocente
    {
        //obtener la cadena de conexcion desde la webConfig
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        //funcion para insertar
        public string insertar(Docente doc)
        {
            string rpta = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_insertar_docente";
                cmd.Parameters.AddWithValue("@nom", doc.nom);
                cmd.Parameters.AddWithValue("@ap", doc.ape);
                cmd.Parameters.AddWithValue("@dni", doc.dni);
                cmd.Parameters.AddWithValue("@espdoc", doc.esp);
                cmd.Parameters.AddWithValue("@suedoc", doc.sue);
                cmd.Parameters.AddWithValue("@fingdoc", doc.fingDate);
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