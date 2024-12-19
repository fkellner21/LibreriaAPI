using LogicaAccesoDatos.EF.Config;
using LogicaDeNegocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LogicaAccesoDatos.EF
{
    public class LibreriaContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Encargado> Encargados { get; set; }



        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<TipoDeMovimiento> TiposDeMovimiento { get; set; }
        public DbSet<MovimientoDeStock> MovimientosDeStock { get; set; }



        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options) { }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = libreria; Integrated Security = True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ArticuloConfiguration());
            modelBuilder.ApplyConfiguration(new TipoDeMovimientoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
