using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Session04.Models
{
    public class DaoDocente
    {
        //obtener la cadena de conexion
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection cn = new SqlConnection(cadena);

        //insercion
        public string insertar(Docente obj)
        {
            string rpta = null;
            try
            {
                //crear comando
                SqlCommand cmd = new SqlCommand();
                //asignar al comando la sentencia sql insert
                cmd.CommandText = "insert into docente values(@nom,@ap,@dni,@esp,@sue,@fin)";
                //asignar los parametros del comando
                cmd.Parameters.AddWithValue("@nom", obj.nom);
                cmd.Parameters.AddWithValue("@ap", obj.ap);
                cmd.Parameters.AddWithValue("@dni", obj.dni);
                cmd.Parameters.AddWithValue("@esp", obj.esp);
                cmd.Parameters.AddWithValue("@sue", obj.sue);
                cmd.Parameters.AddWithValue("@fin", obj.fin);
                
                //asignar el tipo de comando
                cmd.CommandType = CommandType.Text; //por que el comando es text en linea 24
                //asignar el comando con el objeto conecto
                cmd.Connection = cn;
                //abrir la conexion a la BD
                cn.Open();
                //enviar la orden del comando a la Bd
                cmd.ExecuteNonQuery();
                //cerrar la conexion a la bd
                cn.Close();
                
                //liberrar los recursos del comando
                cmd.Dispose();
                rpta = "ok";

            }
            catch (SqlException ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

    }
}