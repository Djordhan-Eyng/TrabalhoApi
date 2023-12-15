using AulaApi.Entity;

namespace AulaApi.Contracts.Repository
{
    public interface IDistrictRepository
    {
        Task<IEnumerable<DistrictEntity>> Get();
    }
}
