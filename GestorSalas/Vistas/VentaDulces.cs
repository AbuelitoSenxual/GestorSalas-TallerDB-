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
    public partial class VentaDulces : Form
    {
        // Propiedades del producto
        private string nombreProducto = "Chocolate Premium";
        private decimal precioProducto = 25.50m;
        private int stockDisponible = 50;
        private string rutaImagen = ""; // Ruta a la imagen del producto

        // Controles del formulario que añadiremos manualmente
        private PictureBox pictureBoxProducto;
        private Label labelNombreProducto;
        private Label labelPrecio;
        private Label labelStock;
        private NumericUpDown numericCantidad;
        private Label labelTotal;
        private Button buttonComprar;
        private Button buttonCancelar;

        public VentaDulces()
        {
            InitializeComponent();
        }

        private void VentaDulces_Load(object sender, EventArgs e)
        {
            // Configurar el formulario
            this.Text = "Venta de Dulces";
            this.Size = new Size(500, 400);

            // Crear y configurar los controles
            CrearControles();

            // Cargar los datos del producto
            CargarDatosProducto();
        }

        private void CrearControles()
        {
            // PictureBox para la imagen del producto
            pictureBoxProducto = new PictureBox();
            pictureBoxProducto.Size = new Size(200, 200);
            pictureBoxProducto.Location = new Point(20, 20);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducto.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(pictureBoxProducto);

            // Label para el nombre del producto
            labelNombreProducto = new Label();
            labelNombreProducto.AutoSize = true;
            labelNombreProducto.Font = new Font("Arial", 12, FontStyle.Bold);
            labelNombreProducto.Location = new Point(240, 20);
            this.Controls.Add(labelNombreProducto);

            // Label para el precio
            labelPrecio = new Label();
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Arial", 10);
            labelPrecio.Location = new Point(240, 50);
            this.Controls.Add(labelPrecio);

            // Label para el stock
            labelStock = new Label();
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Arial", 10);
            labelStock.Location = new Point(240, 80);
            this.Controls.Add(labelStock);

            // Label para "Cantidad:"
            Label labelCantidadTexto = new Label();
            labelCantidadTexto.Text = "Cantidad:";
            labelCantidadTexto.AutoSize = true;
            labelCantidadTexto.Location = new Point(240, 120);
            this.Controls.Add(labelCantidadTexto);

            // NumericUpDown para seleccionar la cantidad
            numericCantidad = new NumericUpDown();
            numericCantidad.Location = new Point(310, 118);
            numericCantidad.Minimum = 1;
            numericCantidad.Maximum = stockDisponible;
            numericCantidad.Value = 1;
            numericCantidad.Width = 60;
            numericCantidad.ValueChanged += NumericCantidad_ValueChanged;
            this.Controls.Add(numericCantidad);

            // Label para el total
            labelTotal = new Label();
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Arial", 12, FontStyle.Bold);
            labelTotal.Location = new Point(240, 160);
            this.Controls.Add(labelTotal);

            // Botón Comprar
            buttonComprar = new Button();
            buttonComprar.Text = "Comprar";
            buttonComprar.Location = new Point(240, 200);
            buttonComprar.Size = new Size(100, 30);
            buttonComprar.Click += ButtonComprar_Click;
            this.Controls.Add(buttonComprar);

            // Botón Cancelar
            buttonCancelar = new Button();
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.Location = new Point(350, 200);
            buttonCancelar.Size = new Size(100, 30);
            buttonCancelar.Click += ButtonCancelar_Click;
            this.Controls.Add(buttonCancelar);
        }

        private void CargarDatosProducto()
        {
            // Mostrar los datos del producto en los controles
            labelNombreProducto.Text = nombreProducto;
            labelPrecio.Text = $"Precio: ${precioProducto}";
            labelStock.Text = $"Stock disponible: {stockDisponible}";

            // Cargar imagen (usando una imagen de placeholder si no hay ruta)
            try
            {
                if (!string.IsNullOrEmpty(rutaImagen) && System.IO.File.Exists(rutaImagen))
                {
                    pictureBoxProducto.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    // Crear una imagen de placeholder
                    Bitmap bmp = new Bitmap(200, 200);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.LightGray);
                        g.DrawString("Imagen no\ndisponible", new Font("Arial", 12), Brushes.Black, new PointF(50, 80));
                    }
                    pictureBoxProducto.Image = bmp;
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar la imagen del producto.");
            }

            // Actualizar el total
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = precioProducto * numericCantidad.Value;
            labelTotal.Text = $"Total: ${total}";
        }

        private void NumericCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numericCantidad.Value;

            if (cantidad <= stockDisponible)
            {
                decimal total = precioProducto * cantidad;
                MessageBox.Show($"Compra realizada con éxito!\n\nProducto: {nombreProducto}\nCantidad: {cantidad}\nTotal: ${total}",
                    "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el stock
                stockDisponible -= cantidad;
                labelStock.Text = $"Stock disponible: {stockDisponible}";

                // Actualizar el máximo del control NumericUpDown
                numericCantidad.Maximum = stockDisponible;

                // Si no hay stock, deshabilitar el botón de compra
                if (stockDisponible == 0)
                {
                    buttonComprar.Enabled = false;
                    numericCantidad.Enabled = false;
                    MessageBox.Show("Producto agotado.", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"No hay suficiente stock disponible. Stock actual: {stockDisponible}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar la compra?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

