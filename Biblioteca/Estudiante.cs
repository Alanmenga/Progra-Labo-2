using System.Net.NetworkInformation;

namespace Biblioteca
{
    public class Estudiante : Usuario
    {
        public int legajo;
        public string nombre;
        public string apellido;
        public int dni;
        public string direccion;
        public int telefono;
        public string correoElectronico;
        public string contraseña;
        public bool cambiarContraseña;
        public static int contadorEstudiantes = 1000;
        public static List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public static List<Curso> cursosInscriptos = new List<Curso>()
        {
            new Curso("Algebra","ASD123","Programacion 3 Divicion E",200),
            new Curso("Quimica","ASD124","Laboratorio 3 Divicion E",200),
            new Curso("Materiales Metalicos","ASD125","Estadistica 3 Divicion E",200),
            new Curso("Ingles","ASD126","Ingles 3 Divicion E",200),
            new Curso("Empresarial","ASD127","Contabilidad 3 Divicion E",200),
            new Curso("Legislacion","ASD128","Investigacion Operativa 3 Divicion E",200),
        };



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

        public Estudiante RecuperarEstudianteConUsuario(string usuarioBuscado)
        {
            Estudiante estudianteEncontrado = listaEstudiantes.FirstOrDefault(est => est.usuario == usuarioBuscado);
            return estudianteEncontrado;
        }

        public static Estudiante RecuperarEstudianteConLegajo(int legajoBuscado)
        {
            Estudiante estudianteEncontrado = listaEstudiantes.FirstOrDefault(est => est.legajo == legajoBuscado);
            return estudianteEncontrado;
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