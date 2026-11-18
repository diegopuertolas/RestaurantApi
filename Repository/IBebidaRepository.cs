using Models;

namespace RestauranteAPI.Repositories
{
    public interface IBebidaRepository
    {
        Task<List<Bebida>> GetAllAsync();
        // Task<Bebida?> GetByIdAsync(int id);
        // Task AddAsync(Bebida plato);
        // Task UpdateAsync(Bebida plato);
        // Task DeleteAsync(int id);
    }
}
