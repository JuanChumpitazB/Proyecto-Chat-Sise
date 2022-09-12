using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LogicaNegocio
{
    public class Empleado
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        static SqlConnection cn = new SqlConnection(cadena);

        public int codEmpleado { get; set; }
        public string nombres { get; set;}
        public string apellidos { get; set; }
    }
}
