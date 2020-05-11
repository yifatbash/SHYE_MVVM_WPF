using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BMI
    {
        [Key, ForeignKey("User"), Column(Order = 1)]
        public int UserId { get; set;}
        public User User { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Date { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
    }
}
