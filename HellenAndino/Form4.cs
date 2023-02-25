using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellenAndino
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BE3_Click(object sender, EventArgs e)
        {
            string texto = "Escriba una función que muestre al usuario los números de 1 al 100, pero cuando el número sea múltiplo de 3 que muestre su nombre y para los múltiplos de 5 que muestre su apellido y finalmente si el número es múltiplo de 3 y 5 debe mostrar su nombre y apellido.";
            MessageBox.Show(texto);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numerosde1en1();
        }
        private void numerosde1en1()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {

                    listBox1.Items.Add("Hellen Andino");

                }
                else if (i % 3 == 0)
                {

                    listBox1.Items.Add("Hellen");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Andino");
                }
                else
                {
                    listBox1.Items.Add(i.ToString());
                }
                {

                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

