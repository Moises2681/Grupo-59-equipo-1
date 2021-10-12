using Microsoft.EntityFrameworkCore;
using RentaAutos.App.Dominio.Entidades;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Alquiler> Alquileres {get; set;}
        public DbSet<EstadoAlquiler> EstadoAlquileres {get; set;}
        public DbSet<EstadoEntrega> EstadoEntregas {get; set;}
        public DbSet<FormaPago> FormaPagos {get; set;}
        public DbSet<HojaVida> HojaVidas{get; set;}
        public DbSet<Marca> Marcas {get; set;}
        public DbSet<TipoCaja> TipoCajas {get; set;}
        public DbSet<TipoCombustible> TipoCombustibles {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Vehiculo> Vehiculos {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =RentaAutos.App");
            }
        }

    }
}