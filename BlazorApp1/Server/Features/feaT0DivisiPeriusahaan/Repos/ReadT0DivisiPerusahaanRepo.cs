using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos
{
    public class ReadT0DivisiPerusahaanRepo : ReadRepository<T0DivisiPerusahaan>, IReadT0DivisiPerusahaanRepo
    {
        public DataContext? Ctx => Db as DataContext;
        public ReadT0DivisiPerusahaanRepo(DataContext db) : base(db)
        {
        }

    }
}
