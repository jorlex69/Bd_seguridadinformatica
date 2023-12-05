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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_user add = new Add_user();
            add.ShowDialog();
        }

        private void editarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adm_per admp = new Adm_per();
            admp.ShowDialog();
        }
    }
}
