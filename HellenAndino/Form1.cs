namespace HellenAndino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ejeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form2 CalcularInteres = new Form2();
            CalcularInteres.ShowDialog();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 descuento = new Form3();
            descuento.ShowDialog();

        }

        private void multiplo_Click(object sender, EventArgs e)
        {
            Form4 multiplo = new Form4();
            multiplo.ShowDialog();
        }
    }
}