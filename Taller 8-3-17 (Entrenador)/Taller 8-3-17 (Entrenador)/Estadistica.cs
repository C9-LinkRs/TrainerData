using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_8_3_17__Entrenador_
{
    class Estadistica
    {
        public int TiempoJugado;
        public string Tarjetas;
        public int Posesion;
        public int PasesCorrectos;
        public int PasesErrados;
        public int TirosArco;
        public int Goles;
        Random rnd = new Random();

        public Estadistica()
        {
            int z;
            z = rnd.Next(1, 3);
            if (z == 1)
                this.Tarjetas = "Roja";
            else if (z == 2) this.Tarjetas = "Amarilla";
            else this.Tarjetas = "No Tiene";
            this.TiempoJugado = rnd.Next(0, 99);
            this.Posesion = rnd.Next(0, 15);
            this.PasesCorrectos = rnd.Next(0, 300);
            this.PasesErrados = rnd.Next(0, 100);
            this.TirosArco = rnd.Next(0, 10);
            this.Goles = rnd.Next(0, 5);
        }
    }
}
