
namespace Semana5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbInformacon = new GroupBox();
            lbedad = new Label();
            Lbdig_info = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cbtipoinfo = new ComboBox();
            Lbtipo_info = new Label();
            gbMatriz = new GroupBox();
            btnSalir = new Button();
            btPromedio = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnAgregar = new Button();
            gbMantenimiento = new GroupBox();
            dgdatos = new DataGridView();
            gbInformacon.SuspendLayout();
            gbMatriz.SuspendLayout();
            gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            SuspendLayout();
            // 
            // gbInformacon
            // 
            gbInformacon.Controls.Add(lbedad);
            gbInformacon.Controls.Add(Lbdig_info);
            gbInformacon.Controls.Add(textBox2);
            gbInformacon.Controls.Add(textBox1);
            gbInformacon.Controls.Add(cbtipoinfo);
            gbInformacon.Controls.Add(Lbtipo_info);
            gbInformacon.Location = new Point(8, 18);
            gbInformacon.Margin = new Padding(2);
            gbInformacon.Name = "gbInformacon";
            gbInformacon.Padding = new Padding(2);
            gbInformacon.Size = new Size(323, 139);
            gbInformacon.TabIndex = 0;
            gbInformacon.TabStop = false;
            gbInformacon.Text = "Informacion";
            // 
            // lbedad
            // 
            lbedad.AutoSize = true;
            lbedad.Font = new Font("Segoe UI", 12F);
            lbedad.Location = new Point(16, 105);
            lbedad.Margin = new Padding(2, 0, 2, 0);
            lbedad.Name = "lbedad";
            lbedad.Size = new Size(44, 21);
            lbedad.TabIndex = 5;
            lbedad.Text = "Edad";
            // 
            // Lbdig_info
            // 
            Lbdig_info.AutoSize = true;
            Lbdig_info.Font = new Font("Segoe UI", 9F);
            Lbdig_info.Location = new Point(0, 74);
            Lbdig_info.Margin = new Padding(2, 0, 2, 0);
            Lbdig_info.Name = "Lbdig_info";
            Lbdig_info.Size = new Size(135, 15);
            Lbdig_info.TabIndex = 4;
            Lbdig_info.Text = "Digitalize la información";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 107);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 71);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // cbtipoinfo
            // 
            cbtipoinfo.FormattingEnabled = true;
            cbtipoinfo.Items.AddRange(new object[] { "Nombre", "Apellido" });
            cbtipoinfo.Location = new Point(146, 37);
            cbtipoinfo.Margin = new Padding(2);
            cbtipoinfo.Name = "cbtipoinfo";
            cbtipoinfo.Size = new Size(164, 23);
            cbtipoinfo.TabIndex = 1;
            cbtipoinfo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lbtipo_info
            // 
            Lbtipo_info.AutoSize = true;
            Lbtipo_info.Font = new Font("Segoe UI", 10F);
            Lbtipo_info.Location = new Point(0, 37);
            Lbtipo_info.Margin = new Padding(2, 0, 2, 0);
            Lbtipo_info.Name = "Lbtipo_info";
            Lbtipo_info.Size = new Size(130, 19);
            Lbtipo_info.TabIndex = 0;
            Lbtipo_info.Text = "Tipo de información";
            // 
            // gbMatriz
            // 
            gbMatriz.Controls.Add(btnSalir);
            gbMatriz.Controls.Add(btPromedio);
            gbMatriz.Controls.Add(btnLimpiar);
            gbMatriz.Controls.Add(btnMostrar);
            gbMatriz.Controls.Add(btnAgregar);
            gbMatriz.Location = new Point(365, 18);
            gbMatriz.Margin = new Padding(2);
            gbMatriz.Name = "gbMatriz";
            gbMatriz.Padding = new Padding(2);
            gbMatriz.Size = new Size(330, 139);
            gbMatriz.TabIndex = 1;
            gbMatriz.TabStop = false;
            gbMatriz.Text = "Matriz";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(169, 75);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 20);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btPromedio
            // 
            btPromedio.Location = new Point(169, 35);
            btPromedio.Margin = new Padding(2);
            btPromedio.Name = "btPromedio";
            btPromedio.Size = new Size(91, 20);
            btPromedio.TabIndex = 3;
            btPromedio.Text = "Promedio";
            btPromedio.UseVisualStyleBackColor = true;
            btPromedio.Click += btPromedio_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(24, 93);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 20);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar Matriz";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(24, 59);
            btnMostrar.Margin = new Padding(2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(95, 20);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 23);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 20);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(dgdatos);
            gbMantenimiento.Location = new Point(20, 183);
            gbMantenimiento.Margin = new Padding(2);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Padding = new Padding(2);
            gbMantenimiento.Size = new Size(676, 166);
            gbMantenimiento.TabIndex = 2;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimientos";
            // 
            // dgdatos
            // 
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Location = new Point(16, 28);
            dgdatos.Margin = new Padding(2);
            dgdatos.Name = "dgdatos";
            dgdatos.RowHeadersWidth = 62;
            dgdatos.Size = new Size(644, 135);
            dgdatos.TabIndex = 0;
            dgdatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 356);
            Controls.Add(gbMantenimiento);
            Controls.Add(gbMatriz);
            Controls.Add(gbInformacon);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbInformacon.ResumeLayout(false);
            gbInformacon.PerformLayout();
            gbMatriz.ResumeLayout(false);
            gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox gbInformacon;
        private Label Lbtipo_info;
        private GroupBox gbMatriz;
        private Button btnSalir;
        private Button btPromedio;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnAgregar;
        private ComboBox cbtipoinfo;
        private Label lbedad;
        private Label Lbdig_info;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox gbMantenimiento;
        private DataGridView dgdatos;
    }
}
