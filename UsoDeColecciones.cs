using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Semana5
{
    public partial class UsoDeColecciones : Form
    {
        Dictionary<string, string> palabras = new Dictionary<string, string>();
        public UsoDeColecciones()
        {
            InitializeComponent();
        }

        private void UsoDeColecciones_Load(object sender, EventArgs e)
        {
            lstPalabras.Enabled = true;
            txtsignificado.Enabled = false;
            palabras.Add("Manzana", "Fruta pomacea comestible, fruto del manzano domestico");
            palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un árbol que se conoce coloquialmente como peral común. Existen, de todas maneras, muchas clases de peras, que son producidas por otros árboles del género Pyrus.");
            palabras.Add("Melocotón", "Fruto del melocotonero. Es una drupa de olor agradable, esférica,de seis a ocho centímetros de diámetro, con un surco profundo que ocupa mediacircunferencia, epicarpio delgado, velloso, de color amarillo con manchas encarnadas,mesocarpio amarillento, de sabor agradable y adherido a un hueso pardo, duro y rugoso, que encierra una almendra muy amarga.");
            //recorre el diccionario para llenar la lista con la llave
            foreach (var item in palabras.Keys)
            {
                lstPalabras.Items.Add(item);
            }
        }

        private void lstPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPalabras.Text;
            for (int i = 0; i < palabras.Count; i++)
            {
                var item = palabras.ElementAt(i);
                if (buscar == item.Key)
                {
                    lblpalabra.Text = item.Key;
                    txtsignificado.Text = item.Value;
                    break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
