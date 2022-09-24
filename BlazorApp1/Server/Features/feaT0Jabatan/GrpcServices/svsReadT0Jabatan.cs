using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0Jabatan.GrpcServices
{
    public class svsReadT0Jabatan : svpReadT0Jabatan.svpReadT0JabatanBase
    {
        private readonly IUnitOfWork _uOW;
        public svsReadT0Jabatan(IUnitOfWork uOW)
        {
            _uOW = uOW;
        }

        public override async Task<GetAllT0JabatanReply> GetAllT0Jabatan(GetAllT0JabatanRequest request, ServerCallContext context)
        {
            var data = await _uOW.ReadT0JabatanRepo.GetAll();
            var reply = new GetAllT0JabatanReply();
            reply.DaftarT0Jabatan.AddRange(data.Adapt<IEnumerable<proT0Jabatan>>());
            return reply;
        }

        public override async Task<proT0Jabatan> GetT0JabatanById(GetT0JabatanByIdRequest request, ServerCallContext context)
        {
            var reply = await _uOW.ReadT0JabatanRepo.GetById(request.IdJabatan);
            return reply.Adapt<proT0Jabatan>();
        }

        public override Task GetAllT0JabatanStreaming(GetAllT0JabatanRequest request, IServerStreamWriter<GetAllT0JabatanReply> responseStream, ServerCallContext context)
        {
            return base.GetAllT0JabatanStreaming(request, responseStream, context);
        }
    }
}
