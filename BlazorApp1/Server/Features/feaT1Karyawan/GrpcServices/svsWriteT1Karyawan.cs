

using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.feaT1Karyawan.GrpcServices
{
    public class svsWriteT1Karyawan : svpWriteT1Karyawan.svpWriteT1KaryawanBase
    {
        private readonly IUnitOfWork _uOW;

        public svsWriteT1Karyawan(IUnitOfWork uOW)
        {
            _uOW = uOW;
        }

        public override async Task<WriteKaryawanReply> InsertT1Karyawan(InsertT1KaryawanRequest request, ServerCallContext context)
        {
            try
            {
                var t1KaryawanToInsert = request.Adapt<T1Karyawan>();
                _uOW.WriteT1KaryawanRepo.Insert(t1KaryawanToInsert);
                await _uOW.Selesai();
                return new WriteKaryawanReply { IsOk = true, Hasil = "Berhasil Simpan" };
            }
            catch(RpcException rex)
            {
                throw rex;
            }
            catch (Exception ex)
            {
                throw new RpcException(new Status(StatusCode.Unknown, $"{ ex.Message}"));
            }
        }

        public override Task<WriteKaryawanReply> UpdateT1Karyawan(UpdateT1KaryawanRequest request, ServerCallContext context)
        {
            return base.UpdateT1Karyawan(request, context);
        }

        public override Task<WriteKaryawanReply> DeleteT1Karyawan(DeleteT1KaryawanRequest request, ServerCallContext context)
        {
            return base.DeleteT1Karyawan(request, context);
        }
    }
}
