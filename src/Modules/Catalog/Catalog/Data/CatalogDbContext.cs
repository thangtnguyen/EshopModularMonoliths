namespace Catalog.Data
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Product>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.HasDefaultSchema("catalog");
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
