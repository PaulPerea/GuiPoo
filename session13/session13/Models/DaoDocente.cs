using session13.Reportes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using session13.Reportes;
using System.Data.Common;

namespace session13.Models
{
    public class DaoDocente
    {
        static string cadena = "server=(local); database=cibertec2023; integrated security=true";
        private SqlConnection cn = new SqlConnection(cadena);

        //funcion para el reporte
        public DataSet informe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from docente", cn);
            dbCiber ds = new dbCiber();
            da.Fill(ds, ds.docente.TableName);
            return ds;

        }
    }
}