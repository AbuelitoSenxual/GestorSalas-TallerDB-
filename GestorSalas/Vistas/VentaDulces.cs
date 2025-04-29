using GestorSalas.Modelos;
using GestorSalas.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestorSalas.Vistas
{
    public partial class VentaDulces : Form

    {
        Venta Venta = new Venta();
        baseDatosServicios db = new baseDatosServicios();
        // Lista para almacenar los productos y su stock
        private List<(string NombreProducto, int Stock, string RutaImagen, decimal Precio)> listaProductos;

        // Lista para almacenar los productos comprados
        private List<(string NombreProducto, int Cantidad)> productosComprados;

        // Constructor
        public VentaDulces(Venta venta)
        {
            this.Venta = venta;
            InitializeComponent();
            ConfigurarFormulario();
            CargarProductos();
            CrearControlesProductos();
        }
        private void VentaDulces_Load(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el formulario cargue (opcional).
        }


        private void ConfigurarFormulario()
        {
            this.Text = "Venta de Productos";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Botones principales
            Button btnComprar = new Button
            {
                Text = "Comprar",
                Size = new Size(120, 40),
                Location = new Point(550, 500),
                BackColor = Color.Green,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            btnComprar.Click += BtnComprar_Click;

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Size = new Size(120, 40),
                Location = new Point(680, 500),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            btnCancelar.Click += BtnCancelar_Click;

            this.Controls.Add(btnComprar);
            this.Controls.Add(btnCancelar);

            // Panel para productos
            Panel panelProductos = new Panel
            {
                AutoScroll = true,
                Location = new Point(20, 20),
                Size = new Size(750, 450),
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(panelProductos);
        }

        private void CargarProductos()
        {
            // Método que simula la carga de productos
            // En tu caso, aquí llamarías al método que te trae la lista de productos
            listaProductos = db.ObtenerProductosConStock();

            productosComprados = new List<(string NombreProducto, int Cantidad)>();
        }

        private void CrearControlesProductos()
        {
            Panel panelProductos = this.Controls.OfType<Panel>().First();
            int x = 10;
            int y = 10;
            int contador = 0;

            foreach (var producto in listaProductos)
            {
                // Panel para cada producto
                Panel panelProducto = new Panel
                {
                    Size = new Size(230, 200),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Imagen del producto
                PictureBox imgProducto = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(65, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle
                };

                try
                {
                    imgProducto.Image = Image.FromFile(producto.RutaImagen);
                }
                catch
                {
                    // Si no encuentra la imagen, muestra un placeholder
                    imgProducto.BackColor = Color.LightGray;
                }

                // Nombre del producto
                Label lblNombre = new Label
                {
                    Text = producto.NombreProducto,
                    Location = new Point(10, 115),
                    Size = new Size(210, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                // Precio y stock
                Label lblPrecioStock = new Label
                {
                    Text = $"Precio: ${producto.Precio} - Stock: {producto.Stock}",
                    Location = new Point(10, 135),
                    Size = new Size(210, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Control para seleccionar cantidad
                NumericUpDown nudCantidad = new NumericUpDown
                {
                    Location = new Point(85, 160),
                    Size = new Size(60, 25),
                    Minimum = 0,
                    Maximum = producto.Stock,
                    Value = 0,
                    Tag = producto.NombreProducto // Guardamos el nombre del producto como Tag
                };
                nudCantidad.ValueChanged += NudCantidad_ValueChanged;

                // Agregar controles al panel del producto
                panelProducto.Controls.Add(imgProducto);
                panelProducto.Controls.Add(lblNombre);
                panelProducto.Controls.Add(lblPrecioStock);
                panelProducto.Controls.Add(nudCantidad);

                // Agregar panel del producto al panel principal
                panelProductos.Controls.Add(panelProducto);

                // Actualizar posición para el siguiente producto
                contador++;
                if (contador % 3 == 0)
                {
                    x = 10;
                    y += 210;
                }
                else
                {
                    x += 240;
                }
            }
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            string nombreProducto = nud.Tag.ToString();
            int cantidad = (int)nud.Value;

            // Actualizar o agregar a la lista de productos comprados
            ActualizarProductosComprados(nombreProducto, cantidad);
        }

        private void ActualizarProductosComprados(string nombreProducto, int cantidad)
        {
            // Buscar si el producto ya está en la lista de comprados
            int index = productosComprados.FindIndex(p => p.NombreProducto == nombreProducto);

            if (cantidad > 0)
            {
                if (index >= 0)
                {
                    // Actualizar cantidad si ya existe
                    productosComprados[index] = (nombreProducto, cantidad);
                }
                else
                {
                    // Agregar nuevo producto a la lista
                    productosComprados.Add((nombreProducto, cantidad));
                }
            }
            else if (index >= 0)
            {
                // Eliminar de la lista si la cantidad es 0
                productosComprados.RemoveAt(index);
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            if (productosComprados.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningún producto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar resumen de compra
            string resumen = "Resumen de compra:\n\n";
            decimal total = 0;

            foreach (var producto in productosComprados)
            {
                var infoProducto = listaProductos.Find(p => p.NombreProducto == producto.NombreProducto);
                decimal subtotal = infoProducto.Precio * producto.Cantidad;
                resumen += $"{producto.NombreProducto} x {producto.Cantidad} = ${subtotal}\n";
                total += subtotal;
            }

            resumen += $"\nTotal: ${total}";

            DialogResult result = MessageBox.Show(resumen + "\n\n¿Deseas confirmar la compra?",
                "Confirmar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Aquí puedes llamar al método que procesa la compra
                ProcesarCompra();
            }
        }

        private void ProcesarCompra()
        {
            // Actualizar stock
            foreach (var compra in productosComprados)
            {
                int index = listaProductos.FindIndex(p => p.NombreProducto == compra.NombreProducto);
                if (index >= 0)
                {
                    var producto = listaProductos[index];
                    listaProductos[index] = (producto.NombreProducto, producto.Stock - compra.Cantidad,
                        producto.RutaImagen, producto.Precio);
                }
            }

            MessageBox.Show("¡Compra realizada con éxito!", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Aquí puedes enviar la lista de productos comprados
            // a otro método o formulario
            EnviarListaComprados(productosComprados);

            // Reiniciar formulario
            ReiniciarFormulario();
        }

        private void EnviarListaComprados(List<(string NombreProducto, int Cantidad)> lista)
        {
            // Este método enviaría la lista de productos comprados
            // a donde sea necesario en tu aplicación

            // Por ejemplo:
            // otroFormulario.RecibirCompra(lista);

            // O simplemente devolver la lista si este método es llamado desde otro lugar
            // return lista;

  
            db.InsertarProductosComprados(Venta.ID_Venta, productosComprados);
            string ticket = db.GenerarTicketVenta(Venta.ID_Venta); // Usas el método que hicimos

            MessageBox.Show(ticket, "Ticket de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();



        }

        private void ReiniciarFormulario()
        {
            // Limpiar la lista de productos comprados
            productosComprados.Clear();

            // Reiniciar todos los NumericUpDown a 0
            Panel panelProductos = this.Controls.OfType<Panel>().First();
            foreach (Panel panelProducto in panelProductos.Controls)
            {
                foreach (NumericUpDown nud in panelProducto.Controls.OfType<NumericUpDown>())
                {
                    nud.Value = 0;
                }
            }

            // Actualizar la interfaz con el nuevo stock
            ActualizarInterfazStock();
        }

        private void ActualizarInterfazStock()
        {
            Panel panelProductos = this.Controls.OfType<Panel>().First();
            int i = 0;

            foreach (Panel panelProducto in panelProductos.Controls)
            {
                if (i < listaProductos.Count)
                {
                    var producto = listaProductos[i];

                    // Actualizar etiqueta de precio y stock
                    foreach (Label lbl in panelProducto.Controls.OfType<Label>())
                    {
                        if (lbl.Text.StartsWith("Precio"))
                        {
                            lbl.Text = $"Precio: ${producto.Precio} - Stock: {producto.Stock}";
                        }
                    }

                    // Actualizar máximo del NumericUpDown
                    foreach (NumericUpDown nud in panelProducto.Controls.OfType<NumericUpDown>())
                    {
                        nud.Maximum = producto.Stock;
                    }

                    i++;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (productosComprados.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de cancelar la compra?",
                    "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ReiniciarFormulario();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}