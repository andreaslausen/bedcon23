using MedifoxDan.PizzaOnline.Core.Application.Contracts.Dtos;
using MedifoxDan.PizzaOnline.Core.Domain.Models;

namespace MedifoxDan.PizzaOnline.Core.Application.Interfaces
{
    public interface IOrderMapper
    {
        OrderDto Map(Order order);
    }
}