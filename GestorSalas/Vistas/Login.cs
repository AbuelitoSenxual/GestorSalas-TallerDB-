using GestorSalas.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            baseDatosServicios baseDatosServ = new baseDatosServicios();

            if (baseDatosServ.probarConexion()) {
                if (usuario != "" && contraseña != "")
                {
                    //
                    if (baseDatosServ.verificarUsuario(usuario, contraseña))
                    {
                        Peliculas peliculas = new Peliculas(baseDatosServ.inicializarEmpleado(usuario,contraseña));
                        this.Hide();
                        peliculas.Owner = this;
                        if (peliculas.ShowDialog() == DialogResult.OK) {
                            txtUsuario.Text = txtContraseña.Text = null;
                            this.Show();

                        }
                    }
                    else {
                        MessageBox.Show("Usuario o Contraseña Erronios");
                        txtUsuario.Text = txtContraseña.Text = null;

                    }
                }
                else {
                    MessageBox.Show("Profavor rellene todos los campos");


                }

  
            
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
