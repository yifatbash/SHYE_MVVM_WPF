using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        //[Key, Column(Order = 1)]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Image_Uri { get; set; }

        //---------------------Add-Morgane 
        public float? Height { get; set; }
        public float? Weight { get; set; }

        public DateTime WeightUpdateTime { get; set; }//we will implement a func that will be started in each reactivate and check date
    }
    public enum Gender { Male, Female };
}
