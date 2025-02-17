namespace Semana5
{
    partial class UsoDeColecciones
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
            lblpalabra = new Label();
            lstPalabras = new ListBox();
            txtsignificado = new RichTextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblpalabra
            // 
            lblpalabra.AutoSize = true;
            lblpalabra.Font = new Font("Segoe UI", 12F);
            lblpalabra.Location = new Point(135, 54);
            lblpalabra.Name = "lblpalabra";
            lblpalabra.Size = new Size(61, 21);
            lblpalabra.TabIndex = 0;
            lblpalabra.Text = "Palabra";
            // 
            // lstPalabras
            // 
            lstPalabras.FormattingEnabled = true;
            lstPalabras.Location = new Point(135, 100);
            lstPalabras.Name = "lstPalabras";
            lstPalabras.Size = new Size(125, 139);
            lstPalabras.TabIndex = 1;
            lstPalabras.SelectedIndexChanged += lstPalabras_SelectedIndexChanged;
            // 
            // txtsignificado
            // 
            txtsignificado.Location = new Point(333, 43);
            txtsignificado.Name = "txtsignificado";
            txtsignificado.Size = new Size(205, 196);
            txtsignificado.TabIndex = 2;
            txtsignificado.Text = "";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(260, 268);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 20);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // UsoDeColecciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(txtsignificado);
            Controls.Add(lstPalabras);
            Controls.Add(lblpalabra);
            Name = "UsoDeColecciones";
            Text = "UsoDeColecciones";
            Load += UsoDeColecciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblpalabra;
        private ListBox lstPalabras;
        private RichTextBox txtsignificado;
        private Button btnSalir;
    }
}