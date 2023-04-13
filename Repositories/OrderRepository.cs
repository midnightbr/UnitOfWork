using UnitOfWork.DataBase;
using UnitOfWork.Models;

namespace UnitOfWork.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Save(Order order)
        {
            _dataContext.Orders.Add(order);
        }
    }
}
