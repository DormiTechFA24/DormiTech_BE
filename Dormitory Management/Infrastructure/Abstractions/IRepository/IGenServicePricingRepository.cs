using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenServicePricingRepository
{
    Task<IEnumerable<GenServicePricing>> GetAll();
    Task<GenServicePricing> GetById(Guid id);
}