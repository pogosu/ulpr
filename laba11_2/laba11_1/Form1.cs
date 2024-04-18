using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Train
        {
            public string Punkt { get; set; }
            public string Number { get; set; }
            public DateTime Time { get; set; }

            public override string ToString()
            {
                return $"{Punkt}; {Number}; {Time}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл для чтения";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }

                MessageBox.Show("Данные успешно загружены из файла.");
            }
        }

        List<Train> Trains = new List<Train>();

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            List<string> kuda = new List<string> { "Москва", "Санкт-Петербург", "Новосибирск", "Волгоград", "Сочи", "Екатеринбург", "Ростов-на-Дону", "Архангельск", "Геленджик", "Красноярск" };

            for (int i = 0; i < 10; i++)
            {
                Train note = new Train
                {
                    Punkt = $"{kuda[random.Next(kuda.Count)]}",
                    Number = random.Next(1, 888).ToString(),
                    Time = DateTime.Today.AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60))
                };
                Trains.Add(note);
            }

            using (StreamWriter writer = new StreamWriter("spisok.txt"))
            {
                foreach (var train in Trains)
                {
                    writer.WriteLine($"{train.Punkt},{train.Number},{train.Time}");
                }
            }
            foreach (var train in Trains)
            {
                listBox1.Items.Add($"В {train.Punkt}, Поезд №{train.Number}, Отправление: {train.Time}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trains.Clear();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trains = Trains.OrderBy(train => train.Punkt).ToList();

            listBox1.Items.Clear();
            foreach (var train in Trains)
            {
                listBox1.Items.Add($"В {train.Punkt}, Поезд №{train.Number}, Отправление: {train.Time}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (DateTime.TryParse(textBox1.Text, out DateTime searchTime))
            {
                using (StreamReader reader = new StreamReader("spisok.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string destination = parts[0];
                        string trainNumber = parts[1];
                        DateTime departureTime = DateTime.Parse(parts[2]);
                        if (departureTime > searchTime)
                        {
                            listBox2.Items.Add($"В {destination}, Поезд №{trainNumber}, Отправление: {departureTime}");
                        }
                    }
                }

                if (listBox2.Items.Count == 0)
                {
                    MessageBox.Show("Нет поездов, отправляющихся после указанного времени.");
                }
            }
            else
            {
                MessageBox.Show("Некорректный формат времени.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trains.Clear();
            foreach (var item in listBox1.Items)
            {
                Trains.Add(new Train
                {
                    Punkt = item.ToString().Split(',')[0],
                    Number = item.ToString().Split(',')[1],
                    Time = DateTime.Parse(item.ToString().Split(',')[2])
                });
            }

            using (StreamWriter writer = new StreamWriter("spisok.txt"))
            {
                foreach (var train in Trains)
                {
                    writer.WriteLine($"{train.Punkt},{train.Number} , {train.Time}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
