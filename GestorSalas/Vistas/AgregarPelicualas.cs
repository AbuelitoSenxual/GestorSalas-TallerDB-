using GestorSalas.Modelos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorSalas.Vistas
{
    public partial class AgregarPelicualas : Form
    {

        String ImagenRuta = "";


        public AgregarPelicualas()
            
        {
            InitializeComponent();




        }

        private void AgregarPelicualas_Load(object sender, EventArgs e)
        {
            

        }

        private void agregarPbtn_Click(object sender, EventArgs e)
        {
            baseDatosServicios dBserv = new baseDatosServicios();

            // Validar campos
            if (string.IsNullOrWhiteSpace(nombrepTxb.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la película.");
                return;
            }

  

            if (string.IsNullOrWhiteSpace(ImagenRuta))
            {
                MessageBox.Show("Por favor, seleccione una imagen.");
                return;
            }

            if (!dBserv.agregarPelicula(nombrepTxb.Text, (int)duracionPud.Value))
            {
                MessageBox.Show("Error al ingresar datos.");
            }
            else
            {
                // Guardar la imagen si se insertó correctamente en la base de datos
                GuardarImagen(ImagenRuta, "Assets", nombrepTxb.Text);

                MessageBox.Show("Película agregada exitosamente.");
                ResetFormulario();
            }

        }
        private void ResetFormulario()
        {
            duracionPud.Value = 40;
            nombrepTxb.Text = "";
            RutaImagenTxt.Text = "";
            ImagenRuta = ""; 
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

        private static void GuardarImagen(string rutaOriginal, string carpetaRelativaDestino, string nuevoNombre)
        {
            try
            {
                // Verificar si la ruta original existe
                if (!File.Exists(rutaOriginal))
                {
                    MessageBox.Show("La imagen original no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            
                string basePath = AppDomain.CurrentDomain.BaseDirectory;

                string carpetaDestino = Path.Combine(basePath, carpetaRelativaDestino);

           
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
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

        private void AgregarPelicualas_Activated(object sender, EventArgs e)
        {
            
            duracionPud.Value = 40;
            duracionPud.Minimum = 40;
            duracionPud.Maximum = 450;
        }
    }
}
