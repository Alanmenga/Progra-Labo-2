using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Rol
    {
        administrador,
        estudiante
    }
    public class Usuario
    {
        public string usuario { get; }
        //La contraseña tiene que guardarse de forma hasheada
        //La contraseña tiene que guardarse de forma hasheada
        public string contraseña { get; }
        public Rol rol { get; }
        public static List<Usuario> listaUsuarios = new List<Usuario>()
        {
            new Administrador("admin1", "prueba01", Rol.administrador, "Ruben", "Miranda", "director", "ASD123"),
            new Administrador("admin2", "prueba01", Rol.administrador, "Carlos", "Centirion", "profesor", "ASD124"),
            new Administrador("admin3", "prueba01", Rol.administrador, "Mariano", "Lopez", "jefe de catedra", "ASD125"),
            new Estudiante("juanr", "J1234", Rol.estudiante, "Juan","Mengoni",39669992,"calle falsa 123",1140432123,"JuanM@gmail.com",true),
            new Estudiante("ana", "A1234", Rol.estudiante, "Ana", "Gomez", 87654321, "Calle 456",42948358,"anagomez@gmail.com",false),
            new Estudiante("carlos", "CZ1234", Rol.estudiante, "Carlos", "Rodriguez", 78901234, "Calle 789",49285432,"carlos.r@gmail.com",false)
        };

        public Usuario(string usuario, string contraseña, Rol rol)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.rol = rol;
        }

        public static void AgregarUsuario(Estudiante estudiante)
        {
            listaUsuarios.Add(estudiante);
        }
        public static void AgregarUsuario(Administrador administrador)
        {
            listaUsuarios.Add(administrador);
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            return listaUsuarios;
        }

        public static bool UsuarioExiste(string usuario, string contraseña)
        {

            return listaUsuarios.Exists(admin => admin.usuario == usuario && admin.contraseña == contraseña);
        }

        public static Rol ObtenerRolUsuario(string usuarioBuscado)
        {
            //listaUsuarios.Exists(admin => admin.usuario == usuario);
            Usuario usuarioEncontrado = listaUsuarios.FirstOrDefault(usu => usu.usuario == usuarioBuscado);
            return usuarioEncontrado.rol;
        }
    }
}
