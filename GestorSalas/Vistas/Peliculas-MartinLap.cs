using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();  

            login.ShowDialog();
        }

        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {

        }
    }
}
