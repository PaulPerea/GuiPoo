using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Session08.Models
{
    public class DaoDocente
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);
        public Docente buscar(Docente obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_consultar_docente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", obj.dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Docente est = new Docente(); 
                while (dr.Read())
                {
                    est.idoc = dr.GetInt32(0);
                    est.nomb = dr.GetString(1);
                    est.ape = dr.GetString(2);
                    est.dni = dr.GetString(3);
                    est.especie = dr.GetString(4);
                    est.sueldo = dr.GetDecimal(5);
                    est.fin = dr.GetDateTime(6);
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
        public List<Docente> listado()
        {
            List<Docente> lista = new List<Docente>();
            SqlCommand cmd = new SqlCommand("usp_listar_docente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Docente()
                {
                    idoc = dr.GetInt32(0),
                    nomb = dr.GetString(1),
                    ape = dr.GetString(2),
                    dni = dr.GetString(3),
                    especie = dr.GetString(4),
                    sueldo = dr.GetDecimal(5),
                    fin = dr.GetDateTime(6)
            });
            }
            dr.Close();
            cn.Close();
            cmd.Dispose();
            return lista;
        }
    }
}