using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;


namespace DAL
{
    public class SHYEContext : DbContext
    {
        public SHYEContext() : base()
        {
            Database.SetInitializer<SHYEContext>(new CreateDatabaseIfNotExists<SHYEContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<BMI> BMIs { get; set; }
        public DbSet<WeeklyGoal> Goals { get; set; }
        public DbSet<Meal> Meals { get; set; }
    }
}
