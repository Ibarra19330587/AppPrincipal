using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrincipal
{
    class Usuario
    {
        public int ID { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public Usuario() { }

        public Usuario(int ID, string user, string password)
        {
            this.ID = ID;
            this.user = user;
            this.password = password;
        }
    }
}
