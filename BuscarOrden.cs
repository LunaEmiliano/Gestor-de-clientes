using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class BuscarOrden : Form
    {
        private List<Cliente> clientesLista;

        public BuscarOrden()
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
