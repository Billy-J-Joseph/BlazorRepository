using BlazorApp1.Server.feaT1Karyawan.Repositories;
using BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.Repos;
using BlazorApp1.Server.Features.feaT0Jabatan.Repos;

namespace BlazorApp1.Server.Data_Access
{
    public interface IUnitOfWork : IDisposable
    {
        IRepoT1Karyawan RepoT1Karyawan { get; }
        IRepoT0DivisiPerusahaan RepoT0DivisiPerusahaan { get; }
        IRepoT0Jabatan RepoT0Jabatan { get; }
        Task Selesai();
    }
}
