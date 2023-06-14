using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Session08.Models
{
    public class DaoEstudiante
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        //Recuperar datos 
        public Estudiante buscar(Estudiante obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_consultar_estudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ape", obj.ape);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Estudiante est = new Estudiante(); //creamos uno nuevo por que este va a retornar , el de arriba solo llama para completar
                while (dr.Read())
                {
                    est.idestud = dr.GetInt32(0);
                    est.nomb = dr.GetString(1);
                    est.ape = dr.GetString(2);
                    est.telefono = dr.GetString(3);
                    est.correo = dr.GetString(4);
                }
                dr.Close();
                cn.Close();
                cmd.Dispose();
                return est;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        //listado de datos
        public List<Estudiante> listado()
        {
            List<Estudiante>lista = new List<Estudiante>();
            SqlCommand cmd = new SqlCommand("usp_listar_estudiante",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Estudiante()
                {
                    idestud = dr.GetInt32(0),
                    nomb = dr.GetString(1),
                    ape = dr.GetString(2),
                    telefono = dr.GetString(3),
                    correo = dr.GetString(4)
                });
            }
            dr.Close();
            cn.Close();
            cmd.Dispose();
            return lista;
        }
    }
}