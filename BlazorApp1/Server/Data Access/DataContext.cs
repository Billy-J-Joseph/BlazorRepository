namespace BlazorApp1.Server.Data_Access
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<T1Karyawan> T1Karyawan { get; set; }
        public DbSet<T0DivisiPerusahaan> T0DivisiPerusahaan { get; set; }
        public DbSet<T0Jabatan> T0Jabatan { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .DefaultTypeMapping<string>()
                .IsUnicode(false);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}
