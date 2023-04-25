using API.Models;
using Entities.Entities;
//using Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<ProductItem> Products { get; set; }
       
        public DbSet<FileItem> Files { get; set; }
       
        public DbSet<OrderItem> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserItem>(user =>
            {
                user.ToTable("t_users");
                builder.Entity<UserItem>().HasKey(u => u.Id);
                user.HasOne<UserRolItem>().WithMany().HasForeignKey(u => u.IdRol);
                
            });

            builder.Entity<ProductItem>(product =>
            {   
                product.ToTable("t_products");
                builder.Entity<ProductItem>().HasKey(p => p.Id);
                //product.HasOne<FileItem>().WithMany().HasForeignKey(u => u.IdPhotoFile);
                product.HasOne<UserItem>().WithMany().HasForeignKey(p => p.UserId);
            }
            );

            builder.Entity<UserRolItem>(user =>
            {
                user.ToTable("t_userRol");
                user.Property(r => r.Id).ValueGeneratedNever();
            });


            builder.Entity<FileItem>(user =>
            {
                user.ToTable("t_files");

            });

           
            builder.Entity<OrderItem>(order =>
            {
                order.ToTable("t_orders");
                order.HasOne<ProductItem>().WithMany().HasForeignKey(u => u.ProductId);
            });
        }
    }
    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}


