using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private List<Cliente> clientesLista;

        public Form3()
        {
            InitializeComponent();

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            var listarClientes = clienteNegocio.listarClientes();
            var ultimosClientes = listarClientes.Skip(Math.Max(0, listarClientes.Count - 10));

            clientesLista = clienteNegocio.listarClientes();

            foreach (var cliente in ultimosClientes)
            {
                dgvClientes.DataSource = clientesLista;
            }
        }
    }
}
