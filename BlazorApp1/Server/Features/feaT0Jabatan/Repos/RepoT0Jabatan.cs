using BlazorApp1.Server.Data_Access;
using Pantheon.Bases.BaseBlazorServer.Repositories.BaseRepoEtm.RepoT0Jabatan;

namespace BlazorApp1.Server.Features.feaT0Jabatan.Repos
{
    public class RepoT0Jabatan : pthRepoT0Jabatan<T0Jabatan>, IRepoT0Jabatan
    {
        public RepoT0Jabatan(DataContext db) : base(db)
        {
        }
        public DataContext? ctx => Db as DataContext;
    }
}
