using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

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
        public bool cambiarContraseña;
        public static int contadorEstudiantes = 1000;
        public static List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public static List<Estudiante> listaEstudiantesRecuperados = new List<Estudiante>();
        public static List<Curso> listaCursosInscriptos = new List<Curso>();

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
            this.legajo = ++contadorEstudiantes;
            this.cambiarContraseña = cambiarContraseña;
        }

        public Estudiante(int legajo,
                          string usuario,
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
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.legajo = ++contadorEstudiantes;
            this.cambiarContraseña = cambiarContraseña;
        }


        public static void AgregarEstudiante(Estudiante estudiante)
        {
            AgregarEstudianteArchivo(estudiante);
            AgregarUsuario(estudiante);
            listaEstudiantes.Add(estudiante);
        }

        public static void AgregarEstudiantesRecuperados()
        {
            foreach (Estudiante estudiante in listaEstudiantesRecuperados)
            {
                AgregarUsuario(estudiante);
                listaEstudiantes.Add(estudiante);
            }
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

        public static void AgregarCursoEstudiante(Curso cursoInscribir)
        {
            if(cursoInscribir != null)
            {
                listaCursosInscriptos.Add(cursoInscribir);
            }
        }

        public static void RecuperarEstudiantesDeArchivo()
        {
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Estudiantes.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    foreach (string linea in File.ReadLines(rutaArchivo))
                    {
                        // Dividir la línea en partes usando comas como separadores
                        string[] partes = linea.Split(',');

                        if (partes.Length == 11)
                        {
                            // Eliminar comillas y espacios en blanco de cada parte
                            for (int i = 0; i < partes.Length; i++)
                            {
                                partes[i] = partes[i].Trim(' ', '"');
                            }

                            Estudiante estudianteNuevo = new Estudiante(int.Parse(partes[0]), partes[1], partes[2], ConversorStringARol(partes[3]), partes[4], partes[5], int.Parse(partes[6]), partes[7], int.Parse(partes[8]), partes[9], ConversorStringABool(partes[10]));
                            listaEstudiantesRecuperados.Add(estudianteNuevo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los estudiantes: {ex.Message}");
            }
        }



        public static void AgregarEstudianteArchivo(Estudiante estudiante)
        {
            Hash hash = new Hash();
            var contraseñaHasheada = hash.GetHash(estudiante.contraseña);

            string contenido = $"{estudiante.legajo}, {estudiante.usuario}, {contraseñaHasheada}, {estudiante.rol}, {estudiante.nombre}, {estudiante.apellido}, {estudiante.dni}, {estudiante.direccion}, {estudiante.telefono}, {estudiante.correoElectronico}, {estudiante.cambiarContraseña} ";
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Estudiantes.txt";

            try
            {
                // Verifica si el archivo ya existe
                if (File.Exists(rutaArchivo))
                {
                    // Si el archivo existe, guarda el contenido en él
                    File.AppendAllText(rutaArchivo, "\n");
                    File.AppendAllText(rutaArchivo, contenido);
                }
                else
                {
                    // Si el archivo no existe, crea uno nuevo y guarda el contenido en él
                    File.WriteAllText(rutaArchivo, contenido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los estudiantes: {ex.Message}");
            }
        }

        public static void EliminarListas()
        {
            contadorEstudiantes = 1000;
            listaEstudiantes.Clear();
            listaEstudiantesRecuperados.Clear();
        }


        public static bool ValidacionEstudianteDuplicado(int legajo)
        {
            bool estaRegistrado = false;
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if(estudiante.legajo == legajo)
                {
                    estaRegistrado = true;
                }
            }
            return estaRegistrado;
        }

    }
}