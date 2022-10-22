using Pantheon.Bases.BaseBlazorServer.DataAccess;

namespace BlazorApp1.Server.Data_Access
{
    public class DataContext : pthDbContext<T9Privileges>
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<T1Karyawan> T1Karyawan { get; set; }
        public DbSet<T0DivisiPerusahaan> T0DivisiPerusahaan { get; set; }
        public DbSet<T0Jabatan> T0Jabatan { get; set; }
        public DbSet<T6OrderPenjualan> T6OrderPenjualan { get; set; }
        public DbSet<T7OrderPenjualan> T7OrderPenjualan { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}
