﻿using Dominio.Entidades;
using Negocio.Procedimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bd_seguridadinformatica.Diseños
{
    public partial class Add_user : Form
    {
        private readonly NUsuarios nUsuarios;
        public Add_user()
        {
            InitializeComponent();
            nUsuarios = new NUsuarios();
        }

        private void Add_user_Load(object sender, EventArgs e)
        {

        }
        private void AgregarUsuario()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text)&& !string.IsNullOrEmpty(textBox2.Text)
                    && !string.IsNullOrEmpty(textBox3.Text)&& !string.IsNullOrEmpty(textBox4.Text))
                {
                    var resu = nUsuarios.Create(new Usuario
                    {
                        Nombre = textBox1.Text,
                        Correo = textBox2.Text,
                        Login = textBox3.Text,
                        Password = Encrypt.EncryptPass(textBox4.Text),
                        Activo = true,
                        FechaRegistro = DateTime.Now,
                        UsuarioRegistro = 1
                    });
                    MessageBox.Show(resu, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Campos vacios");
                }

            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool esSegura = ValidadorContraseña.AlgoritmoContraseñaSegura(textBox3.Text + textBox4.Text);
            if (esSegura)
            {
                AgregarUsuario();

           
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Su contraseña es insegura, asegurese que incluya Mayus, 8 digitos y Simbolos");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
