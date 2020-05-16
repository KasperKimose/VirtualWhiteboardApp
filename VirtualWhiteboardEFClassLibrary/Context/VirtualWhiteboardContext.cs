using Microsoft.EntityFrameworkCore;
using VirtualWhiteboardEFClassLibrary.Models;

namespace VirtualWhiteboardEFClassLibrary.Context
{
    class VirtualWhiteboardContext : DbContext
    {
        public VirtualWhiteboardContext(DbContextOptions<VirtualWhiteboardContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Person> Members { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
