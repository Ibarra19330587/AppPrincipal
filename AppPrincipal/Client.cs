using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrincipal
{
    class Client
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public string precio { get; set; }
        public string vendido { get; set; }

        public Client() { }

        public Client(int ID, string name, string apellido, string precio, string vendido)
        {
            this.ID = ID;
            this.name = name;
            this.apellido = apellido;
            this.precio = precio;
            this.vendido = vendido;
        }
    }
}
