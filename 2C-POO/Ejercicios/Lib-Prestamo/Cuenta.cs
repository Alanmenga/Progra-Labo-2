using System.Text;

namespace Lib_Prestamo
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta( string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular() 
        { 
            return this.titular;
        }

        public int GetCantidad()
        {
            return this.cantidad;
        }

        public static string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine
        }
    }
}