using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) : base(options: options)
        {

        }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Tag> tags { get; set; }


        public DbSet<PostTag> PostTags { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Comment one to many relation
            modelBuilder.Entity<Comment>()
                        .HasOne(x => x.User)
                        .WithMany(x => x.Comments)
                        .HasForeignKey(x => x.UserId)
                        .OnDelete(deleteBehavior: DeleteBehavior.Cascade);


            // comment post one to many relation
            modelBuilder.Entity<Comment>()
                        .HasOne(p => p.Post)
                        .WithMany(k => k.Comments)
                        .HasForeignKey(k => k.PostId)
                        .OnDelete(deleteBehavior: DeleteBehavior.Restrict); // post silinirse commentte silincek otomatik silinmemeli cycle or multiple cascade paths hatasi almamak için 

                        // Burda kritik bir nokta var user silindiğinde post ve yorum silinecek bu veritabanıdna  
                        //"cycle or multiple cascade paths" hatasi verecektir oyuzden 1 tanesini restrict yapmalıyız

            // post one to mant relation

            modelBuilder.Entity<Post>()
                        .HasOne(x => x.User)
                        .WithMany(x => x.Posts)
                        .HasForeignKey(x => x.UserId)
                        .OnDelete(deleteBehavior: DeleteBehavior.Cascade); // user silinirse postta silinecektir



            // Key Tanımlandı
            modelBuilder.Entity<PostTag>()
                        .HasKey(pt => new { pt.PostId, pt.TagId });


            modelBuilder.Entity<PostTag>()
                        .HasOne(tag => tag.Post)
                        .WithMany(x => x.PostTags)
                        .HasForeignKey(k => k.PostId)
                        .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            modelBuilder.Entity<PostTag>()
                        .HasOne(o => o.Tag)
                        .WithMany(o => o.PostTags)
                        .HasForeignKey(a => a.TagId)
                        .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        }


    }
}