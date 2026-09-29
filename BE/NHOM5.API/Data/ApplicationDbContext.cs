using Microsoft.EntityFrameworkCore;
using NHOM5.API.Models;

namespace NHOM5.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Khai báo các bảng sẽ xuất hiện trong Database
        public DbSet<User> Users { get; set; }
        public DbSet<SportComplex> SportComplexes { get; set; }
        public DbSet<Pitch> Pitches { get; set; }
        public DbSet<PriceRule> PriceRules { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<ExtraService> ExtraServices { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MatchPost> MatchPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Chặn tính năng xóa dây chuyền (Cascade Delete) để tránh lỗi vòng lặp khóa ngoại
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}