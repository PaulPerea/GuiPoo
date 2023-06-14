using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using session13.Reportes;

namespace session13.Models
{
    public class DaoEstudiante
    {
        //static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        static string cadena = "server=(local); database=cibertec2023; integrated security=true";
        private SqlConnection cn = new SqlConnection(cadena);

        //funcion para el reporte
        public DataSet informe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from estudiante", cn);
            dsCibertec ds = new dsCibertec();
            da.Fill(ds, ds.estudiante.TableName);
            return ds;

        }
    }
}