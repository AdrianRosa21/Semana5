using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Semana5
{
    public partial class Ejercicio1 : Form
    {
        string[] nombres = new string[20];
        int numnombre = 0;
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de solo letras despues PENDIENTEEEEEE
           /* if (!(char.IsLetter(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
           */
            
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            numnombre++;
            nombres[numnombre] = nombre;
            listBox1.Items.Add(numnombre+"° "+nombre);
            
        }
        //para poder modificar o eliminar se podria hacer que le pida al usuario, ingresar el numero de la lista del nombre y a ese obvio restarle 1 porque si elige
        //1 se le eliminara el de un indice mayor muajajaja
    }
}
