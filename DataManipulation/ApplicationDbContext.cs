using DataManipulation.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataManipulation
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<OrderEntity> Orders => Set<OrderEntity>();
        public DbSet<OrderDetailsEntity> OrderDetails => Set<OrderDetailsEntity>();
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configurations.TakePizzaDbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //UserEntity
            modelBuilder.Entity<UserEntity>().ToTable("Users");

            modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);

            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Orders)
                .WithOne(p => p.User);

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.UserName).IsRequired();

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.FirstName).IsRequired();

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.LastName).IsRequired();

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Email).IsRequired();

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Password).IsRequired();

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.CreatedAt).IsRequired();

            //Order
            modelBuilder.Entity<OrderEntity>().ToTable("Orders");

            modelBuilder.Entity<OrderEntity>().HasKey(o => o.Id);

            modelBuilder.Entity<OrderEntity>()
                .HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order);

            //OrderDetails
            modelBuilder.Entity<OrderDetailsEntity>().ToTable("OrderDetails");

            modelBuilder.Entity<OrderDetailsEntity>().HasKey(od => od.Id);

            modelBuilder.Entity<OrderDetailsEntity>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails);

            //Product
            modelBuilder.Entity<ProductEntity>().ToTable("Products");

            modelBuilder.Entity<ProductEntity>().HasKey(p => p.Id);

            modelBuilder.Entity<ProductEntity>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<ProductEntity>()
                .Property(p => p.Name).IsRequired();

            modelBuilder.Entity<ProductEntity>()
                .Property(p => p.Weight).IsRequired();

            modelBuilder.Entity<ProductEntity>()
                .Property(p => p.Price).IsRequired();

            //Category 
            modelBuilder.Entity<CategoryEntity>().ToTable("Category");

            modelBuilder.Entity<CategoryEntity>().HasKey(c => c.Id);

            modelBuilder.Entity<CategoryEntity>()
                .Property(c => c.Name).IsRequired();

            modelBuilder.Entity<CategoryEntity>()
                .Property(c => c.Description).IsRequired();
        }
    }
}