namespace BlazorApp1.Server.Features.feaT0Jabatan.GrpcServices;

public class svsT0Jabatan : svpT0Jabatan.svpT0JabatanBase
{
    private readonly IUnitOfWork _uOW;
    public svsT0Jabatan(IUnitOfWork uOW)
    {
        _uOW = uOW;
    }

    public override async Task<GetAllT0JabatanReply> GetAllT0Jabatan(GetAllT0JabatanRequest request, ServerCallContext context)
    {
        var data = await _uOW.RepoT0Jabatan.GetAll();
        var reply = new GetAllT0JabatanReply();
        reply.DaftarT0Jabatan.AddRange(data.Adapt<IEnumerable<proT0Jabatan>>());
        return reply;
    }

    public override async Task<proT0Jabatan> GetT0JabatanById(GetT0JabatanByIdRequest request, ServerCallContext context)
    {
        var reply = await _uOW.RepoT0Jabatan.GetById(request.IdJabatan);
        return reply.Adapt<proT0Jabatan>();
    }

    public override Task GetAllT0JabatanStreaming(GetAllT0JabatanRequest request, IServerStreamWriter<GetAllT0JabatanReply> responseStream, ServerCallContext context)
    {
        return base.GetAllT0JabatanStreaming(request, responseStream, context);
    }
    public override async Task<WriteJabatanReply> InsertT0Jabatan(InsertT0JabatanRequest request, ServerCallContext context)
    {
        try
        {
            var jabatanToInsert = request.Adapt<T0Jabatan>();
            _uOW.RepoT0Jabatan.Insert(jabatanToInsert);
            await _uOW.Selesai();
            var reply = new WriteJabatanReply { IsOk = true, Hasil = "Berhasil" };
            return reply;
        }
        catch (Exception)
        {
            return new WriteJabatanReply { IsOk = false, Hasil = "Gagal" };
            throw;
        }
    }

    public override Task<WriteJabatanReply> UpdateT0Jabatan(proT0Jabatan request, ServerCallContext context)
    {
        return base.UpdateT0Jabatan(request, context);
    }

    public override Task<WriteJabatanReply> DeleteT0Jabatan(DeleteT0JabatanRequest request, ServerCallContext context)
    {
        return base.DeleteT0Jabatan(request, context);
    }
}
