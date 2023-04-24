using Microsoft.EntityFrameworkCore;
using BlazorTest1.Modelss;

namespace BlazorTest1.DataAccess
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<User> TokenUsers { get; set; }
       
    }

}
