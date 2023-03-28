using MVC_Kredek.Models;

namespace MVC_Kredek.Repositories
{
    public interface IMotorcycleRepository
    {
        IEnumerable<Motorcycle> GetAll();

        Motorcycle GetMotorcycle(int id);
    }
}
