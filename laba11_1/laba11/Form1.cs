namespace laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            trackBar1.LargeChange = 1;
            trackBar1.SmallChange = 1;

            int n = trackBar1.Value;

            double sumFormula = n * (4 * Math.Pow(n, 2) - 1) / 3;

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(2 * i - 1, 2);
            }

            label1.Text = $"n = {n}";
            label2.Text = $"Сумма по формуле: {sumFormula}";
            label3.Text = $"Сумма в цикле: {sum}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
