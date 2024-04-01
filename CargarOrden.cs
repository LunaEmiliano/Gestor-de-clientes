using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class CargarOrden : Form
    {
        public CargarOrden()
        {
            InitializeComponent();

            // Iniciar siempre con la fecha actual
            dateTimePicker1.Value = DateTime.Now;

            ////////// Mostrar últimos 10 clientes en ListBox //////////

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            
            var listarClientes = clienteNegocio.listarClientes();
            var ultimosClientes = listarClientes.Skip(Math.Max(0, listarClientes.Count - 10));

            foreach (var cliente in ultimosClientes)
            {
                listBoxClientes.Items.Add($"{cliente.Nombre} {cliente.Documento}");
            }
            
            ////////////////////////////////////////////////////////////
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comBoxAlimentacion.Items.Add("Naftera");
            comBoxAlimentacion.Items.Add("Elédctrica");

            comBoxTipoMaquina.Items.Add("Cortacesped");
            comBoxTipoMaquina.Items.Add("Desmalezadora");
            comBoxTipoMaquina.Items.Add("Bordeadora");
            comBoxTipoMaquina.Items.Add("Otro");
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            // Chequeo previo de campos completados
            if ((txtBoxNombre.Text == "") || (txtBoxIncidencias.Text == "") 
                || (comBoxAlimentacion.Text == "") || (txtBoxDNI.Text == "")
                || (txtBoxTelefono.Text == "") || (txtBoxMarca.Text == "")
                || (comBoxTipoMaquina.Text == ""))
            {
                //Nombre
                if (txtBoxNombre.Text == "")
                {
                    txtBoxNombre.BackColor = Color.Red;
                }
                //DNI
                if (txtBoxDNI.Text == "")
                {
                    txtBoxDNI.BackColor = Color.Red;
                }
                //Teléfono
                if (txtBoxTelefono.Text == "")
                {
                    txtBoxTelefono.BackColor = Color.Red;
                }
                //Marca
                if (txtBoxMarca.Text == "")
                {
                    txtBoxMarca.BackColor = Color.Red;
                }
                //Incidencia
                if (txtBoxIncidencias.Text == "")
                {
                    txtBoxIncidencias.BackColor = Color.Red;
                }
                //Alimentacion
                if (comBoxAlimentacion.Text == "")
                {
                    comBoxAlimentacion.BackColor = Color.Red;
                }
                //Tipo de máquina
                if (comBoxTipoMaquina.Text == "")
                {
                    comBoxTipoMaquina.BackColor = Color.Red;
                }
                MessageBox.Show("Por favor, complete los campos faltantes");

                // Volver a color de fondo blanco
                txtBoxNombre.BackColor = Color.White;
                txtBoxDNI.BackColor= Color.White;
                txtBoxTelefono.BackColor= Color.White;
                txtBoxIncidencias.BackColor = Color.White;
                txtBoxMarca.BackColor= Color.White;
                comBoxAlimentacion.BackColor = Color.White;
                comBoxTipoMaquina.BackColor= Color.White;
                return;
            }

            // Creación de objeto y carga de datos

            Maquina maquina = new Maquina();
            Cliente cliente = new Cliente();

            cliente.Nombre = txtBoxNombre.Text;
            cliente.Documento = txtBoxDNI.Text;
            cliente.Telefono = txtBoxTelefono.Text;
            //cliente.Ingresos.Add(maquina);

            maquina.Tipo = comBoxTipoMaquina.Text;
            maquina.Alimentacion = comBoxAlimentacion.Text;
            maquina.Marca = txtBoxMarca.Text;
            maquina.Incidencia = txtBoxIncidencias.Text;
            maquina.FechaIngreso = dateTimePicker1.Value;

            string nombre = cliente.Nombre;
            DateTime fecha = maquina.FechaIngreso;
            string combustible = maquina.Alimentacion;
            string incidencias = maquina.Incidencia;
            string tipoMaquina = maquina.Tipo;


            // Confirmación de datos ingresados
            MessageBox.Show("NUEVO TICKET AÑADIDO: \n \n \n" + "Nombre: " + nombre
               + "\n \nFecha de ingreso: " + fecha.ToShortDateString() + "\n \n"
               + "Tipo de máquina: " + tipoMaquina + "\n \n" +
               "Incidencias: " + incidencias);


            // Reiniciar todos los campos

            txtBoxNombre.Text = "";
            txtBoxIncidencias.Text = "";
            comBoxAlimentacion.Text = "";
            comBoxTipoMaquina.Text = "";
            txtBoxDNI.Text = "";
            txtBoxMarca.Text = "";
            txtBoxTelefono.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            
            
            // Agregar nueva orden al listBox
            listBoxClientes.Items.Add(nombre);
        }
    }
}
