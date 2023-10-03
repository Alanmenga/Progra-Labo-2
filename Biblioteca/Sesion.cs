using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sesion
    {
        private int idSesion = 0;
        private int idUsuario;
        private DateTime fechaInicio;
        private DateTime? fechaFin;


        public Sesion( int idUsuario, DateTime fechaInicio)
        {
            this.idSesion++;
            this.idUsuario = idUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFin = null;
        }

        public void CerrarSesion(DateTime fechaFin)
        {
            this.fechaFin = fechaFin;
        }

        public Estudiante RecuperarEstudiantePorUsuario(int idUsuario)
        {
            return Estudiante.RecuperarEstudianteConLegajo(idUsuario);
        }

    }

}
