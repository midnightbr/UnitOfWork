using UnitOfWork.Models;

namespace UnitOfWork.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}
