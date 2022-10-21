using BlazorApp1.Server.feaT1Karyawan.Repositories;
using BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos;
using BlazorApp1.Server.Features.feaT0Jabatan.Repos;

namespace BlazorApp1.Server.Data_Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _db;
        public IRepoT1Karyawan RepoT1Karyawan { get; private set;}

        public IRepoT0DivisiPerusahaan RepoT0DivisiPerusahaan { get; private set; }

        public IRepoT0Jabatan RepoT0Jabatan { get; private set; }

        public UnitOfWork(DataContext db)
        {
            _db = db;
            RepoT1Karyawan = new RepoT1Karyawan(_db);
            RepoT0DivisiPerusahaan = new RepoT0DivisiPerusahaan(_db);
            RepoT0Jabatan =  new RepoT0Jabatan(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public Task Selesai()
        {
            return _db.SaveChangesAsync();
        }
    }
}
