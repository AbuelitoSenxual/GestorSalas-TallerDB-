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
        private Venta Venta;
        private baseDatosServicios db = new baseDatosServicios();
        private List<(string NombreProducto, int Stock, string RutaImagen, decimal Precio)> listaProductos;
        private List<(string NombreProducto, int Cantidad)> productosComprados;

        public VentaDulces(Venta venta)
        {
            this.Venta = venta;
            InitializeComponent();
            ConfigurarFormulario();
            CargarProductos();
            CrearControlesProductos();
        }

        private void VentaDulces_Load(object sender, EventArgs e) { }

        private void ConfigurarFormulario()
        {
            this.Text = "Venta de Productos";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(32, 30, 31);

            // Botón Comprar
            Button btnComprar = new Button
            {
                Text = "Comprar",
                Size = new Size(120, 40),
                Location = new Point(550, 500),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.Click += BtnComprar_Click;

            // Botón Cancelar
            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Size = new Size(120, 40),
                Location = new Point(680, 500),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Click += BtnCancelar_Click;

            this.Controls.Add(btnComprar);
            this.Controls.Add(btnCancelar);

            // Panel productos
            Panel panelProductos = new Panel
            {
                AutoScroll = true,
                Location = new Point(20, 20),
                Size = new Size(750, 450),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(45, 45, 48)
            };
            this.Controls.Add(panelProductos);
        }

        private void CargarProductos()
        {
            listaProductos = db.ObtenerProductosConStock();
            productosComprados = new List<(string NombreProducto, int Cantidad)>();
        }

        private void CrearControlesProductos()
        {
            Panel panelProductos = this.Controls.OfType<Panel>().First();
            int x = 10, y = 10, contador = 0;

            foreach (var producto in listaProductos)
            {
                Panel panelProducto = new Panel
                {
                    Size = new Size(230, 200),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(60, 60, 65)
                };

                PictureBox imgProducto = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(65, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                try { imgProducto.Image = Image.FromFile(producto.RutaImagen); }
                catch { imgProducto.BackColor = Color.LightGray; }

                Label lblNombre = new Label
                {
                    Text = producto.NombreProducto,
                    Location = new Point(10, 115),
                    Size = new Size(210, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.White
                };

                Label lblPrecioStock = new Label
                {
                    Text = $"Precio: ${producto.Precio} - Stock: {producto.Stock}",
                    Location = new Point(10, 135),
                    Size = new Size(210, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = Color.WhiteSmoke
                };

                NumericUpDown nudCantidad = new NumericUpDown
                {
                    Location = new Point(85, 160),
                    Size = new Size(60, 25),
                    Minimum = 0,
                    Maximum = producto.Stock,
                    Value = 0,
                    Tag = producto.NombreProducto,
                    Font = new Font("Segoe UI", 9F)
                };
                nudCantidad.ValueChanged += NudCantidad_ValueChanged;

                panelProducto.Controls.Add(imgProducto);
                panelProducto.Controls.Add(lblNombre);
                panelProducto.Controls.Add(lblPrecioStock);
                panelProducto.Controls.Add(nudCantidad);
                panelProductos.Controls.Add(panelProducto);

                contador++;
                if (contador % 3 == 0) { x = 10; y += 210; }
                else { x += 240; }
            }
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            string nombreProducto = nud.Tag.ToString();
            int cantidad = (int)nud.Value;
            ActualizarProductosComprados(nombreProducto, cantidad);
        }

        private void ActualizarProductosComprados(string nombreProducto, int cantidad)
        {
            int index = productosComprados.FindIndex(p => p.NombreProducto == nombreProducto);

            if (cantidad > 0)
            {
                if (index >= 0) productosComprados[index] = (nombreProducto, cantidad);
                else productosComprados.Add((nombreProducto, cantidad));
            }
            else if (index >= 0)
            {
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
                ProcesarCompra();
            }
        }

        private void ProcesarCompra()
        {
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

            MessageBox.Show("¡Compra realizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.InsertarProductosComprados(Venta.ID_Venta, productosComprados);

            string ticket = db.GenerarTicketVenta(Venta.ID_Venta);
            MessageBox.Show(ticket, "Ticket de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
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

        private void ReiniciarFormulario()
        {
            productosComprados.Clear();
            Panel panelProductos = this.Controls.OfType<Panel>().First();

            foreach (Panel panelProducto in panelProductos.Controls)
            {
                foreach (NumericUpDown nud in panelProducto.Controls.OfType<NumericUpDown>())
                {
                    nud.Value = 0;
                }
            }

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

                    foreach (Label lbl in panelProducto.Controls.OfType<Label>())
                    {
                        if (lbl.Text.StartsWith("Precio"))
                        {
                            lbl.Text = $"Precio: ${producto.Precio} - Stock: {producto.Stock}";
                        }
                    }

                    foreach (NumericUpDown nud in panelProducto.Controls.OfType<NumericUpDown>())
                    {
                        nud.Maximum = producto.Stock;
                    }

                    i++;
                }
            }
        }
    }
}
