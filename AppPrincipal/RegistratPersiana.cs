﻿using System;
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
    public partial class RegistratPersiana : Form
    {
        public RegistratPersiana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.insertarPersiana(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show(mensaje);
        }
    }
}
