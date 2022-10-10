namespace BlazorApp1.Server.feaT1Karyawan.Repositories
{
    public class ReadT1KaryawanRepo : pthRepoRead<T1Karyawan>, IReadT1KaryawanRepo
    {
        public ReadT1KaryawanRepo(DataContext db) : base(db)
        {
        }

        public DataContext? ctx => Db as DataContext;
    }
}
