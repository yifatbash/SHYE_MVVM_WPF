using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Meal
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }

        [Key, Column(Order = 1)]
        public string FoodName { get; set; }

        [Key, Column(Order = 2)]
        public MealType MealType { get; set; }
        [Key, Column(Order = 3)]
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }

    public enum MealType { Breakfast, Lunch, Dinner, Snacks };
}
