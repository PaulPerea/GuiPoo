using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Session11.Models
{
    public class DaoCoordinador
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);
        SqlTransaction tran;

        //listado
        public List<Coordinador> listado()
        {
            List<Coordinador> lista = new List<Coordinador>();
            SqlCommand cmd = new SqlCommand("select * from coodinador", cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Coordinador()
                {

                    IdCoordinador = dr.GetInt32(0),
                    Nom = dr.GetString(1),
                    Apellido = dr.GetString(2),
                    DNI = dr.GetString(3),
                    Genero = dr.GetString(4),
                    GradoCad = dr.GetString(5),
                    Sueldo = dr.GetDecimal(6),
                    FechaNac = dr.GetDateTime(7)

                });
            }
            dr.Close();
            cn.Close();
            cmd.Dispose();
            return lista;
        }
        public string guardar(Coordinador Coo)
        {
            string msj = null;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into coodinador values(@nom,@ape, @dni, @gen, @grado, @sueldo, @fech)", cn);
                cmd.Parameters.AddWithValue("@nom", Coo.Nom);
                cmd.Parameters.AddWithValue("@ape", Coo.Apellido);
                cmd.Parameters.AddWithValue("@dni", Coo.DNI);
                cmd.Parameters.AddWithValue("@gen", Coo.Genero);
                cmd.Parameters.AddWithValue("@grado", Coo.GradoCad);
                cmd.Parameters.AddWithValue("@sueldo", Coo.Sueldo);
                cmd.Parameters.AddWithValue("@fech", Coo.FechaNac);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                tran = cn.BeginTransaction(); //iniciar la transacción
                cmd.Transaction = tran; //asignar la transacción al comando
                cmd.ExecuteNonQuery();
                tran.Commit();  //confirmar la transacción
                cn.Close();
                cmd.Dispose();
                msj = "listo";
            }
            catch (SqlException ex)
            {
                tran.Rollback(); //cancelar la transacción
                msj = ex.Message;
            }
            return msj;
        }
    }
}