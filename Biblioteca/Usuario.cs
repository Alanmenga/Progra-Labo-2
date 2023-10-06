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
            //contraseña prueba01
            new Administrador("admin1", "$2a$08$2MPNLN7pOlbrODlagxpMaOpAZ3FGsop61mrFwc/EgyHXeM4YfhlTC", Rol.administrador, "Ruben", "Miranda", "director", "ASD123"),
            //contraseña prueba02
            new Administrador("admin2", "$2a$08$YlGeG8R9vJELLMO22UzoDeK/5lFb2D1M4EISSQlmTveloIDF4pehi", Rol.administrador, "Carlos", "Centirion", "profesor", "ASD124"),
            //contraseña prueba01
            new Administrador("admin3", "$2a$08$2MPNLN7pOlbrODlagxpMaOpAZ3FGsop61mrFwc/EgyHXeM4YfhlTC", Rol.administrador, "Mariano", "Lopez", "jefe de catedra", "ASD125"),
            new Estudiante("juanr", "$2a$08$2MPNLN7pOlbrODlagxpMaOpAZ3FGsop61mrFwc/EgyHXeM4YfhlTC", Rol.estudiante, "Juan","Mengoni",39669992,"calle falsa 123",1140432123,"JuanM@gmail.com",true),
            new Estudiante("ana", "$2a$08$2MPNLN7pOlbrODlagxpMaOpAZ3FGsop61mrFwc/EgyHXeM4YfhlTC", Rol.estudiante, "Ana", "Gomez", 87654321, "Calle 456",42948358,"anagomez@gmail.com",false),
            new Estudiante("carlos", "$2a$08$2MPNLN7pOlbrODlagxpMaOpAZ3FGsop61mrFwc/EgyHXeM4YfhlTC", Rol.estudiante, "Carlos", "Rodriguez", 78901234, "Calle 789",49285432,"carlos.r@gmail.com",false)
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
            Hash hash = new Hash();
            return listaUsuarios.Exists(admin => admin.usuario == usuario && hash.ValidatePassword(contraseña, admin.contraseña));
        }

        public static Rol ObtenerRolUsuario(string usuarioBuscado)
        {
            //listaUsuarios.Exists(admin => admin.usuario == usuario);
            Usuario usuarioEncontrado = listaUsuarios.FirstOrDefault(usu => usu.usuario == usuarioBuscado);
            return usuarioEncontrado.rol;
        }
    }
}
