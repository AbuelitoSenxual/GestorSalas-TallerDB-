﻿using GestorSalas.Modelos;
using GestorSalas.Servicios;
using GestorSalas.Vistas;
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
    public partial class frmAsientos : Form
    {
        private List<Button> botonesSeleccionados = new List<Button>();

        public FuncionesModelo funciones;
        public Venta Venta;
        public Empleado empleado;
        List<Reservacion> listaReservaciones = new List<Reservacion>();
        baseDatosServicios bd = new baseDatosServicios();
        private List<Button> botonesBloqueados = new List<Button>();

        public frmAsientos(Empleado empleado,FuncionesModelo funciones, Venta Venta)
        {
            this.empleado = empleado;
            this.Venta = Venta;
            this.funciones = funciones;
            InitializeComponent();


            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Click += Boton_Click;
                }
            }
            // Aplicar estilo de "Funciones" al form actual
            this.BackColor = Color.FromArgb(32, 30, 31); // Fondo oscuro elegante
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Botón continuar (mismo azul moderno)
            btnBuscarAsiento.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscarAsiento.ForeColor = Color.White;
            btnBuscarAsiento.FlatStyle = FlatStyle.Flat;
            btnBuscarAsiento.FlatAppearance.BorderSize = 0;
            btnBuscarAsiento.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            // Cambiar el color del texto de etiquetas y total
            lblA.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            lblB.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            CarritoAsietnoaslbl.ForeColor = Color.White;

        }
        public List<string> ObtenerNombresBotonesSeleccionados()
        {
            return botonesSeleccionados
                   .Where(btn => !botonesBloqueados.Contains(btn))
                   .Select(btn => btn.Name)
                   .ToList();
        }


        private void Boton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Si el botón está bloqueado, ignorarlo
                if (botonesBloqueados.Contains(btn))
                    return;

                if (botonesSeleccionados.Contains(btn))
                {
                    botonesSeleccionados.Remove(btn);
                    btn.BackColor = Color.LightGray;
                }
                else
                {
                    botonesSeleccionados.Add(btn);
                    btn.BackColor = Color.Green;
                }
            }
            int Carrito = ObtenerNombresBotonesSeleccionados().Count * funciones.costo;
            CarritoAsietnoaslbl.Text =Carrito + " $";
        }


        private void Asientos_Load(object sender, EventArgs e)
        {
            List<string> botonesParaBloquear = bd.AsientosBloqueados(funciones.ID_Funcion);

            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    if (botonesParaBloquear.Contains(btn.Name))
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;  // Opcional: deshabilitarlo físicamente
                        botonesBloqueados.Add(btn);
                    }
                }
            }
        }


        private void btnBuscarAsiento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Deseas continuar?", // Mensaje
               "Confirmar acción", // Título
               MessageBoxButtons.YesNo, // Botones disponibles
               MessageBoxIcon.Question); // Icono del MessageBox
            
            
            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {

    
                if (ObtenerNombresBotonesSeleccionados().Count != 0) {

                    List<int> idsAsientos = bd.ObtenerIdsAsientos(ObtenerNombresBotonesSeleccionados(), funciones.ID_Funcion);
                    foreach (int id in idsAsientos)
                    {
                        Reservacion reservacion = new Reservacion
                        {
                            ID_Asiento = id,
                            ID_Funcion = funciones.ID_Funcion,
                            ID_Empleado = empleado.id_Empleado,
                            ID_Venta = Venta.ID_Venta,
                            Fecha_Reservacion = DateTime.Now
                        };
                        listaReservaciones.Add(reservacion);
                    }
                    bd.InsertarReservaciones(listaReservaciones);

                }

                VentaDulces ventaDulces = new VentaDulces(Venta);
                ventaDulces.ShowDialog();
                
                this.Close();
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("¡Has declinado la acción!", "Declinar");
                this.Close();
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }
    }
}
