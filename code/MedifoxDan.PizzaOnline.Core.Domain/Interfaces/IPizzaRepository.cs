using System;
using System.Collections.Generic;
using MedifoxDan.PizzaOnline.Core.Domain.Models;

namespace MedifoxDan.PizzaOnline.Core.Domain.Interfaces
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> GetPizzen();
        Pizza GetPizza(Guid pizzaId);

        void AddPizza(Pizza pizza);
    }
}