using System.Net.NetworkInformation;

namespace Biblioteca
{
    public class Estudiante : Usuario
    {
        private int legajo { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int dni { get; set; }
        private string direccion { get; set; }
        private int telefono { get; set; }
        private string correoElectronico { get; set; }
        private string contraseña{ get; set; }
        private bool cambiarContraseña { get; set; }
        private static int contadorEstudiantes = 1000;
        public static List<Estudiante> listaEstudiantes = new List<Estudiante>();



        public Estudiante(string usuario,
                          string contraseña,
                          Rol rol,
                          string nombre, 
                          string apellido, 
                          int dni, 
                          string direccion, 
                          int telefono,
                          string correoElectronico,
                          bool cambiarContraseña)
            : base(usuario, contraseña, rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.contraseña = contraseña;
            this.legajo = ++contadorEstudiantes;
            this.cambiarContraseña = cambiarContraseña;
        }



        public static void AgregarEstudiante(string usuario,
                          string nombre,
                          string apellido,
                          Rol rol,
                          int dni,
                          string direccion,
                          int telefono,
                          string correoElectronico,
                          string contraseña,
                          bool cambiarContraseña)
        {
            Estudiante estudianteNuevo = new Estudiante(usuario, contraseña, rol, nombre, apellido, dni, direccion, telefono, correoElectronico, cambiarContraseña);
            AgregarUsuario(estudianteNuevo);
            listaEstudiantes.Add(estudianteNuevo);
        }



        //public static void MostrarEstudiantes()
        //{
        //    Console.WriteLine("Lista de Estudiantes");
        //    foreach (Estudiante estudiante in listaEstudiantes)
        //    {
        //        Console.WriteLine($"Legajo: {estudiante.legajo}, Nombre: {estudiante.nombre}, Apellido: {estudiante.apellido}, DNI: {estudiante.dni}") ;
        //    }
        //}
    }
}