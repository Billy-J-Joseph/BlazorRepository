namespace BlazorApp1.Server.feaT1Karyawan.GrpcServices;

public class svsT1Karyawan : svpT1Karyawan.svpT1KaryawanBase
{

    private readonly IUnitOfWork _uOW;

    public svsT1Karyawan(IUnitOfWork unitOfWork)
    {
        _uOW = unitOfWork;
    }

    public override async Task<proT1Karyawan> GetT1KaryawanById(GetT1KaryawanByIdRequest request, ServerCallContext context)
    {
        try
        {
            var T1Karyawan = await _uOW.RepoT1Karyawan.GetById(request.IdKaryawan);
            return T1Karyawan.Adapt<proT1Karyawan>();
        }

        catch (RpcException rex)
        {
            throw rex;
        }
        catch (Exception ex)
        {
            throw new RpcException(new Status(StatusCode.Unknown, ex.Message));
        }
    }

    public override async Task<GetAllT1KaryawanReply> GetAllT1Karyawan(GetAllT1KaryawanRequest request, ServerCallContext context)
    {
        try
        {
            var data = await _uOW.RepoT1Karyawan.GetAll();

            var reply = new GetAllT1KaryawanReply();
            reply.DaftarT1Karyawan.AddRange(data.Adapt<IEnumerable<proT1Karyawan>>());
            return reply;
        }

        catch (RpcException rex)
        {
            throw rex;
        }
        catch (Exception ex)
        {
            throw new RpcException(new Status(StatusCode.Unknown, ex.Message));
        }
    }

    public override Task GetAllT1KaryawanStreaming(GetAllT1KaryawanRequest request, IServerStreamWriter<GetAllT1KaryawanReply> responseStream, ServerCallContext context)
    {
        return base.GetAllT1KaryawanStreaming(request, responseStream, context);
    }

    public override async Task<WriteKaryawanReply> InsertT1Karyawan(InsertT1KaryawanRequest request, ServerCallContext context)
    {
        try
        {
            var t1KaryawanToInsert = request.Adapt<T1Karyawan>();
            _uOW.RepoT1Karyawan.Insert(t1KaryawanToInsert);
            await _uOW.Selesai();
            return new WriteKaryawanReply { IsOk = true, Hasil = "Berhasil Simpan" };
        }
        catch (RpcException rex)
        {
            throw rex;
        }
        catch (Exception ex)
        {
            throw new RpcException(new Status(StatusCode.Unknown, $"{ex.Message}"));
        }
    }

    public override Task<WriteKaryawanReply> UpdateT1Karyawan(proT1Karyawan request, ServerCallContext context)
    {
        return base.UpdateT1Karyawan(request, context);
    }
    public override Task<WriteKaryawanReply> DeleteT1Karyawan(DeleteT1KaryawanRequest request, ServerCallContext context)
    {
        return base.DeleteT1Karyawan(request, context);
    }
}
