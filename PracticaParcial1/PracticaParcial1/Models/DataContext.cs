using System.Data.Entity;

namespace PracticaParcial1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PracticaParcial1.Models.Student> Students { get; set; }
    }
}