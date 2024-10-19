using Application.Services.IServices;
using Domain.Model;
using Application.Abstractions.IRepository;


namespace Infrastructure.Repositories
{
    public class AccDisciplineTicketDocumentRepository : GenericRepository<AccDisciplineTicketDocument>, IAccDisciplineTicketDocumentRepository
    {
        public AccDisciplineTicketDocumentRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
