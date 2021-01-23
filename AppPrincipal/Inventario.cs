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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistratPersiana r = new RegistratPersiana();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarPersiana el = new EliminarPersiana();
            el.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarInventario m = new MostrarInventario();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarTelaa act = new ActualizarTelaa();
            act.Show();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.Show();
        }
    }
}
