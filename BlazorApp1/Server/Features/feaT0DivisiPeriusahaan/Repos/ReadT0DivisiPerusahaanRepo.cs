namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos
{
    public class ReadT0DivisiPerusahaanRepo : pthRepoRead<T0DivisiPerusahaan>, IReadT0DivisiPerusahaanRepo
    {
        public DataContext? Ctx => Db as DataContext;
        public ReadT0DivisiPerusahaanRepo(DataContext db) : base(db)
        {
        }

    }
}
