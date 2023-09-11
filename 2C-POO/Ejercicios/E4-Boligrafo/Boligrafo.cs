using System.Drawing;

namespace E4_Boligrafo
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        public const short cantidadTintaMaxima = 100;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color; 
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta; 
        }

        private void SetTinta(short tintaIngresada) 
        {
            short nuevaTinta = (short)(this.tinta + tintaIngresada);
            if (nuevaTinta >= 0 && nuevaTinta <= cantidadTintaMaxima)
            {
                this.tinta += tintaIngresada;
                Console.WriteLine("la tinta ingresada se resto a la tinta total");
            }
            else
            {
                Console.WriteLine("la tinta ingresada no se pudo restar a la tinta total");
            }
        }

        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - this.tinta));
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short pinturaResultante = (short)(this.tinta - gasto);
            dibujo = new string('*', pinturaResultante);
            SetTinta((short)(cantidadTintaMaxima - gasto));
            bool seDibujo = pinturaResultante > 0;
            if (pinturaResultante>0 && pinturaResultante < 100 && tinta != 0)
            {
                Console.WriteLine("**");
            }
            else if(tinta == 0)
            {
                Console.WriteLine("--");
            }
            else if(pinturaResultante<0)
            {
                Console.WriteLine("***");
            }
            else
            {
                Console.WriteLine("Se me escapo el caso");
            }    
            return seDibujo;
        }
    }
}