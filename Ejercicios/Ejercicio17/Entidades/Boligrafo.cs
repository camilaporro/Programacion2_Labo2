using System.Text;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
         
            short tintaGastada = 0;
            string dibujoAux = "";
            bool retornoAux;

            
            if(this.tinta == 0) 
            { 
                dibujo = "No hay tinta. No se pudo pintar";
                retornoAux = false;
            }
            else
            {
                while(this.tinta > 0 && tintaGastada < gasto) 
                {
                    dibujoAux += "*";
                    tintaGastada++;
                    this.SetTinta(-1);
                }

                dibujo = dibujoAux;
                retornoAux = true;
            }

            return retornoAux;

        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta) 
        {
 
            if(tinta > 0) { this.CargarTinta(tinta); }
            else { this.GastarTinta(tinta); }

        }

        private void CargarTinta(short tinta)
        {
            if(this.tinta + tinta > cantidadTintaMaxima) { this.tinta = cantidadTintaMaxima;}
            else { this.tinta += tinta;}
            
        }

        private void GastarTinta(short tinta)
        {
            //tinta es un numero negativo, por regla de signos se suma
            //this.tinta =50; tinta = -10 (50 + (-10) = 40) --> esta ok
            //this.tinta =50; tinta = -10 (50 - (-10) = 60) --> esta mal, no gasta tinta
            if (this.tinta + tinta < 0) { this.tinta = 0; }
            else { this.tinta += tinta; }
            
        }

    }
}