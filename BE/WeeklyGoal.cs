using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeeklyGoal
    {
        [Key, ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public float WantedCalories { get; set; }
        public float? Carbs { get; set; }
        public float? Fats { get; set; }
        public float? Sodium { get; set; }
        public float? Sugar { get; set; }
        public float? Proteins { get; set; }
    }
}
