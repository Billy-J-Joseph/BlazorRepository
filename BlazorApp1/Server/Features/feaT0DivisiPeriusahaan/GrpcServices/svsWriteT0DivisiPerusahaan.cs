using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.GrpcServices
{
    public class svsWriteT0DivisiPerusahaan : svpWriteT0DivisiPerusahaan.svpWriteT0DivisiPerusahaanBase
    {
        private readonly IUnitOfWork _uOW;

        public svsWriteT0DivisiPerusahaan(IUnitOfWork uOW)
        {
            _uOW = uOW;
        }

        public override async Task<WriteDivisiPerusahaanReply> InsertT0DivisiPerusahaan(InsertT0DivisiPerusahaanRequest request, ServerCallContext context)
        {
            try
            {
                _uOW.WriteT0DivisiPerusahaanRepo.Insert(request.Adapt<T0DivisiPerusahaan>());
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

        public override Task<WriteDivisiPerusahaanReply> UpdateT0DivisiPerusahaan(UpdateT0DivisiPerusahaanRequest request, ServerCallContext context)
        {
            return base.UpdateT0DivisiPerusahaan(request, context);
        }

        public override Task<WriteDivisiPerusahaanReply> DeleteT0DivisiPerusahaan(DeleteT0DivisiPerusahaanRequest request, ServerCallContext context)
        {
            return base.DeleteT0DivisiPerusahaan(request, context);
        }

    }

}
