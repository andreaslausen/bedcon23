using System;
using System.Linq;
using MedifoxDan.PizzaOnline.Core.Application.Contracts.Dtos;
using MedifoxDan.PizzaOnline.Core.Domain.Models;
using MedifoxDan.PizzaOnline.Core.Application.Interfaces;

namespace MedifoxDan.PizzaOnline.Core.Application.Mappers
{
    public class MenuMapper : IMenuMapper
    {
        public MenuDto ToDto(Menu menu)
        {
            var eintraege = menu.GetMenuEntries().Select(e => new SpeisekartenEintragDto
            {
                Bezeichnung = e.Sort.Bezeichnung,
                Nummer = e.Sort.Nummer,
                Preise = e.Pizzas.Select(pizza => new PizzaPriceDto
                {
                    Id = pizza.Id,
                    Size = Map(pizza.Size),
                    Price = pizza.Price
                }).ToArray()
            }).ToArray();

            return new MenuDto
            {
                Eintraege = eintraege
            };
        }

        private PizzaSizeDto Map(PizzaSize size)
        {
            switch (size)
            {
                case PizzaSize.Small:
                    return PizzaSizeDto.Klein;
                case PizzaSize.Medium:
                    return PizzaSizeDto.Mittel;
                case PizzaSize.Large:
                    return PizzaSizeDto.Gross;
                default:
                    throw new ArgumentOutOfRangeException(nameof(size), size, null);
            }
        }
    }
}