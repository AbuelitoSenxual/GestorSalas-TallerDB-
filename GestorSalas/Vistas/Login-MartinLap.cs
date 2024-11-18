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
        ConexionBD conexion = new ConexionBD();
        public Login()
        {
            InitializeComponent();

        


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;




            //Nombre = 'Carlos Pérez' and Contraseña= 'password123

            // select * from Empleados where Usuario = '"+usuario+"' and Contraseña= '"+contraseña+"'"

            // select * from Empleados where Usuario = 'cperez' and Contraseña= 'password123'
            try
            {
                string consulta = "select * from Empleados where Usuario = '"+ usuario+"' and Contraseña= '"+contraseña+"'";
                Console.WriteLine(consulta);
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
                Console.WriteLine(consulta);
                SqlDataReader reader;
            reader = comando.ExecuteReader();


            if (reader.HasRows == true)
            {
                    this.Hide();
                    Login login = new Login();

                    
                    Peliculas peliculas = new Peliculas();  
                 
                peliculas.ShowDialog();
                }
                else { MessageBox.Show(" Numero de Empleado o contraseña incorrecta!!!!!"); }


         

            }
            catch (Exception ex)
            {

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
