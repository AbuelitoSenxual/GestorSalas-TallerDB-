using GestorSalas.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas.Vistas
{
    public partial class AgregarPelicualas : Form
    {
        String ImagenRuta = "";
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
            if (nombrepTxb.Text == "" || generoCbx.SelectedIndex == -1 || ImagenRuta == "")
            {
                MessageBox.Show("Porfavor rellene todos los parametros");
            }
            else
            {

                GuardarImagen(ImagenRuta, "C:\\Users\\robol\\Documents\\GestorSalas(TallerDB)\\GestorSalas\\Assets\\", nombrepTxb.Text);
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
                    RutaImagenTxt.Text = "";

                }


            }
        }

        private void imagenPelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar imagen",
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Actualizar el TextBox con la ruta seleccionada
                RutaImagenTxt.Text= ImagenRuta = openFileDialog.FileName;

            }
           
        }

        private static void GuardarImagen(string rutaOriginal, string carpetaDestino, string nuevoNombre)
        {
            try
            {
                // Verificar si la ruta original existe
                if (!File.Exists(rutaOriginal))
                {
                    MessageBox.Show("La imagen original no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Obtener la extensión de la imagen original
                string extension = Path.GetExtension(rutaOriginal);

                // Combinar la carpeta de destino y el nuevo nombre
                string rutaDestino = Path.Combine(carpetaDestino, nuevoNombre + extension);

                // Copiar la imagen al destino con el nuevo nombre
                File.Copy(rutaOriginal, rutaDestino, true);

                MessageBox.Show($"La imagen se ha guardado como:\n{rutaDestino}", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al copiar la imagen:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
