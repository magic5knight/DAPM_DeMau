using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DeMau.Models;

namespace DeMau.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Book>().HasData(
            new Book()
            {
                Id = 1,
                BookName = "Giải tích 12",
                Quantity = 10,
                BookImage = "giaitich12.jpg",
                Price = 100000,
                Description = "Sách giải tích lớp 12"
            },
            new Book()
            {
                Id = 2,
                BookName = "Anh Văn 5",
                Quantity = 20,
                BookImage = "anhvan5.jpg",
                Price = 150000,
                Description = "Sách anh văn lớp 5"
            },
            new Book()
            {
                Id = 3,
                BookName = "Nhà giả kim",
                Quantity = 11,
                BookImage = "nhagiakim.jpg",
                Price = 90000,
                Description = "Nhà giả kim"
            }
        );
    }
}
