using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMK_L2k_2023_03_21_DataGrid
{
    public partial class EditForm : Form
    {
        private Dish dish;
        public EditForm(Dish d)
        {
            dish = d;
            InitializeComponent();
            foreach (var type in Enum.GetNames<Dish.DishType>())
            {
                cbType.Items.Add(type);
            }
            nudId.DataBindings.Add(nameof(NumericUpDown.Value), dish, nameof(Dish.Id));
            tbName.DataBindings.Add(nameof(TextBox.Text), dish, nameof(Dish.Name));
            trBRating.DataBindings.Add(nameof(TrackBar.Value), dish, nameof(Dish.IntRating));
            cbType.DataBindings.Add(nameof(ComboBox.SelectedIndex), dish, nameof(Dish.IntType));
            nudPrice.DataBindings.Add(nameof(NumericUpDown.Value), dish, nameof(Dish.Price));
            nudCalories.DataBindings.Add(nameof(NumericUpDown.Value), dish, nameof(Dish.Calories));
            
            // Обработка исключений
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void trBRating_ValueChanged(object sender, EventArgs e)
        {
            lblRating.Text = $"Рейтинг: {trBRating.Value / 100f}";
        }
    }
}
