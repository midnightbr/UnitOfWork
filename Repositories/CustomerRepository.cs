using UnitOfWork.DataBase;
using UnitOfWork.Models;

namespace UnitOfWork.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly DataContext _dataContext;

        public CustomerRepository(DataContext context)
        {
            _dataContext = context;
        }

        public void Save(Customer customer)
        {
            _dataContext.Customers.Add(customer);
        }
    }
}
