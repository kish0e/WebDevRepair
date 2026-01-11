using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

public class StockifyContext : DbContext
{
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Inventory> Inventories { get; set; }

    public StockifyContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        MD5 myMD5 = MD5.Create();
        Func<string, string> hashPassword = (password) => Encoding.Default.GetString(myMD5.ComputeHash(Encoding.ASCII.GetBytes(password)));

        // Seed Admin
        modelBuilder.Entity<Admin>().HasData(
            new Admin { Id = 1, Username = "admin", PasswordHash = hashPassword("password123") }
        );

        // Seed Suppliers
        modelBuilder.Entity<Supplier>().HasData(
            new Supplier { Id = 1, Name = "TechSupply Co.", ContactInfo = "contact@techsupply.com" },
            new Supplier { Id = 2, Name = "ElectroTrade", ContactInfo = "info@electrotrade.com" }
        );

        // Seed Products (10 products)
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1200.00m, SupplierId = 1 },
            new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Price = 25.00m, SupplierId = 1 },
            new Product { Id = 3, Name = "Keyboard", Description = "Mechanical keyboard", Price = 85.00m, SupplierId = 2 },
            new Product { Id = 4, Name = "Monitor", Description = "27-inch 4K monitor", Price = 350.00m, SupplierId = 1 },
            new Product { Id = 5, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 150.00m, SupplierId = 2 },
            new Product { Id = 6, Name = "USB Hub", Description = "7-port USB hub", Price = 45.00m, SupplierId = 1 },
            new Product { Id = 7, Name = "Webcam", Description = "1080p HD webcam", Price = 60.00m, SupplierId = 2 },
            new Product { Id = 8, Name = "Desk Lamp", Description = "LED desk lamp", Price = 35.00m, SupplierId = 1 },
            new Product { Id = 9, Name = "External SSD", Description = "1TB external SSD", Price = 120.00m, SupplierId = 2 },
            new Product { Id = 10, Name = "Phone Stand", Description = "Adjustable phone stand", Price = 15.00m, SupplierId = 1 }
        );

        // Seed Warehouses (2 warehouses)
        modelBuilder.Entity<Warehouse>().HasData(
            new Warehouse { Id = 1, Location = "New York", Capacity = 5000, PasswordHash = hashPassword("warehouse1pass") },
            new Warehouse { Id = 2, Location = "Los Angeles", Capacity = 4000, PasswordHash = hashPassword("warehouse2pass") }
        );

        // Seed Inventory (distribute products across warehouses)
        modelBuilder.Entity<Inventory>().HasData(
            // Warehouse 1 (New York)
            new Inventory { Id = 1, ProductId = 1, WarehouseId = 1, Quantity = 15 },
            new Inventory { Id = 2, ProductId = 2, WarehouseId = 1, Quantity = 50 },
            new Inventory { Id = 3, ProductId = 3, WarehouseId = 1, Quantity = 30 },
            new Inventory { Id = 4, ProductId = 4, WarehouseId = 1, Quantity = 10 },
            new Inventory { Id = 5, ProductId = 5, WarehouseId = 1, Quantity = 25 },
            new Inventory { Id = 6, ProductId = 7, WarehouseId = 1, Quantity = 40 },
            new Inventory { Id = 7, ProductId = 10, WarehouseId = 1, Quantity = 100 },

            // Warehouse 2 (Los Angeles)
            new Inventory { Id = 8, ProductId = 1, WarehouseId = 2, Quantity = 20 },
            new Inventory { Id = 9, ProductId = 4, WarehouseId = 2, Quantity = 12 },
            new Inventory { Id = 10, ProductId = 5, WarehouseId = 2, Quantity = 30 },
            new Inventory { Id = 11, ProductId = 6, WarehouseId = 2, Quantity = 60 },
            new Inventory { Id = 12, ProductId = 8, WarehouseId = 2, Quantity = 45 },
            new Inventory { Id = 13, ProductId = 9, WarehouseId = 2, Quantity = 35 },
            new Inventory { Id = 14, ProductId = 10, WarehouseId = 2, Quantity = 80 }
        );
    }
}
