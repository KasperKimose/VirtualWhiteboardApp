using Microsoft.EntityFrameworkCore;

namespace VirtualWhiteboardAPI.Models.DataAccess
{
    class VirtualWhiteboardContext : DbContext
    {
        public VirtualWhiteboardContext(DbContextOptions<VirtualWhiteboardContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Person> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Whiteboard> Whiteboards { get; set; }
    }
}
