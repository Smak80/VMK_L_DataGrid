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
            _dishies.Add(new Dish() { Id = 1, Name = "Салат <<Цезарь>>", Rating = 4.35f, Type = Dish.DishType.Салаты, Calories = 44, Price = 345 });
            _dishies.Add(new Dish() { Id = 2, Name = "Борщ", Rating = 4.85f, Type = Dish.DishType.Супы, Calories = 40, Price = 180.5 });
            _dishies.Add(new Dish() { Id = 3, Name = "Шашлык", Rating = 5.00f, Type = Dish.DishType.Горячее, Calories = 253, Price = 550 });
            dataGridView1.DataSource = _dishies;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new("data.json", FileMode.OpenOrCreate))
            {
                // Вариант сохранения отдельных объектов
                foreach (var dish in _dishies)
                {
                    JsonSerializer.Serialize(fs, dish);
                }
            }
            using (FileStream fs = new("dataList.json", FileMode.OpenOrCreate))
            {
                // Вариант сохранения всего списка
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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dish newDish = new Dish();
            newDish.Id = 333;
            newDish.Rating = 3.33f;
            EditForm ef = new(newDish);
            if (ef.ShowDialog(this) == DialogResult.OK)
            {
                _dishies.Add(newDish);
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) { 
                var currentRow = dataGridView1.SelectedRows[0].Index;
                var tmpDish = _dishies[(int)currentRow].Clone();
                EditForm ef = new(tmpDish);
                if (ef.ShowDialog(this) == DialogResult.OK)
                {
                    _dishies[(int)currentRow] = tmpDish;
                }
            }
            else
            {
                MessageBox.Show(
                    "Не выбрана запись для редактирования.",
                    "Упс!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var toDel = dataGridView1.SelectedRows[0].Index;
                _dishies.RemoveAt(toDel);
            }
            catch
            {
                MessageBox.Show(
                    "Не выбрана запись для удаления.",
                    "Упс!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}