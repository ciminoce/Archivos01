using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos01.Entidades;

namespace Archivo01.Datos
{
    public class RepositorioDePersonas
    {
        private List<Alumno> listaAlumnos;

        public RepositorioDePersonas()
        {
            listaAlumnos = new List<Alumno>();
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            listaAlumnos = ManejadorDeArchivoSecuencial.LeerDatos();
        }

        public void Agregar(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
            ManejadorDeArchivoSecuencial.Guardar(alumno);
            
        }

        public void AgregarTodo(List<Alumno> lista)
        {
            ManejadorDeArchivoSecuencial.GuardarTodoTexto(lista);
        }

        public void AgregarTodoArray(List<Alumno> lista)
        {
            ManejadorDeArchivoSecuencial.GuardarTextArray(lista);
        }
        public void Borrar(Alumno alumno)
        {
            listaAlumnos.Remove(alumno);
        }

        public List<Alumno> GetLista() => listaAlumnos;
        public int GetCantidad() => listaAlumnos.Count;
    }
}
