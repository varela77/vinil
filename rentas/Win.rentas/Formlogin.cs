﻿using Bl.rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.rentas
{
    public partial class Formlogin : Form
    {
        seguridadBL _seguridad;

        public Formlogin()
        {
            InitializeComponent();

            _seguridad = new seguridadBL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;
            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            var resultado = _seguridad.autorizar(usuario, contrasena);

            if (resultado == true)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario o contrasena invalidos");
            }

           

        }
    }
}
