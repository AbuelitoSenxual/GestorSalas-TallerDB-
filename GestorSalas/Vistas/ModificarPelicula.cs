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
                generoCbx.SelectedItem = Pelicula.Genero;
                

            }

            generoCbx.Items.Add("Acción");
            generoCbx.Items.Add("Comedia");
            generoCbx.Items.Add("Drama");
            generoCbx.Items.Add("Ciencia Ficción");
            generoCbx.Items.Add("Fantasía");
            generoCbx.Items.Add("Terror");
            generoCbx.Items.Add("Suspenso");
            generoCbx.Items.Add("Romance");
            duracionPud.Value = 40;
            duracionPud.Minimum = 40;
            duracionPud.Maximum = 450;
        }

        private void agregarPbtn_Click(object sender, EventArgs e)
        {

            Pelicula.nombre = nombrepTxb.Text;
            Pelicula.Duracion = duracionPud.Text;
            Pelicula.Genero = generoCbx.SelectedItem.ToString();
      


            this.Close();
        }
    }
}
