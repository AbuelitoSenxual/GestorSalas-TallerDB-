﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorSalas.Servicios;

namespace GestorSalas.Vistas
{
    public partial class GestionarEmpleados : Form
    {
        public GestionarEmpleados()
        {
            InitializeComponent();
        }

        private void GestionarEmpleados_Activated(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();
            DataTable dt = baseDatosServicios.empleadoInformacion();
            empleadoDgv.DataSource = dt;
        }

        private void GestionarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void eliminarEmpBtn_Click(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();
            if (empleadoDgv.SelectedRows.Count > 0)
            {

                int idEmpleado = Convert.ToInt32(empleadoDgv.SelectedRows[0].Cells["ID_Empleado"].Value);

                // Eliminar la fila del DataGridView
                empleadoDgv.Rows.RemoveAt(empleadoDgv.SelectedRows[0].Index);

                baseDatosServicios.eliminarEmpleado(idEmpleado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
    }
}