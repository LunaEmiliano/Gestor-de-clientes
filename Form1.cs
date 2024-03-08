using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
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
            if ((txtBoxNombre.Text == "") || (txtBoxIncidencias.Text == "") || (comBoxAlimentacion.Text == ""))
            {
                if (txtBoxNombre.Text == "")
                {
                    txtBoxNombre.BackColor = Color.Red;
                }
                if (txtBoxIncidencias.Text == "")
                {
                    txtBoxIncidencias.BackColor = Color.Red;
                }
                if (comBoxAlimentacion.Text == "")
                {
                    comBoxAlimentacion.BackColor = Color.Red;
                }
                MessageBox.Show("Por favor, complete el campo faltante");
                txtBoxNombre.BackColor = Color.White;
                txtBoxIncidencias.BackColor = Color.White;
                comBoxAlimentacion.BackColor = Color.White;
                return;
            }

            string nombre = txtBoxNombre.Text;
            DateTime fecha = dateTimePicker1.Value;
            string primeraVez = chckBoxPrimeraVez.Checked == true ? "Primera vez" : "Cliente habitual";
            string combustible = comBoxAlimentacion.Text;
            string incidencias = txtBoxIncidencias.Text;
            string tipoMaquina = comBoxTipoMaquina.Text;

            MessageBox.Show("NUEVO TICKET AÑADIDO: \n \n \n" + "Nombre: " + nombre
               + "\n \nFecha de ingreso: " + fecha.ToShortDateString() + "\n \n" + "Tipo de cliente: " + primeraVez + "\n \n"
               + "Tipo de máquina: " + tipoMaquina + "\n \n" +
               "Incidencias: " + incidencias);

            txtBoxNombre.Text = "";
            txtBoxIncidencias.Text = "";
            comBoxAlimentacion.Text = "";
            comBoxTipoMaquina.Text = "";

            dateTimePicker1.Value = DateTime.Now;
            listBox1.Items.Add(nombre);

        }
    }
}
