using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.feaT1Karyawan.GrpcServices
{
    public class svsReadT1Karyawan : svpReadT1Karyawan.svpReadT1KaryawanBase
    {

        private readonly IUnitOfWork _uOW;

        public svsReadT1Karyawan(IUnitOfWork unitOfWork)
        {
            _uOW = unitOfWork;
        }

        public override async Task<proT1Karyawan> GetT1KaryawanById(GetT1KaryawanByIdRequest request, ServerCallContext context)
        {
            try
            {
                var T1Karyawan = await _uOW.ReadT1KaryawanRepo.GetById(request.IdKaryawan);
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
                var data = await _uOW.ReadT1KaryawanRepo.GetAll();

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
    }
}
