namespace Semana5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] matriz = new string[3, 3];
        public int fila1, columna1, fila2, columna2, fila3, columna3, countenger, i;
        public static bool IsNumericc(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de solo letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            columna1 = 0;
            columna2 = 1;
            columna3 = 2;
            //Verificamos el combobox1
            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.Bisque;
                }
                else
                {
                    if (fila1 < 3)
                    {
                        matriz[fila1, columna1] = textBox1.Text;
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar mas nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (cbtipoinfo.SelectedIndex == 1)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.BackColor = Color.Bisque;
                    }
                    else
                    {
                        if (fila2 < 3)
                        {
                            matriz[fila2, columna2] = textBox1.Text;
                            fila2 += 1;
                            MessageBox.Show("Apellido ingresado exitosamente");
                            textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pueden agregar mas apellidos");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una opción");
                }
            }

            if (IsNumericc(textBox2.Text) == true)
            {
                if (fila3 < 3)
                {
                    matriz[fila3, columna3] = textBox2.Text;
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    textBox2.Clear();
                    countenger += 1;
                }
                else
                {
                    MessageBox.Show("No se pueden agregar mas edades");
                }
            }
            else
            {
                textBox2.BackColor = Color.Bisque;
            }
            //Aqui 
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgdatos.Columns.Clear();
            //
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();
            //agregando datos a los nombres
            //Mostrando nombres
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgdatos.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = null;
                }
            }
            
        }
    }
}
