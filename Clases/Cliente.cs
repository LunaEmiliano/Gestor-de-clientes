using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }

        public List<Maquina> Ingresos;
        
    }
}
