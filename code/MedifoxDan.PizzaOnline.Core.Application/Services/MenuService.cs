using System.Linq;
using MedifoxDan.PizzaOnline.Core.Application.Contracts.Dtos;
using MedifoxDan.PizzaOnline.Core.Domain.Interfaces;
using MedifoxDan.PizzaOnline.Core.Domain.Models;
using MedifoxDan.PizzaOnline.Core.Application.Interfaces;

namespace MedifoxDan.PizzaOnline.Core.Application.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuMapper _menuMapper;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public MenuService(IMenuMapper menuMapper, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _menuMapper = menuMapper;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public MenuDto GetMenu()
        {
            using (var unitOfWork = _unitOfWorkFactory.CreateUnitOfWork())
            {
                var pizzas = unitOfWork.PizzaRepository.GetPizzen();
                var menu = new Menu(pizzas.ToList());

                return _menuMapper.ToDto(menu);
            }
        }
    }
}