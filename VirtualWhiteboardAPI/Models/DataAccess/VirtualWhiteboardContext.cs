using Microsoft.EntityFrameworkCore;

namespace VirtualWhiteboardAPI.Models.DataAccess
{
    public class VirtualWhiteboardContext : DbContext
    {
        public VirtualWhiteboardContext(DbContextOptions<VirtualWhiteboardContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Whiteboard> Whiteboards { get; set; }
    }
}
