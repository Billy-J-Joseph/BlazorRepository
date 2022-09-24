
namespace BlazorApp1.Server.Features.feaT0Jabatan.GrpcServices
{
    public class svsWriteT0Jabatan :svpWriteT0Jabatan.svpWriteT0JabatanBase
    {
        private readonly IUnitOfWork _uOW;

        public svsWriteT0Jabatan(IUnitOfWork uOW)
        {
            _uOW = uOW;
        }

        public override async Task<WriteJabatanReply> InsertT0Jabatan(InsertT0JabatanRequest request, ServerCallContext context)
        {
            try
            {
                var jabatanToInsert = request.Adapt<T0Jabatan>();
                _uOW.WriteT0JabatanRepo.Insert(jabatanToInsert);
                await _uOW.Selesai();
                var reply = new WriteJabatanReply { IsOk = true, Hasil = "Berhasil"};
                return reply;
            }
            catch (Exception)
            {
                return new WriteJabatanReply { IsOk = false, Hasil = "Gagal" };
                throw;
            }

        }

        public override Task<WriteJabatanReply> UpdateT0Jabatan(UpdateT0JabatanRequest request, ServerCallContext context)
        {
            return base.UpdateT0Jabatan(request, context);
        }

        public override Task<WriteJabatanReply> DeleteT0Jabatan(DeleteT0JabatanRequest request, ServerCallContext context)
        {
            return base.DeleteT0Jabatan(request, context);
        }
    }
}
