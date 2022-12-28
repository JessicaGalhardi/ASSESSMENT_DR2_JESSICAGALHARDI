using Microsoft.EntityFrameworkCore;

namespace FriendXY.Models
{
    public class DBBirthdayContext : DbContext

    {
        public DbSet<Friend> friends { get; set; }
        public DBBirthdayContext(DbContextOptions<DBBirthdayContext> options) : base(options)
        {

        }

    }
}
