namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = (int)nUpDown.Value;
            int suma=0;
            int i;

            for (i = 0; i < num+1; i++)
            {
                suma+=i;
                listBox.Items.Add("Sumando: " + i + " Suma parcial: " + suma.ToString());
            }
           
            listBox.Items.Add("La suma TOTAL es: "+suma.ToString());

            //Test
        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}