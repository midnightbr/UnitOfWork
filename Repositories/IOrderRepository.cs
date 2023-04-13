using UnitOfWork.Models;

namespace UnitOfWork.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
