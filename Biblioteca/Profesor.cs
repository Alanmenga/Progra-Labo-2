using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor : Usuario
    {
        public string nombre;
        public string apellido;
        public string materia;
        public string matricula;
        public static List<Profesor> listaProfesores = new List<Profesor>();
        public static List<Profesor> listaProfesoresRecuperados = new List<Profesor>();

        public Profesor(string usuario, string contraseña, Rol rol, string nombre, string apellido, string materia, string matricula)
            : base(usuario, contraseña, rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.materia = materia;
            this.matricula = matricula;
        }

        public static void AgregarProfesor(Profesor profesor)
        {
            Profesor profesorNuevo = new Profesor(profesor.usuario, profesor.contraseña, profesor.rol, profesor.nombre, profesor.apellido, profesor.materia, profesor.matricula);
            AgregarUsuario(profesorNuevo);
            listaProfesores.Add(profesorNuevo);
        }

        public static void AgregarProfesoresRecuperados()
        {
            foreach (Profesor profesor in listaProfesoresRecuperados)
            {
                AgregarUsuario(profesor);
                listaProfesores.Add(profesor);
            }
        }

        public static void RecuperarProfesorDeArchivos()
        {
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Profesores.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    foreach (string linea in File.ReadLines(rutaArchivo))
                    {
                        // Dividir la línea en partes usando comas como separadores
                        string[] partes = linea.Split(',');

                        if (partes.Length == 7)
                        {
                            // Eliminar comillas y espacios en blanco de cada parte
                            for (int i = 0; i < partes.Length; i++)
                            {
                                partes[i] = partes[i].Trim(' ', '"');
                            }

                            Profesor profesorNuevo = new Profesor(partes[0], partes[1], ConversorStringARol(partes[2]), partes[3], partes[4], partes[5], partes[6]);
                            listaProfesoresRecuperados.Add(profesorNuevo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los profesores: {ex.Message}");
            }
        }

        public static void AgregarProfesorArchivo(Profesor profesor)
        {
            Hash hash = new Hash();
            var contraseñaHasheada = hash.GetHash(profesor.contraseña);

            string contenido = $"{profesor.usuario}, {contraseñaHasheada}, {profesor.rol}, {profesor.nombre}, {profesor.apellido}, {profesor.materia}, {profesor.matricula}";
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Profesores.txt";

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
                Console.WriteLine($"No se pudo agregar los profesores: {ex.Message}");
            }
        }

        public static void RecuperarProfesorDeArchivosJson()
        {
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Profesores.json";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);
                    var data = JsonSerializer.Deserialize<List<ProfesorI>>(json);
                    foreach (ProfesorI administrador in data)
                    {
                        Profesor profesorNuevo = new Profesor(administrador.usuario, administrador.contraseña, ConversorStringARol(administrador.rol.ToString()), administrador.nombre, administrador.apellido, administrador.cargo, administrador.matricula);
                        listaProfesoresRecuperados.Add(profesorNuevo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los profesores: {ex.Message}");
            }
        }

        public class ProfesorI
        {
            public string usuario { get; set; }
            public string contraseña { get; set; }
            public string rol { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string materia { get; set; }
            public string matricula { get; set; }
        }


        public static void EliminarListasProfesores()
        {
            listaProfesores.Clear();
            listaProfesoresRecuperados.Clear();
        }

    }
}
