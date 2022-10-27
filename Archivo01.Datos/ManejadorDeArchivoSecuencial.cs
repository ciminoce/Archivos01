using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos01.Entidades;

namespace Archivo01.Datos
{
    public static class ManejadorDeArchivoSecuencial
    {
        private static string archivo = "Alumnos.txt";
        private static string archivo2 = "AlumnosTexto.txt";
        private static string archivo3 = "AlumnosArray.txt";

        public static void GuardarTextArray(List<Alumno> lista)
        {
            var arrayLineas = ConstruirArrayLineas(lista);
            File.WriteAllLines(archivo3,arrayLineas);
        }

        private static string[] ConstruirArrayLineas(List<Alumno> lista)
        {
            List<string> listaStrings = new List<string>();
            foreach (var alumno in lista)
            {
                listaStrings.Add(ConstruirLinea(alumno));
            }

            return listaStrings.ToArray();
        }

        public static void GuardarTodoTexto(List<Alumno> lista)
        {
            var textoAlumnos = ConstruirTexto(lista);
            File.WriteAllText(archivo2,textoAlumnos);
        }

        private static string ConstruirTexto(List<Alumno> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var alumno in lista)
            {
                sb.AppendLine(ConstruirLinea(alumno));
            }

            return sb.ToString();
        }

        public static void Guardar(Alumno alumno)
        {
            using (var escritor=new StreamWriter(archivo,true))
            {
                var linea = ConstruirLinea(alumno);
                escritor.WriteLine(linea);
            }
        }

        private static string ConstruirLinea(Alumno alumno)
        {
            return $"{alumno.Legajo}|{alumno.Nombre}|{alumno.Apellido}";
        }

        public static List<Alumno> LeerDatos()
        {
            List<Alumno> lista = new List<Alumno>();
            if (!File.Exists(archivo))
            {
                return lista;
            }

            using (var lector=new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Alumno a = ConstruirAlumno(linea);
                    lista.Add(a);
                }
            }

            return lista;
        }

        private static Alumno ConstruirAlumno(string linea)
        {
            var campos = linea.Split('|');
            Alumno alumno = new Alumno()
            {
                Legajo = int.Parse(campos[0]),
                Nombre = campos[1],
                Apellido = campos[2]
            };
            return alumno;
        }
    }
}
