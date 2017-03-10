using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_8_3_17__Entrenador_
{
    public partial class Form1 : Form
    {
        List<Jugador> Equipo = new List<Jugador>();
        List<Partido> Temporada = new List<Partido>();
        string nombre = "", nombre2 = "";
        int mayor = 0, mayor2 = 0, sw = 0;
        public Form1()
        {
            InitializeComponent();
            bt3.Enabled = false;
            bt2.Enabled = false;
            bt4.Enabled = false;
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb4.Text == "" || tb5.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Error");
            }
            else
            {
                string nombre = tb1.Text;
                int peso = Int32.Parse(tb2.Text);
                int estatura = Int32.Parse(tb3.Text);
                string posicion = tb4.Text;
                string equiposa = tb5.Text;
                Jugador jugador = new Jugador(nombre, peso, estatura, posicion, equiposa);
                Equipo.Add(jugador);
                jugadorBindingSource.ResetBindings(true);
                jugadorBindingSource.DataSource = Equipo;
                bt4.Enabled = true;
                limpiar();
            }
        }
        void limpiar()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
        }

        private void tb2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros", "Error");
            }
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros", "Error");
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("El jugador que ha estado mas tiempo en la cancha es: {0} con: {1} minutos", nombre2, mayor2), "Pregunta 1");
        }

        private void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras", "Error");
            }
        }

        private void tb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras", "Error");
            }
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras", "Error");
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("El jugador Goleador es: {0} con: {1} Goles", nombre, mayor), "Pregunta 2");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            int index = 0;
            bt3.Enabled = true;
            bt2.Enabled = true;
            Random rnd = new Random();
            List<string> Jugadores1 = new List<string>();
            if (Equipo.Count > 14)
                index = 14;
            else index = Equipo.Count;
            for (int i = 0; i < index; i++)
            {
                int a = rnd.Next(0, Equipo.Count);
                Jugadores1.Add(Equipo[a].Nombre);
            }
            Partido partido = new Partido(Jugadores1);
            Temporada.Add(partido);
            int c = 0;
            while (c < Equipo.Count)
            {
                int z = 0, sum = 0, sum2 = 0;
                Equipo[c].setStats(partido);
                while (z < Equipo[c].getStats().Count)
                {
                    sum = sum + Equipo[c].getStats()[z].Goles;
                    sum2 = sum2 + Equipo[c].getStats()[z].TiempoJugado;
                    z++;
                }
                if (sum > mayor)
                {
                    mayor = sum;
                    nombre = Equipo[c].Nombre;
                }
                if (sum2 > mayor2)
                {
                    mayor2 = sum2;
                    nombre2 = Equipo[c].Nombre;
                }
                c++;
            }
        }
    }
}
