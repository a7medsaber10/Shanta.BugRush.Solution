﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shanta.Core.Entities.Identity;
using Shanta.Core.Entities.Order;
using Shanta.Core.Entities.Product;
using Shanta.Core.Entities.Shipment;
using Shanta.Core.Entities.Support;
using Shanta.Core.Entities.Warehouse;
using System.Reflection;


namespace Shanta.Repository.Data
{
    public class StoreContext : IdentityDbContext<AppUser>
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductBrand> ProductBrands { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductVariant> ProductVariants { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Coupon> Coupons { get; set; }

        public DbSet<OrderCoupons> OrderCoupons { get; set; }

        public DbSet<Reviews> Reviews { get; set; }

        public DbSet<SupportTicket> supportTickets { get; set; }

        public DbSet<TicketResponse> TicketResponses { get; set; }

        public DbSet<Shipment> Shipments { get; set; } 

        public DbSet<Warehouse> warehouses { get; set; }

        public DbSet<Stock> stocks { get; set; }

        public DbSet<StockMovement> stockMovements { get; set; }

        public DbSet<SupplyItem> supplyOrderItems { get; set; }

        DbSet<SupplyOrder> supplyOrders { get; set; }

    }
}
