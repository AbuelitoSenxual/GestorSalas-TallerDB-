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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorSalas.Vistas
{
    public partial class EmpleadoFrm : Form
    {
        Empleado empleado { get; set; }
        public EmpleadoFrm( Empleado empleado)
        {
            this.empleado = empleado;
            InitializeComponent();
        }

        private void EmpleadoFrm_Load(object sender, EventArgs e)
        {
            nombreEmtxt.Text = empleado.nombre;
            puestoEmcbx.SelectedItem = empleado.puesto;
            usuarioEmtxt.Text = empleado.usuario;
            contraseñaEmtxt.Text = empleado.contraseña;




        }

        private void cargarEmpleado_Click(object sender, EventArgs e)
        {
            if (nombreEmtxt.Text == "" || usuarioEmtxt.Text == "" || contraseñaEmtxt.Text == "" || puestoEmcbx.SelectedItem == null)
            {
                MessageBox.Show("Rellene todo los parametros");
            }
            else {

                empleado.nombre = nombreEmtxt.Text;
                empleado.puesto = usuarioEmtxt.Text;
                empleado.usuario = usuarioEmtxt.Text;
                empleado.contraseña = contraseñaEmtxt.Text;


                this.Close();
            
            }
        }
    }
}
