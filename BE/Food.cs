using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Food
    {

        //[Key, Column(Order = 0)]
        //public Meal Meal { get; set; }
        [Key, Column(Order = 0)]
        public string Name { get; set; }
        public float? Calories { get; set; }
        public float? Carbs { get; set; }
        public float? Fats { get; set; }
        public float? Proteins { get; set; }
        public float? Sodium { get; set; }
        public float? Sugar { get; set; }
        //public double Amount { get; set; }
        public float? Image { get; set; }
    }
}
