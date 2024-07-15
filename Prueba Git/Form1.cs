namespace Prueba_Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya debes los Tacos","Sistema de Tacos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
