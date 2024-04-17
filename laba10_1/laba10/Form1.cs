using System.Windows.Forms;
namespace laba10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textBox1.Text);
            double width = double.Parse(textBox2.Text);
            double height = double.Parse(textBox3.Text);

            double room = length * width * height;

            double oxygen = room * 0.21;

            MessageBox.Show($"Объем кислорода в комнате: {oxygen} кубических метров", "Результат");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
