using GestorSalas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas.Vistas
{
    public partial class ModificarPelicula : Form
    {
     public Pelicula Pelicula { get; set; }
        public ModificarPelicula(Pelicula pelicula)
        {
            this.Pelicula = pelicula;
            InitializeComponent();
        }

        private void ModificarPelicula_Load(object sender, EventArgs e)
        {
            if (Pelicula != null)
            {
                nombrepTxb.Text = Pelicula.nombre;
                duracionPud.Text = Pelicula.Duracion;
                

            }


            duracionPud.Value = 40;
            duracionPud.Minimum = 40;
            duracionPud.Maximum = 450;
        }

        private void agregarPbtn_Click(object sender, EventArgs e)
        {

            Pelicula.nombre = nombrepTxb.Text;
            Pelicula.Duracion = duracionPud.Text;
      


            this.Close();
        }

        private void duracionPud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DuracionP_Click(object sender, EventArgs e)
        {

        }
    }
}
