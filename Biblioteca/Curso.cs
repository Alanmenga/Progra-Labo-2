using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Curso
    {
        public string nombre { get; set;  }
        public string codigo { get; set;  }
        public string descripcion { get; set;  }
        public  int cupo { get; set;  }
        public static List<Curso> listaCursos = new List<Curso>()
        {
            new Curso("Programacion","ASD123","Programacion 3 Division E",200),
            new Curso("Laboratorio","ASD124","Laboratorio 3 Division E",200),
            new Curso("Estadistica","ASD125","Estadistica 3 Division E",200),
            new Curso("Ingles","ASD126","Ingles 3 Division E",200),
            new Curso("Contabilidad","ASD127","Contabilidad 3 Division E",200),
            new Curso("Inv Operativa","ASD128","Investigacion Operativa 3 Division E",200),
        };


        public Curso(string nombre, string codigo, string descripcion, int cupo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cupo = cupo;
        }

        public static void AgregarCurso(string nombre, string codigo, string descripcion, int cupo)
        {
            Curso cursoIngresado = new Curso(nombre, codigo, descripcion, cupo);
            listaCursos.Add(cursoIngresado); 
        }

        public static bool EliminarCurso(string codigo)
        {
            Curso cursoEliminar = listaCursos.FirstOrDefault(curso => curso.codigo == codigo);
            if(cursoEliminar != null)
            {
                listaCursos.Remove(cursoEliminar);
                return true;
            }
            return false;
        }

        public static void EditarCurso(string codigo, string nombreNuevo, string codigoNuevo, string descripcionNuevo, int cupoNuevo)
        {
            Curso cursoEditar = listaCursos.FirstOrDefault(curso => curso.codigo == codigo);
            cursoEditar.nombre = nombreNuevo;
            cursoEditar.descripcion = descripcionNuevo;
            cursoEditar.codigo = codigoNuevo;
            cursoEditar.cupo = cupoNuevo;
        }
        public static void EditarCurso(string codigo,string nombreNuevo, string descripcionNuevo, int cupoNuevo)
        {
            Curso cursoEditar = listaCursos.FirstOrDefault(curso => curso.codigo == codigo);
            cursoEditar.nombre = nombreNuevo;
            cursoEditar.descripcion = descripcionNuevo;
            cursoEditar.cupo = cupoNuevo;
        }

        public static Curso RecuperarCursoConCodigo(string codigoBuscado)
        {
            Curso cursoEncontrado = listaCursos.FirstOrDefault(curso => curso.codigo == codigoBuscado);
            return cursoEncontrado;
        }

    }
}
