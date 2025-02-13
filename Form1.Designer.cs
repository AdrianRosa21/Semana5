
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
            gbInformacon.Location = new Point(12, 30);
            gbInformacon.Name = "gbInformacon";
            gbInformacon.Size = new Size(462, 231);
            gbInformacon.TabIndex = 0;
            gbInformacon.TabStop = false;
            gbInformacon.Text = "Informacion";
            // 
            // lbedad
            // 
            lbedad.AutoSize = true;
            lbedad.Font = new Font("Segoe UI", 12F);
            lbedad.Location = new Point(23, 175);
            lbedad.Name = "lbedad";
            lbedad.Size = new Size(66, 32);
            lbedad.TabIndex = 5;
            lbedad.Text = "Edad";
            // 
            // Lbdig_info
            // 
            Lbdig_info.AutoSize = true;
            Lbdig_info.Font = new Font("Segoe UI", 9F);
            Lbdig_info.Location = new Point(0, 124);
            Lbdig_info.Name = "Lbdig_info";
            Lbdig_info.Size = new Size(202, 25);
            Lbdig_info.TabIndex = 4;
            Lbdig_info.Text = "Digitalize la información";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 31);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 31);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // cbtipoinfo
            // 
            cbtipoinfo.FormattingEnabled = true;
            cbtipoinfo.Items.AddRange(new object[] { "Nombre", "Apellido" });
            cbtipoinfo.Location = new Point(209, 61);
            cbtipoinfo.Name = "cbtipoinfo";
            cbtipoinfo.Size = new Size(232, 33);
            cbtipoinfo.TabIndex = 1;
            cbtipoinfo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lbtipo_info
            // 
            Lbtipo_info.AutoSize = true;
            Lbtipo_info.Font = new Font("Segoe UI", 10F);
            Lbtipo_info.Location = new Point(0, 61);
            Lbtipo_info.Name = "Lbtipo_info";
            Lbtipo_info.Size = new Size(188, 28);
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
            gbMatriz.Location = new Point(522, 30);
            gbMatriz.Name = "gbMatriz";
            gbMatriz.Size = new Size(471, 231);
            gbMatriz.TabIndex = 1;
            gbMatriz.TabStop = false;
            gbMatriz.Text = "Matriz";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(242, 125);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btPromedio
            // 
            btPromedio.Location = new Point(242, 59);
            btPromedio.Name = "btPromedio";
            btPromedio.Size = new Size(130, 34);
            btPromedio.TabIndex = 3;
            btPromedio.Text = "Promedio";
            btPromedio.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(34, 155);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 34);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar Matriz";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(34, 98);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(136, 34);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 39);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(dgdatos);
            gbMantenimiento.Location = new Point(28, 305);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Size = new Size(965, 277);
            gbMantenimiento.TabIndex = 2;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimientos";
            // 
            // dgdatos
            // 
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Location = new Point(23, 46);
            dgdatos.Name = "dgdatos";
            dgdatos.RowHeadersWidth = 62;
            dgdatos.Size = new Size(920, 225);
            dgdatos.TabIndex = 0;
            dgdatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 594);
            Controls.Add(gbMantenimiento);
            Controls.Add(gbMatriz);
            Controls.Add(gbInformacon);
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
