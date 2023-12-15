using AulaApi.Entity;

namespace AulaApi.Contracts.Repository
{
    public interface IStateRepository
    {
        Task<IEnumerable<StateEntity>> Get();

    }
}
