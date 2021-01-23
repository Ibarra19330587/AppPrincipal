using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppPrincipal
{
    public partial class Cliente : Form
    {
        int Enrrollable, Sheer, Romana;
        int vendi;
        Thread hilo;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Romana = 0;
            if (colorCafe.Checked)
            {
                Romana = Int32.Parse(textBox5.Text) * 1000;
            }
        }

        public Cliente()
        {
            InitializeComponent();
        }

        private void colorBlanco_CheckedChanged(object sender, EventArgs e)
        {
            Romana = 0;
            if (colorBlanco.Checked)
            {
                Romana = Int32.Parse(textBox5.Text) * 1000;
            }
        }

        private void colorVeige_CheckedChanged(object sender, EventArgs e)
        {
            Romana = 0;
            if (colorVeige.Checked)
            {
                Romana = Int32.Parse(textBox5.Text) * 1000;
            }
        }

        private void colorChocolate_CheckedChanged(object sender, EventArgs e)
        {
            Sheer = 0;
            if (colorChocolate.Checked)
            {
                Sheer = Int32.Parse(textBox6.Text) * 900;
            }
        }

        private void colorGris_CheckedChanged(object sender, EventArgs e)
        {
            Sheer = 0;
            if (colorGris.Checked)
            {
                Sheer = Int32.Parse(textBox6.Text) * 900;
            }
        }

        private void colorRojo_CheckedChanged(object sender, EventArgs e)
        {
            Sheer = 0;
            if (colorRojo.Checked)
            {
                Sheer = Int32.Parse(textBox6.Text) * 900;
            }
        }

        private void colorChoco_CheckedChanged(object sender, EventArgs e)
        {
            Enrrollable = 0;
            if (colorChoco.Checked)
            {
                Enrrollable = Int32.Parse(textBox6.Text) * 800;
            }
        }

        private void colorGri_CheckedChanged(object sender, EventArgs e)
        {
            Enrrollable = 0;
            if (colorGri.Checked)
            {
                Enrrollable = Int32.Parse(textBox6.Text) * 800;
            }
        }

        private void colorKaki_CheckedChanged(object sender, EventArgs e)
        {
            Enrrollable = 0;
            if (colorKaki.Checked)
            {
                Enrrollable = Int32.Parse(textBox6.Text) * 800;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Enrrollable + Romana + Sheer);
            hilo = new Thread(Mensaje);
            hilo.Start();
        }
        public void Mensaje()
        {
            MessageBox.Show("Gracias por su compra");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.insertarCliente(textBox1.Text, textBox2.Text, "1000", vendi.ToString());
            MessageBox.Show(mensaje);
        }
        public void venddos()
        {
            vendi = Int32.Parse(textBox5.Text) + Int32.Parse(textBox6.Text) + Int32.Parse(textBox7.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
