﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            CargarOrden ventana = new CargarOrden();
            ventana.ShowDialog();
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            BuscarOrden ventana = new BuscarOrden();
            ventana.ShowDialog();
        }
    }
}
