using Pantheon.Bases.BaseBlazorServer.Repositories.BaseRepoEtm.RepoT1Karyawan;

namespace BlazorApp1.Server.feaT1Karyawan.Repositories
{
    public class RepoT1Karyawan : pthRepoT1Karyawan<T1Karyawan>, IRepoT1Karyawan
    {
        public RepoT1Karyawan(DataContext db) : base(db)
        {
        }

        public DataContext? ctx => Db as DataContext;
    }
}
