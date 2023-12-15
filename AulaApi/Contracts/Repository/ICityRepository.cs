using AulaApi.Entity;

namespace AulaApi.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> Get();
    }
}
