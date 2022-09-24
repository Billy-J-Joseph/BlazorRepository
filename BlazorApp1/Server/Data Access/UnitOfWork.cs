using BlazorApp1.Server.feaT1Karyawan.Repositories;
using BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos;
using BlazorApp1.Server.Features.feaT0Jabatan.Repos;

namespace BlazorApp1.Server.Data_Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _db;
        public IReadT1KaryawanRepo ReadT1KaryawanRepo {get; private set;}

        public IWriteT1KaryawanRepo WriteT1KaryawanRepo { get; private set; }

        public IReadT0DivisiPerusahaanRepo ReadT0DivisiPerusahaanRepo { get; private set; }

        public IWriteT0DivisiPerusahaanRepo WriteT0DivisiPerusahaanRepo{ get; private set; }

        public IReadT0JabatanRepo ReadT0JabatanRepo { get; private set; }

        public IWriteT0JabatanRepo WriteT0JabatanRepo { get; private set; }

        public UnitOfWork(DataContext db)
        {
            _db = db;
            ReadT1KaryawanRepo = new ReadT1KaryawanRepo(_db);
            WriteT1KaryawanRepo = new WriteT1KaryawanRepo(_db);
            ReadT0JabatanRepo = new ReadT0JabatanRepo(_db);
            WriteT0JabatanRepo = new WriteT0JabatanRepo(_db);
            ReadT0DivisiPerusahaanRepo =  new ReadT0DivisiPerusahaanRepo(_db);
            WriteT0DivisiPerusahaanRepo = new WriteT0DivisiPerusahaanRepo(_db);
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
