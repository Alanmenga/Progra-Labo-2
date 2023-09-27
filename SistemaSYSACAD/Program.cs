using Biblioteca;
using System.Runtime.CompilerServices;

namespace SistemaSYSACAD
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool seLogueo = Metodos.LoguearAdmin();
            int opcionPanel = Metodos.PanelAdministracion(seLogueo);

            switch (opcionPanel) 
            { 
                case 1: Console.WriteLine("Vas a registar un estudiante");
                    Metodos.FormularioEstudiante();
                    break;
                default: Console.WriteLine("Opcion ingresada incorrecta");
                    break;
            } 
        }

        public class Metodos
        {
            public static bool LoguearAdmin()
            {
                Console.WriteLine("---------Sistema de administración de inscripciones---------");
                Console.Write("Ingresa tu usuario: ");
                string usuarioIngresado = Console.ReadLine();
                Console.Write("Ingresa tu contraseña: ");
                string contraseñaIngresada = Console.ReadLine();

                bool usuarioRegistrado = Administrador.UsuarioExiste(usuarioIngresado, contraseñaIngresada);
                string mensaje = usuarioRegistrado
                    ? $"Ingresado al sistema '{usuarioIngresado}'....."
                    : "El usuario o la contraseña son incorrectos";

                Console.WriteLine(mensaje);
                return usuarioRegistrado;
            }

            public static int PanelAdministracion( bool estaLogueado)
            {
                int opcion;
                if(estaLogueado)
                {
                    Console.WriteLine($"----------Panel de administración.----------");
                    Console.WriteLine("1-Registrar estudiante (admin)");
                    Console.WriteLine("2-Gestionar cursos (admin)");
                    Console.WriteLine("3-Inscripcion a curso (estud)");
                    Console.WriteLine("4-Consultar horario (estud)");
                    Console.WriteLine("5-Realizar pagos (estud)");
                    Console.Write("Ingrese numero de la opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                }
                else
                {
                    opcion = 0;
                }
                return opcion;
            }

            public static void FormularioEstudiante()
            {
                Console.WriteLine("---------Formulario inscripcion estudiante---------");
                Console.Write("Ingresa nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingresa apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Ingresa dni: ");
                int dni = int.Parse(Console.ReadLine());
                Console.Write("Ingresa direccion: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingresa telefono: ");
                int telefono = int.Parse(Console.ReadLine());
                Console.Write("Ingresa correo electronico: ");
                string correoElectronico = Console.ReadLine();
                Console.Write("Ingresa contraseña provisional: ");
                string contraseñaProvisional = Console.ReadLine();
                Console.Write("Debe cambiar su contraseña provisional en su primer inicio de sesión?: ");
                bool cambiarContraseña = Boolean.Parse(Console.ReadLine());

                Estudiante.AgregarEstudiante(nombre, apellido, dni, direccion, telefono, correoElectronico, contraseñaProvisional, cambiarContraseña);
                Estudiante.MostrarEstudiantes();
            }
        }

        public static void RegistrarEstudiante()
        {
            
        }
        
    }
}