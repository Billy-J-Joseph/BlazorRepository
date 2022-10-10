using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0Jabatan.Repos
{
    public class WriteT0JabatanRepo : pthRepoWrite<T0Jabatan>, IWriteT0JabatanRepo
    {
        public DataContext? Ctx => Db as DataContext;
        public WriteT0JabatanRepo(DataContext db) : base(db)
        {
        }
    }
}
