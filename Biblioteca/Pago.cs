using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pago
    {
        private string idPago;
        private string legajoEstudiante;
        private string concepto;
        private bool pagado;
        private DateTime fechaVencimiento;
        public static List<Pago> listaPagos = new List<Pago>()
        {
            new Pago("ASD123","ASD12","Cuota 2/12",true,DateTime.Now),
            new Pago("ASD124","ASD12","Cuota 3/12",true, DateTime.Now),
            new Pago("ASD125","ASD12","Cuota 4/12",false, DateTime.Now),
            new Pago("ASD126","ASD14","Cuota 5/12",false, DateTime.Now),
            new Pago("ASD127","ASD14","Matriculacion",false, DateTime.Now),
            new Pago("ASD128","ASD14","Materiales",true, DateTime.Now),
        };

        public Pago(string idPago, string legajoEstudiante, string concepto, bool pagado, DateTime fechaVencimiento)
        {
            this.idPago = idPago;
            this.legajoEstudiante = legajoEstudiante;
            this.concepto = concepto;
            this.pagado = pagado;
            this.fechaVencimiento = fechaVencimiento;
        }

        public static void AgregarPago(string idPago, string legajoEstudiante, string concepto, bool pagado, DateTime fechavencimiento)
        {
            Pago pagoNuevo = new Pago(idPago, legajoEstudiante, concepto, pagado, fechavencimiento);
            if (ValidarPago(pagoNuevo))
            {
                listaPagos.Add(pagoNuevo);
            }
        }

        public static bool ValidarPago(Pago pagoIngresado)
        {
            return listaPagos.Contains(pagoIngresado);
        }

        public static List<Pago> FiltrarPagosPorEstudiante(Estudiante estudianteBuscado)
        {
            
            return 
        }
    }
}
