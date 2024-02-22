using Microsoft.EntityFrameworkCore;

namespace mission6EmilyPeterson.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base (options) //constructor
        {
        }

        //database set
        public DbSet<Movie> Movies { get; set; }  
        public DbSet<Category> Categories { get; set; }
    }
}
