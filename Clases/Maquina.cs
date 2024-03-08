using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    internal class Maquina
    {
        public string Tipo { get; set; }
        public string Alimentacion { get; set; }
        public string Marca { get; set; }
        public string Incidencia { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Presupuesto { get; set; }
    }
}
