using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class Ibaes : Form
    {
        public Ibaes()
        {
            InitializeComponent();
        }

        private void Ibaes_Load(object sender, EventArgs e)
        {

        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inventario());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Proveedor());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            max.Visible = false;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            max.Visible = true;
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormEnPanel(object formpanel)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fp = formpanel as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fp);
            this.panelPrincipal.Tag = fp;
            fp.Show();

        }

        private void app1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cliente());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Presentacion());
        }
    }
}
