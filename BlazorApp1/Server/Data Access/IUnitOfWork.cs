using BlazorApp1.Server.feaT1Karyawan.Repositories;
using BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos;
using BlazorApp1.Server.Features.feaT0Jabatan.Repos;

namespace BlazorApp1.Server.Data_Access
{
    public interface IUnitOfWork : IDisposable
    {
        IReadT1KaryawanRepo ReadT1KaryawanRepo { get; }
        IWriteT1KaryawanRepo WriteT1KaryawanRepo { get; }
        IReadT0DivisiPerusahaanRepo ReadT0DivisiPerusahaanRepo { get; }
        IWriteT0DivisiPerusahaanRepo WriteT0DivisiPerusahaanRepo { get; }
        IReadT0JabatanRepo ReadT0JabatanRepo { get; }
        IWriteT0JabatanRepo WriteT0JabatanRepo { get; }
        Task Selesai();
    }
}
