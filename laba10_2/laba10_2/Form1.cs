namespace laba10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция cos положительна в I четверти", "Ответ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция cos отрицательна в II четверти", "Ответ");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция cos отрицательна в III четверти", "Ответ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция cos положительна в IV четверти", "Ответ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
