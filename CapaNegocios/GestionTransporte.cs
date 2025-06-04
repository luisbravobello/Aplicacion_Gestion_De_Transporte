using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    // Clase base
    public class Transporte
    {
        public int Id { get; set; }
        public string Ruta { get; set; }
        public int Capacidad { get; set; }
        public string Tipo { get; set; }
        public DateTime HoraRutaInicio { get; set; }
        public string LugarRutaInicio { get; set; }
        public DateTime HoraDestinoFin { get; set; }
        public string DestinoRutaFin { get; set; }
    }

    // Clases hijas
    public class Bus : Transporte
    {
        // Propiedades adicionales específicas del Bus si las necesitas
        // public int NumeroParadas { get; set; }
    }

    public class Taxi : Transporte
    {
        // Propiedades adicionales específicas del Taxi
        // public decimal TarifaMinima { get; set; }
    }

    public class Metro : Transporte
    {
        // Propiedades adicionales específicas del Metro
        // public int Frecuencia { get; set; }
    }

    // Clase GestorTransporte (gestiona operaciones con la base de datos)
    public class GestorTransporte
    {
        private readonly Conexion conexion = new Conexion();

        public List<Transporte> Listar()
        {
            List<Transporte> lista = new List<Transporte>();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Transporte", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["Tipo"]?.ToString()?.ToLower() ?? "";

                    Transporte t;
                    switch (tipo)
                    {
                        case "bus":
                            t = new Bus(); break;
                        case "taxi":
                            t = new Taxi(); break;
                        case "metro":
                            t = new Metro(); break;
                        default:
                            t = new Transporte(); break;
                    }

                    t.Id = Convert.ToInt32(reader["Id"]);
                    t.Ruta = reader["Ruta"]?.ToString() ?? string.Empty;
                    t.Capacidad = Convert.ToInt32(reader["Capacidad"]);
                    t.Tipo = reader["Tipo"]?.ToString() ?? string.Empty;
                    t.HoraRutaInicio = reader["HoraRutaInicio"] != DBNull.Value ? Convert.ToDateTime(reader["HoraRutaInicio"]) : DateTime.MinValue;
                    t.LugarRutaInicio = reader["LugarRutaInicio"]?.ToString() ?? "";
                    t.HoraDestinoFin = reader["HoraDestinoFin"] != DBNull.Value ? Convert.ToDateTime(reader["HoraDestinoFin"]) : DateTime.MinValue;
                    t.DestinoRutaFin = reader["DestinoRutaFin"]?.ToString() ?? "";

                    lista.Add(t);
                }
            }
            return lista;
        }

        public void Insertar(Transporte t)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Transporte (Ruta, Capacidad, Tipo, HoraRutaInicio, LugarRutaInicio, HoraDestinoFin, DestinoRutaFin)
                                 VALUES (@Ruta, @Capacidad, @Tipo, @HoraRutaInicio, @LugarRutaInicio, @HoraDestinoFin, @DestinoRutaFin)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ruta", t.Ruta);
                cmd.Parameters.AddWithValue("@Capacidad", t.Capacidad);
                cmd.Parameters.AddWithValue("@Tipo", t.Tipo);
                cmd.Parameters.AddWithValue("@HoraRutaInicio", t.HoraRutaInicio);
                cmd.Parameters.AddWithValue("@LugarRutaInicio", t.LugarRutaInicio);
                cmd.Parameters.AddWithValue("@HoraDestinoFin", t.HoraDestinoFin);
                cmd.Parameters.AddWithValue("@DestinoRutaFin", t.DestinoRutaFin);
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Transporte t)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Transporte SET Ruta=@Ruta, Capacidad=@Capacidad, Tipo=@Tipo,
                                 HoraRutaInicio=@HoraRutaInicio, LugarRutaInicio=@LugarRutaInicio,
                                 HoraDestinoFin=@HoraDestinoFin, DestinoRutaFin=@DestinoRutaFin
                                 WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", t.Id);
                cmd.Parameters.AddWithValue("@Ruta", t.Ruta);
                cmd.Parameters.AddWithValue("@Capacidad", t.Capacidad);
                cmd.Parameters.AddWithValue("@Tipo", t.Tipo);
                cmd.Parameters.AddWithValue("@HoraRutaInicio", t.HoraRutaInicio);
                cmd.Parameters.AddWithValue("@LugarRutaInicio", t.LugarRutaInicio);
                cmd.Parameters.AddWithValue("@HoraDestinoFin", t.HoraDestinoFin);
                cmd.Parameters.AddWithValue("@DestinoRutaFin", t.DestinoRutaFin);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Transporte WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }    
}
