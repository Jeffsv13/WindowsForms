using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
     public class Cerveza : Bebida, IBebidaAlcoholica, IRequestable
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public int id {  get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son 10");
        }
        public Cerveza(int cantidad, string nombre = "Cerveza") 
            : base(nombre,cantidad)
        {

        }

    }
}
