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
            CalculateSum();
        }

        private void CalculateSum()
        {
            try
            {
                trackBar1.Minimum = 1;
                trackBar1.Maximum = 100;
                trackBar1.LargeChange = 1;
                trackBar1.SmallChange = 1;

                int n = trackBar1.Value;

                double sumFormula = n * (4 * Math.Pow(n, 2) - 1) / 3;

                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    label1.Text = $"n = {n}";
                    label2.Text = $"Сумма по формуле: {sumFormula}";
                }
                else if (!checkBox1.Checked && checkBox2.Checked)
                {
                    double sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += Math.Pow(2 * i - 1, 2);
                    }

                    label1.Text = $"n = {n}";
                    label3.Text = $"Сумма в цикле: {sum}";
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    MessageBox.Show("Ошибка: Выберите какой-то один способ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
