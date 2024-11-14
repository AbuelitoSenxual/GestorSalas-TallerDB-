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
    public partial class GestionarBase : Form
    {
        public GestionarBase()
        {
            InitializeComponent();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gesPeliculaBtn_Click(object sender, EventArgs e)
        {

            AgregarPelicualas agregarPelicualas = new AgregarPelicualas();
            agregarPelicualas.ShowDialog();

        }

        private void gestionarEmplBtn_Click(object sender, EventArgs e)
        {
            GestionarEmpleados gestionarEmpleados = new GestionarEmpleados();
            this.Hide();
            gestionarEmpleados.ShowDialog();
            this.Show();

        }
    }
}
