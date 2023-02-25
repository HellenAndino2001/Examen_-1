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
    public partial class Form3 : Form
    {
        public object TxtR { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void BE2_Click(object sender, EventArgs e)
        {
            string texto = " Una empresa ofrece un descuento sobre el total de la factura y un cliente desea saber cuánto pagara al final de su compra. Realice una función asíncrona que calcule el descuento del 15% de la venta y lo muestre al usuario con su total a pagar. El usuario debe ingresar los productos que el cliente esta comprando con sus respectivos precios unitarios.";
            MessageBox.Show(texto);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CalcularDescuento_Click(object sender, EventArgs e)
        {

        }

        private void CalcularTotal_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void facturar_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, num4;

            num1 =Convert.ToDouble (TxtN1.Text);
            num2 = Convert.ToDouble(TxtN2.Text);
            num3 = Convert.ToDouble(TxtN3.Text);
            num4 = Convert.ToDouble(TxtN4.Text);

            textR.Text = String.Format("{0:f2}", ((num1*num2)+(num3*num4)*0.15));


        }
    }
}