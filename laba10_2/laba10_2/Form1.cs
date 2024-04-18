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
            label2.Text = "Функция cos положительна в I четверти";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Функция cos отрицательна в II четверти";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "Функция cos отрицательна в III четверти";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Функция cos положительна в IV четверти";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
