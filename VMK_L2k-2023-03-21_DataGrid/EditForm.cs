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
            var bndName = tbName.DataBindings.Add(nameof(TextBox.Text), dish, nameof(Dish.Name));
            bndName.FormattingEnabled = true;
            bndName.DataSourceUpdateMode = DataSourceUpdateMode.Never;
            //bndName.BindingComplete += BndNameOnBindingComplete;

            var bndRating = trBRating.DataBindings.Add(nameof(TrackBar.Value), dish, nameof(Dish.IntRating));
            bndRating.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            dish.PropertyChanged += DishOnPropertyChanged;
            cbType.DataBindings.Add(nameof(ComboBox.SelectedIndex), dish, nameof(Dish.IntType));
            nudPrice.DataBindings.Add(nameof(NumericUpDown.Value), dish, nameof(Dish.Price));
            nudCalories.DataBindings.Add(nameof(NumericUpDown.Value), dish, nameof(Dish.Calories));

            lblRating.Text = $"Рейтинг: {dish.Rating}";
        }

        //private void BndNameOnBindingComplete(object? sender, BindingCompleteEventArgs e)
        //{
        //    if (e.BindingCompleteState != BindingCompleteState.Success)
        //    {
        //        tbName.BackColor = Color.LightCoral;
        //        tbName.Focus();
        //        MessageBox.Show(e.Exception?.Message ?? "Ошибка", "Ой-ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void DishOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            lblRating.Text = $"Рейтинг: {dish.Rating}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                dish.Name = tbName.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                tbName.BackColor = Color.LightCoral;
                tbName.Focus();
                MessageBox.Show(ex.Message ?? "Ошибка", "Ой-ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            tbName.BackColor = Color.White;
        }
    }
}
