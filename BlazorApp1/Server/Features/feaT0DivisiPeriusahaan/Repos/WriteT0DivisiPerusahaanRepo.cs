using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos
{
    public class WriteT0DivisiPerusahaanRepo : pthRepoWrite<T0DivisiPerusahaan>, IWriteT0DivisiPerusahaanRepo
    {
        public DataContext? Ctx => Db as DataContext;
        public WriteT0DivisiPerusahaanRepo(DataContext db) : base(db)
        {
        }
    }
}
