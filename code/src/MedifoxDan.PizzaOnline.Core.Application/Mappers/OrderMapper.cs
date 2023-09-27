using MedifoxDan.PizzaOnline.Core.Application.Contracts.Dtos;
using MedifoxDan.PizzaOnline.Core.Domain.Models;
using MedifoxDan.PizzaOnline.Core.Application.Interfaces;

namespace MedifoxDan.PizzaOnline.Core.Application.Mappers
{
    public class OrderMapper : IOrderMapper
    {
        public OrderDto Map(Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                Number = order.Number,
                CustomerNumber = order.Customer.Number,
                Sum = order.CalculateSum()
            };
        }
    }
}