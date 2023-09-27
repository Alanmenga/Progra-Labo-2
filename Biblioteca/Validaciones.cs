using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Validaciones
    {
        public static bool ValidarNombre(string nombre)
        {
            // Expresión regular para permitir letras y espacios en blanco
            string patron = "^[A-Za-zÁÉÍÓÚáéíóúÜüñÑ\\s]+$";
            return Regex.IsMatch(nombre, patron);
        }

        public static bool ValidadDni(string dni)
        {
            // Expresión regular para validar un número de 8 dígitos
            string patron = @"^\d{8}$";
            return Regex.IsMatch(dni, patron);
        }

        public static bool ValidarDireccion(string direccion)
        {
            // Expresión regular para permitir letras, numeros y espacios en blanco
            string patron = @"^[a-zA-Z0-9\s]+$";
            return Regex.IsMatch(direccion, patron);
        }

        public static bool ValidarTelefono(string telefono)
        {
            // Expresión regular para validar un número de 10 dígitos
            string patron = @"^\d{10}$";
            return Regex.IsMatch(telefono, patron);
        }

        public static bool ValidarCorreo(string correo)
        {
            // Expresión regular para validar un número de 10 dígitos
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(correo, patron);
        }

        public static bool ValidarContraseña(string contraseña)
        {
            // Expresión regular para validar un número de 10 dígitos
            string patron = @"^[A-Za-z0-9]{8}$";
            return Regex.IsMatch(contraseña, patron);
        }
    }
}
