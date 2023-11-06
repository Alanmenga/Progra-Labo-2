using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
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
        public static List<Administrador> listaAdministradoresRecuperados = new List<Administrador>();

        public Administrador(string usuario, string contraseña, Rol rol, string nombre, string apellido,string cargo, string matricula)
            : base(usuario, contraseña, rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.matricula = matricula;  
        }

        public static void AgregarAdministrador(Administrador administrador)
        {
            Administrador administradorNuevo = new Administrador(administrador.usuario, administrador.contraseña, administrador.rol, administrador.nombre, administrador.apellido, administrador.cargo, administrador.matricula);
            AgregarUsuario(administradorNuevo);
            listaAdministradores.Add(administradorNuevo);
        }

        public static void AgregarAdministradoresRecuperados()
        {
            foreach (Administrador administrador in listaAdministradoresRecuperados)
            {
                AgregarUsuario(administrador);
                listaAdministradores.Add(administrador);
            }
        }

        public static void RecuperarAdministradorDeArchivos()
        {
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Administradores.txt";

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

                            Administrador administradorNuevo = new Administrador(partes[0],partes[1],ConversorStringARol(partes[2]),partes[3],partes[4],partes[5],partes[6]);
                            listaAdministradoresRecuperados.Add(administradorNuevo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los administradores: {ex.Message}");
            }
        }

        public static void RecuperarAdministradorDeArchivosJson()
        {
            string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\Archivos\Administradores.json";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);
                    var data = JsonSerializer.Deserialize<List<AdministradorI>>(json);
                    foreach (AdministradorI administrador in data)
                    {
                        Administrador administradorNuevo = new Administrador(administrador.usuario, administrador.contraseña, ConversorStringARol(administrador.rol.ToString()), administrador.nombre,administrador.apellido, administrador.cargo, administrador.matricula);
                        listaAdministradoresRecuperados.Add(administradorNuevo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los administradores: {ex.Message}");
            }
        }

        public class AdministradorI
        {
            public string usuario { get; set; }
            public string contraseña { get; set; }
            public string rol { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string cargo { get; set; }
            public string matricula { get; set; }
        }


        public static void EliminarListas()
        {
            listaAdministradores.Clear();
            listaAdministradoresRecuperados.Clear();
        }

    }
}
