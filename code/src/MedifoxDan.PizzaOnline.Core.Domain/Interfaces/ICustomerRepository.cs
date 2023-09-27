using MedifoxDan.PizzaOnline.Core.Domain.Models;

namespace MedifoxDan.PizzaOnline.Core.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int customerNumber);
    }
}