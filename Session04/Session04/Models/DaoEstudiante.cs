using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Session04.Models
{
    public class DaoEstudiante
    {
        //obtener la cadena de conexion
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection cn =  new SqlConnection(cadena);

        //insercion
        public string insertar(Estudiante obj)
        {
            string rpta = null;
            try
            {
                //crear comando
                SqlCommand cmd = new SqlCommand();
                //asignar al comando la sentencia sql insert
                cmd.CommandText = "insert into estudiante values(@nom,@ap,@tef,@cor)";
                //asignar los parametros del comando
                cmd.Parameters.AddWithValue("@nom", obj.nombre);
                cmd.Parameters.AddWithValue("@ap", obj.apellido);
                cmd.Parameters.AddWithValue("@tef", obj.telefono);
                cmd.Parameters.AddWithValue("@cor", obj.correo);
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
                //enviar rsta de extio
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