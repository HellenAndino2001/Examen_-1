using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HellenAndino
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            {
                const double capital = 200000.00;
                const double tasaInteresMensual = 0.015;
                double interesMensual;
                double capitalAcumulado = capital;

                Intereses.Items.Clear();
                for (int mes = 1; mes <= 12; mes++)
                {
                    interesMensual = capitalAcumulado * tasaInteresMensual;
                    capitalAcumulado += interesMensual;
                   Intereses.Items.Add(string.Format("Mes {0}: L {1:0.00}", mes, interesMensual));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void problema_Click(object sender, EventArgs e)
        {
          
            {
                string texto = "La persona llegará el 01 de enero del 2023 a depositar a su cuenta bancaria la cantidad de L 200,000.00, y quiere saber cuánto ganará de interés al final de cada mes (de enero a diciembre).Sabiendo que el banco le dará un interés del 1.5% mensual.";
                MessageBox.Show(texto);
            }

        }
    }
}


