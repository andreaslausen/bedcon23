using System;
using System.Threading.Tasks;
using MedifoxDan.PizzaOnline.Core.Application.Contracts.Dtos;

namespace MedifoxDan.PizzaOnline.Core.Application.Services
{
    public interface IOrderService
    {
        Task<OrderDto> CreateOrder(NewOrderDto newOrderDto);
        Task ConfirmOrder(Guid orderId);
    }
}