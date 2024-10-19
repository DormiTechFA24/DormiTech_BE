using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenServicePricingRepository
{
    Task<IEnumerable<GenServicePricing>> GetAll();
    Task<GenServicePricing> GetById(Guid id);
}