using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        //Este metodo deberia recibir un administrador como parametro de entrada
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

                            AgregarAdministrador
                            (
                                partes[0],
                                partes[1],
                                ConversorStringARol(partes[2]),
                                partes[3],
                                partes[4],
                                partes[5],
                                partes[6]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo recuperar los administradores: {ex.Message}");
            }
        }

    }
}
