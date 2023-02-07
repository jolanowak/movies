using Microsoft.EntityFrameworkCore;

namespace Movies.Data
{
    public class MVCDbcontext : DbContext //ctrl+. dodanie biblioteki Microsoft.EntityFrameworkCore
    {
        public MVCDbcontext(DbContextOptions options) : base(options)  //konstruktor dodany przez ctrl.
        {
        }
        public DbSet<> MyProperty { get; set; } //dodanie property = prop + 2x tab
    }
}
