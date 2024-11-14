using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorSalas.Modelos;
using GestorSalas.Servicios;

namespace GestorSalas
{
    public partial class Peliculas : Form
    {
        public  Empleado empleado;
        public Peliculas(Empleado empleado)
        {
            this.empleado = empleado;
            InitializeComponent();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }






        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {

        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
           
        }

        private void gestionarBaseBtn_Click(object sender, EventArgs e)
        {
            if (!empleado.puesto.Equals("Administrador"))
            {
                MessageBox.Show("Solo para administradores");
            }
            else { 


                
            }
        }

        private void Peliculas_Activated(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();
            peliculasLtb.Items.Clear();
            peliculasLtb.Items.AddRange(baseDatosServicios.peliculasInformacion());
        }
    }
}
