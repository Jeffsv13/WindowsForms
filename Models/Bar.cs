using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    public class Bar
    {
        public string Nombre { get; set; }
        public List<Cerveza> cervezas { get; set; } = [];

        public Bar(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
