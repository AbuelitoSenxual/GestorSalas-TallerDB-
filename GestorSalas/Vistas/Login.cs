using GestorSalas.Servicios;
using System;
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



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            baseDatosServicios baseDatosServ = new baseDatosServicios();

            if (baseDatosServ.probarConexion())
            {
                if (usuario != "" && contraseña != "")
                {
                    //
                    if (baseDatosServ.verificarUsuario(usuario, contraseña))
                    {
                        Peliculas peliculas = new Peliculas(baseDatosServ.inicializarEmpleado(usuario, contraseña));
                        this.Hide();
                        peliculas.Owner = this;
                        if (peliculas.ShowDialog() == DialogResult.OK)
                        {
                            txtUsuario.Text = txtContraseña.Text = null;
                            this.Show();

                        }
                        else
                        {

                            Application.Exit();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrectos");
                        txtUsuario.Text = txtContraseña.Text = null;

                    }
                }
                else
                {
                    MessageBox.Show("No deje campos vacios");


                }



            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
