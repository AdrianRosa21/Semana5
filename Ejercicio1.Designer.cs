namespace Semana5
{
    partial class Ejercicio1
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
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnAnadir = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAnadir);
            groupBox1.Location = new Point(434, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Botones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.Location = new Point(182, 121);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 32);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 10F);
            btnBorrar.Location = new Point(182, 37);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(130, 32);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar nombre";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10F);
            btnModificar.Location = new Point(27, 121);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 32);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar nombre\r\n";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // btnAnadir
            // 
            btnAnadir.Font = new Font("Segoe UI", 10F);
            btnAnadir.Location = new Point(27, 37);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(130, 32);
            btnAnadir.TabIndex = 0;
            btnAnadir.Text = "Añadir nombre";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 195);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingrese el nombre a guardar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 59);
            label1.Name = "label1";
            label1.Size = new Size(183, 24);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 227);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 214);
            listBox1.TabIndex = 2;
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            Load += Ejercicio1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox1;
        private Button btnAnadir;
        private Button btnSalir;
        private Button btnBorrar;
        private Button btnModificar;
        private ListBox listBox1;
    }
}