using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class EliminarPersiana : Form
    {
        public EliminarPersiana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.eliminarPersiana(Int32.Parse(textBox3.Text));
            MessageBox.Show(mensaje);
        }
    }
}
