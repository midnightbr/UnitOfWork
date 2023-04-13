using Microsoft.AspNetCore.Mvc;
using UnitOfWork.DataBase.Interface;
using UnitOfWork.Models;
using UnitOfWork.Repositories;

namespace UnitOfWork.Controllers
{
    [ApiController]
    [Route("v1/orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Order Post([FromServices]ICustomerRepository customerRepository, [FromServices]IOrderRepository orderRepository, [FromServices]IUnitOfWork unitOfWork)
        {
            try
            {
                Customer customer = new Customer()
                {
                    Name = "Testando api"
                };

                Order order = new Order()
                {
                    Number = 123,
                    Customer = customer
                };

                customerRepository.Save(customer);
                orderRepository.Save(order);

                unitOfWork.Commit();

                return order;
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
                Console.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");
                throw;
            }
        }
    }
}
