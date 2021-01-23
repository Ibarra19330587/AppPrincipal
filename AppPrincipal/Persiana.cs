using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrincipal
{
    class Persiana
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string cantidad { get; set; }

        public Persiana() { }

        public Persiana(int ID, string name, string color, string cantidad)
        {
            this.ID = ID;
            this.name = name;
            this.color = color;
            this.cantidad = cantidad;
        }
    }
}
