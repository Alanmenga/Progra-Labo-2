using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Administrador : Usuario
    {
        public string nombre;
        public string apellido;
        public string cargo;
        public string matricula;
        public static List<Administrador> listaAdministradores = new List<Administrador>(); 

        public Administrador(string usuario, string contraseña, Rol rol, string nombre, string apellido,string cargo, string matricula)
            : base(usuario, contraseña, rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.matricula = matricula;  
        }

        public static void AgregarAdministrador(string usuario, string contraseña, Rol rol, string nombre, string apellido, string cargo, string matricula)
        {
            Administrador administradorNuevo = new Administrador(usuario, contraseña, rol, nombre, apellido, cargo, matricula);
            AgregarUsuario(administradorNuevo);
            listaAdministradores.Add(administradorNuevo);
        }

        public static List<Administrador> ObtenerAdministradores()
        {
            return listaAdministradores;
        }

        //public static bool AdministradorExiste(string usuario, string contraseña)
        //{
        //    return listaAdministradores.Exists(admin => admin.usuario == usuario && admin.contraseña == contraseña);
        //}

    }
}
