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
        estudiante,
        profesor
    }
    public class Usuario
    {
        public string usuario { get; }
        public string contraseña { get; }
        public Rol rol { get; }
        public static List<Usuario> listaUsuarios = new List<Usuario>();

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
        public static void AgregarUsuario(Profesor profesor)
        {
            listaUsuarios.Add(profesor);
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
            Usuario usuarioEncontrado = listaUsuarios.FirstOrDefault(usu => usu.usuario == usuarioBuscado);
            return usuarioEncontrado.rol;
        }

        public static Rol ConversorStringARol(string rolRecuperado)
        {
            if (rolRecuperado == "Rol.administrador")
            {
                return Rol.administrador;
            }
            else if (rolRecuperado == "Rol.profesor")
            {
                return Rol.profesor;
            }
            else
            {
                return Rol.estudiante;
            }
        }

        public static bool ConversorStringABool(string stringRecupereado)
        {
            if(stringRecupereado == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
