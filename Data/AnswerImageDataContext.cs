using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Data
{
    public class AnswerImagesDataContext : DbContext
    {
        public AnswerImagesDataContext(DbContextOptions<AnswerImagesDataContext> options) 
            : base(options)
        {
        }

        public DbSet<AnswerImage> AnswerImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerImage>().ToTable("AnswerImage");
        }

    }

    /*
    public class SmiliesDataContext : DbContext
    {
        public SmiliesDataContext(DbContextOptions<SmiliesDataContext> options)
            : base(options)
        {

        }

        public DbSet<Smiley> Smilies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Smiley>().ToTable("Smiley");
        }
    }
    */
}
