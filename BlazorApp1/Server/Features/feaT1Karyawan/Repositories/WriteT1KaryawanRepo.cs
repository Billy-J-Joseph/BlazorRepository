using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.feaT1Karyawan.Repositories
{
    public class WriteT1KaryawanRepo : WriteRepository<T1Karyawan>, IWriteT1KaryawanRepo
    {
        public WriteT1KaryawanRepo(DataContext db) : base(db)
        {
        }

        public DataContext? Context => Db as DataContext;
    }
}
