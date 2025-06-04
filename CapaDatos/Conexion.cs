using System;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{

    public class Conexion
    {
        private string cadenaConexion = "Server=. ;Database=TransporteDB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }

}

