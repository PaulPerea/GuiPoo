using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Session11.Models
{
    public class DaoCurso
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);
        SqlTransaction tran;

        //listado
        public List<Curso> listado()
        {
            List<Curso> lista = new List<Curso>();
            SqlCommand cmd = new SqlCommand("select * from curso", cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Curso()
                { 

                    idcurso = dr.GetInt32(0),
                    nombre = dr.GetString(1),
                    creditos= dr.GetInt32(2),
                    ciclo = dr.GetString(3),
                    descripcion= dr.GetString(4)

                });
            }
            dr.Close();
            cn.Close();
            cmd.Dispose();
            return lista;
        }


        //guardar
        public string guardar(Curso cur)
        {
            string msj = null;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into curso values(@nom, @cre, @cic, @des)", cn);
                cmd.Parameters.AddWithValue("@nom", cur.nombre);
                cmd.Parameters.AddWithValue("@cre", cur.creditos);
                cmd.Parameters.AddWithValue("@cic", cur.ciclo);
                cmd.Parameters.AddWithValue("@des", cur.descripcion);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                tran = cn.BeginTransaction(); //iniciar la transacción
                cmd.Transaction = tran; //asignar la transacción al comando
                cmd.ExecuteNonQuery();
                tran.Commit();  //confirmar la transacción
                cn.Close();
                cmd.Dispose();
                msj = "exito";
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