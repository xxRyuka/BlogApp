using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) : base(options:options)
        {
            
        }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Tag> tags { get; set; }


        public DbSet<PostTag> PostTags { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);     
        }


    }
}