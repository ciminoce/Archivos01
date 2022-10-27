using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos01.Entidades;

namespace Archivos01.Datos
{
    public class RepositorioAlumnos
    {
        private List<Alumno> listaAlumnos;

        public RepositorioAlumnos()
        {
            listaAlumnos = new List<Alumno>();
            var a1 = new Alumno() {Legajo = 1315, Nombre = "John", Apellido = "MCCarrone"};
            var a2 = new Alumno() {Legajo = 1500, Nombre = "Brandy", Apellido = "Talore"};
            Agregar(a1);
            Agregar(a2);

        }

        public void Agregar(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public List<Alumno> GetLista()
        {
            return listaAlumnos;
        }
    }
}
