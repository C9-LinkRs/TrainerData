using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_8_3_17__Entrenador_
{
    class Jugador
    {
        private string nombre;
        private int peso;
        private int estatura;
        private string posicion;
        private string equiposant;
        private List<Estadistica> stats = new List<Estadistica>();

        public List<Estadistica> getStats()
        {
           return stats;
        }

        public void setStats(Partido par)
        {
            for (int i = 0; i < par.Jugadores.Count; i++)
            {
                if (par.Jugadores[i] == this.nombre)
                {
                    this.stats.Add(par.Est[i]);
                    break;
                }
            }
        }

        public string Equiposant
        {
            get { return equiposant; }
            set{ equiposant = value; }
        }
 
        public string Posicion
        {
            get { return posicion;  }
            set { posicion = value; }
        }

        public int Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Jugador(string nombre1, int peso1, int estatura1, string posicion1, string equiposant1)
        {
            this.nombre = nombre1;
            this.peso = peso1;
            this.estatura = estatura1;
            this.posicion = posicion1;
            this.equiposant = equiposant1;
        }
    }
}
