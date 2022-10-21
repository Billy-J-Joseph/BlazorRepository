using Pantheon.Bases.BaseBlazorServer.Repositories.BaseRepoEtm.RepoT0DivisiPerusahaan;

namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos
{
    public class RepoT0DivisiPerusahaan : pthRepoT0DivisiPerusahaan<T0DivisiPerusahaan>, IRepoT0DivisiPerusahaan
    {
        public DataContext? Ctx => Db as DataContext;
        public RepoT0DivisiPerusahaan(DataContext db) : base(db)
        {
        }

    }
}
