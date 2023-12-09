using Bd_seguridadinformatica.Diseños;
using Datos.Context;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Negocio.Procedimientos;
using System.Diagnostics.Eventing.Reader;
using System.Text;


namespace Bd_seguridadinformatica
{
    public partial class Form1 : Form
    {

        private NInicioSesion nInicioSesion;
    
        public Form1()
        {
            nInicioSesion = new NInicioSesion();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InicioSes()
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                Usuario usuario = new Usuario
                {
                    Correo = textBox1.Text,
                    Password = Encrypt.EncryptPass(textBox2.Text)
                };

                var result = nInicioSesion.Login(usuario);

                if (result)
                {
                    //Este metodo solo lo usaras si vas a necesitar los datos del usuario en tu main
                    //de mi parte lo uso para obtener los datos de quien inicio sesion en la aplicacion y
                    //asi insertar el id de quien esta trabajando para insertar o actualizar
                    //var user = nInicioSesion.GetUsuario(usuario);
                    Menu menu = new Menu();
                    this.Hide();

                    menu.Show();

                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Credenciales incorrectas o cuenta bloqueada");
                }


            }



            else
            {
                textBox2.Clear();
                MessageBox.Show("Completa todos los campos");
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {


            InicioSes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta acción esta en desarrollo");
        }
    }

}
