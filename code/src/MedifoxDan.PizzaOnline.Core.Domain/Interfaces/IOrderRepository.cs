using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedifoxDan.PizzaOnline.Core.Domain.Models;

namespace MedifoxDan.PizzaOnline.Core.Domain.Interfaces
{
    public interface IOrderRepository
    {
        void Insert(Order order);
        void Insert(IEnumerable<OrderPosition> orderPositions);
        void Update(Order order);
        Task<Order> Get(Guid orderNumber);
    }
}