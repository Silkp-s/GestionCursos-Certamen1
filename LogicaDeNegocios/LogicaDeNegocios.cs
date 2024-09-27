using System;
using System.Collections.Generic;
using AccesoDeDatos; 

namespace LogicaDeNegocios
{
    public class LogicaNegocios
    {
        DBPlatarformaEducativa PlatarformaEducativaDB = new DBPlatarformaEducativa();
        public void AgregarCurso(string nombre, string descripcion, int duracion)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion))
            {
                PlatarformaEducativaDB.AgregarCurso(nombre, descripcion, duracion);
            }
            else
            {
                throw new Exception("Datos invalidos, intentelo de nuevo");
            }
        }
        public List<string> ObtenerCursos()
        {
            return PlatarformaEducativaDB.ObtenerCursos();
        }
    }
}
