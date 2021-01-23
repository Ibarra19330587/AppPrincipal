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
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.empresaDataSet.proveedor);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarProveedor f3 = new RegistrarProveedor();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar f2 = new Mostrar();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eliminar f5 = new Eliminar();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarProveedor A = new ActualizarProveedor();
            A.Show();
        }
    }
}
