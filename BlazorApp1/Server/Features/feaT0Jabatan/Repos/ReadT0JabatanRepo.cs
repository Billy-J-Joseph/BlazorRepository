using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0Jabatan.Repos
{
    public class ReadT0JabatanRepo : pthRepoRead<T0Jabatan>, IReadT0JabatanRepo
    {
        public ReadT0JabatanRepo(DataContext db) : base(db)
        {
        }
        public DataContext? ctx => Db as DataContext;
    }
}
