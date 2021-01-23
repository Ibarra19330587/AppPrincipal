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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = textBox1.Text;
            var contra = textBox2.Text;

            var respuesta = Funciones.login(usuario, contra);

            if (respuesta)
            {
                MessageBox.Show("Bienvenido");
                Tabla fm1 = new Tabla();
                this.Hide();
                fm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña no son correctos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
