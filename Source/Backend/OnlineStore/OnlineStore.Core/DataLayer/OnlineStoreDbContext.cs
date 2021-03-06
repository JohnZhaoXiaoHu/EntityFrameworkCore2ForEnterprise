using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.DataLayer.Configurations;
using OnlineStore.Core.DataLayer.Configurations.Dbo;
using OnlineStore.Core.DataLayer.Configurations.HumanResources;
using OnlineStore.Core.DataLayer.Configurations.Warehouse;
using OnlineStore.Core.DataLayer.Configurations.Sales;
using OnlineStore.Core.EntityLayer.Dbo;
using OnlineStore.Core.EntityLayer.HumanResources;
using OnlineStore.Core.EntityLayer.Warehouse;
using OnlineStore.Core.EntityLayer.Sales;

namespace OnlineStore.Core.DataLayer
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<ChangeLog> ChangeLogs { get; set; }

        public DbSet<ChangeLogExclusion> ChangeLogExclusions { get; set; }

        public DbSet<CountryCurrency> CountryCurrencies { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<EventLog> EventLogs { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }

        public DbSet<EmployeeEmail> EmployeeEmails { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductInventory> ProductInventories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<EntityLayer.Warehouse.Location> Warehouses { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderHeader> Orders { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<OrderSummary> OrderSummaries { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations

            modelBuilder
                .ApplyConfiguration(new ChangeLogConfiguration())
                .ApplyConfiguration(new ChangeLogExclusionConfiguration())
                .ApplyConfiguration(new CountryCurrencyConfiguration())
                .ApplyConfiguration(new CountryConfiguration())
                .ApplyConfiguration(new CurrencyConfiguration())
                .ApplyConfiguration(new EventLogConfiguration())
                ;

            modelBuilder
                .ApplyConfiguration(new EmployeeConfiguration())
                .ApplyConfiguration(new EmployeeAddressConfiguration())
                .ApplyConfiguration(new EmployeeEmailConfiguration())
                ;

            modelBuilder
                .ApplyConfiguration(new ProductCategoryConfiguration())
                .ApplyConfiguration(new ProductInventoryConfiguration())
                .ApplyConfiguration(new ProductConfiguration())
                .ApplyConfiguration(new LocationConfiguration())
                ;

            modelBuilder
                .ApplyConfiguration(new CustomerConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration())
                .ApplyConfiguration(new OrderHeaderConfiguration())
                .ApplyConfiguration(new OrderStatusConfiguration())
                .ApplyConfiguration(new OrderSummaryConfiguration())
                .ApplyConfiguration(new PaymentMethodConfiguration())
                .ApplyConfiguration(new ShipperConfiguration())
                ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
