namespace Bd_seguridadinformatica.Diseños
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            configurarToolStripMenuItem = new ToolStripMenuItem();
            administrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            editarPermisosToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, perfilToolStripMenuItem, configurarToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(46, 20);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // configurarToolStripMenuItem
            // 
            configurarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarUsuariosToolStripMenuItem, editarPermisosToolStripMenuItem });
            configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            configurarToolStripMenuItem.Size = new Size(76, 20);
            configurarToolStripMenuItem.Text = "Configurar";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            administrarUsuariosToolStripMenuItem.Size = new Size(184, 22);
            administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            administrarUsuariosToolStripMenuItem.Click += administrarUsuariosToolStripMenuItem_Click;
            // 
            // editarPermisosToolStripMenuItem
            // 
            editarPermisosToolStripMenuItem.Name = "editarPermisosToolStripMenuItem";
            editarPermisosToolStripMenuItem.Size = new Size(184, 22);
            editarPermisosToolStripMenuItem.Text = "Editar permisos";
            editarPermisosToolStripMenuItem.Click += editarPermisosToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(88, 20);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem editarPermisosToolStripMenuItem;
    }
}