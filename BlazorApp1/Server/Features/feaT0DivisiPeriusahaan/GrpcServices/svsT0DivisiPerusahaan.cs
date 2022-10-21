namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.GrpcServices;

public class svsT0DivisiPerusahaan : svpT0DivisiPerusahaan.svpT0DivisiPerusahaanBase
{
    private readonly IUnitOfWork _uOW;

    public svsT0DivisiPerusahaan(IUnitOfWork uOW)
    {
        _uOW = uOW;
    }

    public override async Task<GetAllT0DivisiPerusahaanReply> GetAllT0DivisiPerusahaan(GetAllT0DivisiPerusahaanRequest request, ServerCallContext context)
    {
        var daftarDivisiPerusahaan = await _uOW.RepoT0DivisiPerusahaan.GetAll();

        var reply = new GetAllT0DivisiPerusahaanReply();
        reply.DaftarT0DivisiPerusahaan.AddRange(daftarDivisiPerusahaan.Adapt<IEnumerable<proT0DivisiPerusahaan>>());
        return reply;
    }

    public override async Task<proT0DivisiPerusahaan> GetT0DivisiPerusahaanById(GetT0DivisiPerusahaanByIdRequest request, ServerCallContext context)
    {
        var T0DivisiPerusahaan = await _uOW.RepoT0DivisiPerusahaan.GetById(request.IdDivisiPerusahaan);
        return T0DivisiPerusahaan.Adapt<proT0DivisiPerusahaan>();
    }

    public override Task GetAllT0DivisiPerusahaanStreaming(GetAllT0DivisiPerusahaanRequest request, IServerStreamWriter<GetAllT0DivisiPerusahaanReply> responseStream, ServerCallContext context)
    {
        return base.GetAllT0DivisiPerusahaanStreaming(request, responseStream, context);
    }

    public override async Task<WriteDivisiPerusahaanReply> InsertT0DivisiPerusahaan(InsertT0DivisiPerusahaanRequest request, ServerCallContext context)
    {
        try
        {
            _uOW.RepoT0DivisiPerusahaan.Insert(request.Adapt<T0DivisiPerusahaan>());
            await _uOW.Selesai();
            return new WriteDivisiPerusahaanReply { Hasil = "Berhasil Simpan", IsOk = true };
        }
        catch (RpcException rex)
        {
            throw rex;
        }
        catch (Exception ex)
        {

            throw new RpcException(new Status(StatusCode.Unknown, ex.ToString()), ex.Message);
        }
    }

    public override Task<WriteDivisiPerusahaanReply> UpdateT0DivisiPerusahaan(proT0DivisiPerusahaan request, ServerCallContext context)
    {
        return base.UpdateT0DivisiPerusahaan(request, context);
    }
    public override Task<WriteDivisiPerusahaanReply> DeleteT0DivisiPerusahaan(DeleteT0DivisiPerusahaanRequest request, ServerCallContext context)
    {
        return base.DeleteT0DivisiPerusahaan(request, context);
    }

}
