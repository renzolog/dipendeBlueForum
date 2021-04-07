using DipendeForum.Context.Entities;
using Microsoft.EntityFrameworkCore;

namespace DipendeForum.Context
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
        {
           
        }

        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
    }
}
