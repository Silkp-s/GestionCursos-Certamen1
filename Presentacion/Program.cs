using System;
using System.Collections.Generic;
using AccesoDeDatos;
using LogicaDeNegocios;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            DBPlatarformaEducativa platarformaEducativa = new DBPlatarformaEducativa();

            while (true)
            {
                //Opciones del programa
                Console.WriteLine("1. Agregar un curso");
                Console.WriteLine("2. Lista de cursos");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    //Agregar un curso
                    case "1":
                        Console.Write("Nombre del curso: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Descripcion del curso: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Duracion del curso:");
                        int duracion = int.Parse(Console.ReadLine());

                        try
                        {
                            platarformaEducativa.AgregarCurso(nombre, descripcion, duracion);
                            Console.WriteLine("Curso agregado exitosamente.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                        //Lista curos
                    case "2":
                        List<string> cursos = platarformaEducativa.ObtenerCursos();
                        Console.WriteLine("Lista de Cursos");
                        foreach (var curso in cursos)
                        {
                            Console.WriteLine(curso);
                        }
                        break;
                        //Ssalir del programa
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            }
        }
    }
}
