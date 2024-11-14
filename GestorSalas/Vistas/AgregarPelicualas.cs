using GestorSalas.Servicios;
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
    public partial class AgregarPelicualas : Form
    {
        public AgregarPelicualas()
        {
            InitializeComponent();

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

        private void AgregarPelicualas_Load(object sender, EventArgs e)
        {
            

        }

        private void agregarPbtn_Click(object sender, EventArgs e)
        {
            baseDatosServicios dBserv = new baseDatosServicios();
            if (nombrepTxb.Text == "" || generoCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor rellene todos los parametros");
            }
            else
            {
                if (!dBserv.agregarPelicula(nombrepTxb.Text, generoCbx.SelectedItem.ToString(), (int)duracionPud.Value))
                {

                    MessageBox.Show("Error al ingresar datos");
                    duracionPud.Value = 40;
                    generoCbx.SelectedIndex = 1;
                    nombrepTxb.Text = "";
                }
                else
                {
                    MessageBox.Show("Fila insertada");
                    duracionPud.Value =40;
                    generoCbx.SelectedIndex = -1;
                    nombrepTxb.Text = "";


                }


            }
        }
    }
}
