using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_8_3_17__Entrenador_
{
    class Partido
    {
        private List<Estadistica> est = new List<Estadistica>();
        private List<string> jugadores = new List<string>();

        public List<Estadistica> Est
        {
            get { return est; }
            set { est = value; }
        }

        public List<string> Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }

        public Partido(List<string> Jugadores1)
        {
            this.jugadores = Jugadores1;
            for (int i = 0; i < this.jugadores.Count; i++)
            {
                Estadistica Estpj = new Estadistica();
                this.est.Add(Estpj);
            }
        }
    }
}
