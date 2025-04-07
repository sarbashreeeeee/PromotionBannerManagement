using Microsoft.EntityFrameworkCore;
using PromotionBannerManagement.Models;

namespace PromotionBannerManagement
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>()
                .HasOne(b => b.Company)
                .WithMany(c => c.Banners)
                .HasForeignKey(b => b.CompanyId);
        }
    }
}
