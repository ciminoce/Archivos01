using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo01.Datos;
using Archivos01.Entidades;

namespace Archivos01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new RepositorioDePersonas();
            var p = new Alumno() { Legajo = 1315, Nombre = "John", Apellido = "McCarrone" };
            repo.Agregar(p);
            var a2 = new Alumno() { Legajo = 1888, Nombre = "Brandy", Apellido = "Talore" };
            repo.Agregar(a2);
            repo.AgregarTodo(repo.GetLista());
            repo.AgregarTodoArray(repo.GetLista());
            //if (repo.GetCantidad()>0)
            //{
            //    var lista = repo.GetLista();
            //    MostrarLista(lista);

            //}
            //else
            //{
            //    Console.WriteLine("No hay datos en el archivo");
            //}

            Console.ReadLine();
        }

        private static void MostrarLista(List<Alumno> lista)
        {
            Console.Clear();
            foreach (var alumno in lista)
            {
                Console.WriteLine(alumno.NombreCompleto);
            }
        }
    }
}
