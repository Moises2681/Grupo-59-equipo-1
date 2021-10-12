namespace RodandoPorColombia.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Marca> Marca {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("");
            }
        }
    }
}