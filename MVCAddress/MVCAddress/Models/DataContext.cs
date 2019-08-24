
namespace MVCAddress.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCAddress.Models.Book> Books { get; set; }
    }
}