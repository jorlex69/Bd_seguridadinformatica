namespace Bd_seguridadinformatica.Diseños
{
    partial class Adm_per
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 68);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 31);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 109);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Permiso";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // button7
            // 
            button7.Location = new Point(251, 167);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 22;
            button7.Text = "Lista";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(633, 207);
            dataGridView1.TabIndex = 21;
            // 
            // button6
            // 
            button6.Location = new Point(341, 31);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 23;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(539, 82);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 24;
            button1.Text = "Modificar Permisos";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(560, 111);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "Trabajador";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(560, 136);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 19);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "Administrador";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(341, 64);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Adm_per
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adm_per";
            Text = "Adm_per";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button7;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button2;
    }
}