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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Naftera");
            comboBox1.Items.Add("Elédctrica");
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {   bool validar = true;
            if ((cajaDeTexto.Text == "") || (textBox1.Text == "") || (comboBox1.Text == ""))
            {
                validar = false;
                if(cajaDeTexto.Text == "")
                {
                    cajaDeTexto.BackColor = Color.Red;
                }
                if(textBox1.Text == "")
                {
                    textBox1.BackColor = Color.Red;
                }
                if(comboBox1.Text == "")
                {
                    comboBox1.BackColor = Color.Red;
                }
                MessageBox.Show("Por favor, complete el campo faltante");
                cajaDeTexto.BackColor= Color.White;
                textBox1.BackColor= Color.White;
                comboBox1.BackColor= Color.White;
                return;
            }

            string nombre = cajaDeTexto.Text;
            DateTime fecha = dateTimePicker1.Value;
            string primeraVez = checkBox1.Checked == true ? "Primera vez" : "Cliente habitual";

            string tipoMaquina;
            if (radioButton1.Checked)
            {
                tipoMaquina = "Bordeadora";
            }
            else if (radioButton2.Checked)
            {
                tipoMaquina = "Motoguadaña";
            }
            else
            {
                tipoMaquina = "Cortacesped";
            }

            string combustible = comboBox1.Text;

            string incidencias = textBox1.Text;

            MessageBox.Show("NUEVO TICKET AÑADIDO: \n \n \n" + "Nombre: " + nombre
               + "\n \nFecha de ingreso: " + fecha.ToShortDateString() + "\n \n" + "Tipo de cliente: " + primeraVez + "\n \n"
               + "Tipo de máquina: " + tipoMaquina + "\n \n" +
               "Incidencias: " + incidencias);

            cajaDeTexto.Text = "";
            textBox1.Text = validar.ToString();
            listBox1.Items.Add(nombre);

        }
    }
}
