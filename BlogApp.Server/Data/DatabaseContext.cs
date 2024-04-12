using Microsoft.EntityFrameworkCore;
using BlogApp.Server.Models;
using BlogApp.Server.Models.Authentication;

namespace BlogApp.Server.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardDetail> CardDetails { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-one relationship between Card and CardDetail
            modelBuilder.Entity<Card>()
                .HasOne(c => c.cardDetail)
                .WithOne(cd => cd.card)
                .HasForeignKey<CardDetail>(cd => cd.CardId);

            // Seed initial data
            modelBuilder.Entity<Card>().HasData(
                new Card
                {
                    Id = 1,
                    ImageUrl = "/Images/Anime.JPG",
                    Title = "Title 1",
                    Description = "Description 1"
                },
                new Card
                {
                    Id = 2,
                    ImageUrl = "/path/to/image2.jpg",
                    Title = "Title 2",
                    Description = "Description 2"
                }
            );

            modelBuilder.Entity<CardDetail>().HasData(
                new CardDetail
                {
                    Id = 1,
                    MoreDescription = "The whole detail is here more description matedddddcdcdcdc",
                    CardId = 1 // Assuming this matches the Id of the associated Card
                }
            );
        }
    }
}
