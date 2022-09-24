using BlazorApp1.Server.Data_Access;

namespace BlazorApp1.Server.Features.feaT0DivisiPeriusahaan.GrpcServices
{
    public class svsReadT0DivisiPerusahaan : svpReadT0DivisiPerusahaan.svpReadT0DivisiPerusahaanBase
    {
        private readonly IUnitOfWork _uOW;

        public svsReadT0DivisiPerusahaan(IUnitOfWork uOW)
        {
            _uOW = uOW;
        }

        public override async Task<GetAllT0DivisiPerusahaanReply> GetAllT0DivisiPerusahaan(GetAllT0DivisiPerusahaanRequest request, ServerCallContext context)
        {
            var daftarDivisiPerusahaan = await _uOW.ReadT0DivisiPerusahaanRepo.GetAll();

            var reply = new GetAllT0DivisiPerusahaanReply();
            reply.DaftarT0DivisiPerusahaan.AddRange(daftarDivisiPerusahaan.Adapt<IEnumerable<proT0DivisiPerusahaan>>());
            return reply;
        }

        public override async Task<proT0DivisiPerusahaan> GetT0DivisiPerusahaanById(GetT0DivisiPerusahaanByIdRequest request, ServerCallContext context)
        {
            var T0DivisiPerusahaan = await _uOW.ReadT0DivisiPerusahaanRepo.GetById(request.IdDivisiPerusahaan);
            return T0DivisiPerusahaan.Adapt<proT0DivisiPerusahaan>();
        }

        public override Task GetAllT0DivisiPerusahaanStreaming(GetAllT0DivisiPerusahaanRequest request, IServerStreamWriter<GetAllT0DivisiPerusahaanReply> responseStream, ServerCallContext context)
        {
            return base.GetAllT0DivisiPerusahaanStreaming(request, responseStream, context);
        }
    }
}
