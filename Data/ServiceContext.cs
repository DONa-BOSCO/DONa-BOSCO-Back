using API.Models;
using Entities.Entities;
using Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<ProductItem> Products { get; set; }
        public DbSet<AuthorizationItem> UserAuthorizations { get; set; }
        public DbSet<RolAuthorization> RolsAuthorizations { get; set; }
        public DbSet<FileItem> Files { get; set; }
        public DbSet<UserRolItem> UserRol { get; set; }
        public DbSet<OrderItem> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserItem>(user =>
            {
                user.ToTable("t_users");
                //user.HasOne<UserRolItem>().WithMany().HasForeignKey(u => u.Rol);
            });

            builder.Entity<ProductItem>(product =>
            {
                product.ToTable("t_products");
                //product.HasOne<FileItem>().WithMany().HasForeignKey(u => u.IdPhotoFile);
            }
            );

            builder.Entity<UserRolItem>(user =>
            {
                user.ToTable("t_user_rols");
            });

            builder.Entity<AuthorizationItem>(user =>
            {
                user.ToTable("t_endpoint_authorizations");
            });

            builder.Entity<RolAuthorization>(user =>
            {
                user.ToTable("t_rols_authorizations");
                user.HasOne<UserRolItem>().WithMany().HasForeignKey(a => a.IdRol);
                user.HasOne<AuthorizationItem>().WithMany().HasForeignKey(a => a.IdAuthorization);
            });

            builder.Entity<FileItem>(user =>
            {
                user.ToTable("t_files");

            });

            builder.Entity<UserRolItem>(user =>
            {
                user.ToTable("t_userRol");
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


