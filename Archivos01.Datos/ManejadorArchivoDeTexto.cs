using System.Collections.Generic;
using System.IO;
using System.Text;
using Archivos01.Entidades;

namespace Archivos01.Datos
{
    public static class ManejadorArchivoDeTexto
    {
        public static void Guardar(string archivo,List<Alumno> alumnos)
        {
            using (var escritor=new StreamWriter(archivo))
            {
                foreach (var alumno in alumnos)
                {
                    var linea = ConstruirLinea(alumno);
                    escritor.WriteLine(linea);
                }
            }
        }

        public static void GuardarTodo(string archivo, List<Alumno> alumnos)
        {
           
            var lineas = ConstruirLineas(alumnos);
            File.WriteAllLines(archivo,lineas);    
        }

        public static void GuardarTexto(string archivo, List<Alumno> alumnos)
        {
            var texto = ConstruirTexto(alumnos);
            File.WriteAllText(archivo,texto);
        }

        private static string[] ConstruirLineas(List<Alumno> alumnos)
        {
            List<string> lista = new List<string>();
            foreach (var alumno in alumnos)
            {
                lista.Add(ConstruirLinea(alumno));
            }

            return lista.ToArray();
        }
        private static string ConstruirTexto(List<Alumno> alumnos)
        {
            StringBuilder sb=new StringBuilder();
            foreach (var alumno in alumnos)
            {
                sb.AppendLine(ConstruirLinea(alumno));
            }

            return sb.ToString();
        }


        private static string ConstruirLinea(Alumno alumno)
        {
            return $"{alumno.Legajo}|{alumno.Nombre}|{alumno.Apellido}";
        }

    }
}
