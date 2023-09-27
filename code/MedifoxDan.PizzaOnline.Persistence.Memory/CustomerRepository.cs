using System;
using MedifoxDan.PizzaOnline.Core.Domain.Interfaces;
using MedifoxDan.PizzaOnline.Core.Domain.Models;

namespace MedifoxDan.PizzaOnline.Persistence.Memory
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(int customerNumber)
        {
            return new Customer(Guid.NewGuid(), customerNumber, default, default, default);
        }
    }
}