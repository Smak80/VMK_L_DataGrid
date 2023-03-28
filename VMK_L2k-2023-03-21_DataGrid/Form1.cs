using System.ComponentModel;
using System.Text.Json;
using Accessibility;

namespace VMK_L2k_2023_03_21_DataGrid
{
    public partial class Form1 : Form
    {
        private BindingList<Dish> _dishies = new();
        public Form1()
        {
            InitializeComponent();
            _dishies.Add(new Dish() { Id = 1, Name = "����� <<������>>", Rating = 4.35f, Type = Dish.DishType.������, Calories = 44, Price = 345 });
            _dishies.Add(new Dish() { Id = 2, Name = "����", Rating = 4.85f, Type = Dish.DishType.����, Calories = 40, Price = 180.5 });
            _dishies.Add(new Dish() { Id = 3, Name = "������", Rating = 5.00f, Type = Dish.DishType.�������, Calories = 253, Price = 550 });
            dataGridView1.DataSource = _dishies;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new("data.json", FileMode.OpenOrCreate))
            {
                // ������� ���������� ��������� ��������
                foreach (var dish in _dishies)
                {
                    JsonSerializer.Serialize(fs, dish);
                }
            }
            using (FileStream fs = new("dataList.json", FileMode.OpenOrCreate))
            {
                // ������� ���������� ����� ������
                JsonSerializer.Serialize(fs, _dishies);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("dataList.json", FileMode.Open))
            {
                var data = JsonSerializer.Deserialize<BindingList<Dish>>(fs);
                if (data != null)
                {
                    foreach (var dish in data)
                        _dishies.Add(dish);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _dishies[0].Id = 100;
            _dishies[1].Price = 10;
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dish newDish = new Dish();
            newDish.Id = 333;
            newDish.Rating = 3.33f;
            EditForm ef = new(newDish);
            ef.ShowDialog(this);
            _dishies.Add(newDish);
        }
    }
}