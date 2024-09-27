using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDeDatos
{
    public class DBPlatarformaEducativa
    {
        //Cadena de conexion con la base de datos
        private string conexion = "Cadena";

        //Procedimiento Agregar Curso
        public void AgregarCurso(string nombre, string descripcion, int duracion)
        {
            using (SqlConnection conectar = new SqlConnection(conexion))
            {
                conectar.Open();
                string query = "INSERT INTO PlatarformaEducativaDB (nombre, descripcion, duracion) " +
                               "VALUES (@nombre, @descripcion, @duracion)";

                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@duracion", duracion);

            }
        }
        //Procedimiento Leer cursos
        public List<string> ObtenerCursos()
        {
            List<string> cursos = new List<string>();
            using (SqlConnection conectar = new SqlConnection(conexion))
            {
                conectar.Open();
                string query = "SELECT * FROM PlatarformaEducativaDB";
                SqlCommand cmd = new SqlCommand(query, conectar);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string curso = $"ID: {reader["id"]}, nombre: {reader["nombre"]}";
                        cursos.Add(curso);
                    }
                }
            }
            return cursos;
        }
    }
}
