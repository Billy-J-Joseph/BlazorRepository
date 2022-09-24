using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.feaT1Karyawan.Repositories
{
    public class ReadT1KaryawanRepo : ReadRepository<T1Karyawan>, IReadT1KaryawanRepo
    {
        public ReadT1KaryawanRepo(DataContext db) : base(db)
        {
        }

        public DataContext? ctx => Db as DataContext;
    }
}
