using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VMK_L2k_2023_03_21_DataGrid
{
    public class Dish : INotifyPropertyChanged
    {
        public enum DishType
        {
            Салаты, Супы, Горячее, Десерты, Напитки,
        }

        private int id;
        private DishType type;
        private string name;
        private float rating;
        private double price;
        private int calories;

        [DisplayName("Номер")]
        public int Id { get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        [DisplayName("Название блюда")]
        public string Name { get => name;
            set
            {
                name = value; OnPropertyChanged(nameof(Name));
            }
        }
        [DisplayName("Рейтинг")]
        public float Rating { get => rating;
            set
            {
                rating = value; OnPropertyChanged(nameof(Rating));
            }
        }

        [Browsable(false)]
        [JsonIgnore]
        public int IntRating
        {
            get => (int)(Rating * 100);
            set => Rating = value / 100f;
        }

        [DisplayName("Категория")]
        public DishType Type { 
            get => type;
            set
            {
                type = value; OnPropertyChanged(nameof(Type));
            }
        }

        [Browsable(false)]
        [JsonIgnore]
        public int IntType
        {
            get => (int)Type;
            set => Type = (DishType)value;
        }

        [DisplayName("Цена")]
        public double Price { get => price;
            set
            {
                price = value; OnPropertyChanged(nameof(Price));
            }
        }
        [DisplayName("Калории на 100 гр.")]
        public int Calories { get => calories;
            set
            {
                calories = value; OnPropertyChanged(nameof(Calories));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Dish Clone() => new Dish()
        {
            Id = this.Id,
            Name = this.Name,
            Rating = this.Rating,
            Type = this.Type,
            Price = this.Price,
            Calories = this.Calories
        };

    }
}
