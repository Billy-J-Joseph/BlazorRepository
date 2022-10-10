global using Pantheon.Bases.BaseBlazorServer.BaseServerServices.Repositories.RepoGeneric;

namespace BlazorApp1.Server.feaT1Karyawan.Repositories
{
    public class WriteT1KaryawanRepo : pthRepoWrite<T1Karyawan>, IWriteT1KaryawanRepo
    {
        public WriteT1KaryawanRepo(DataContext db) : base(db)
        {
        }

        public DataContext? Context => Db as DataContext;
    }
}
