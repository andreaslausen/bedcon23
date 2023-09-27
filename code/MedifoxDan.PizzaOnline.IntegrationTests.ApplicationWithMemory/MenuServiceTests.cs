using FluentAssertions;
using MedifoxDan.PizzaOnline.Core.Application.Mappers;
using MedifoxDan.PizzaOnline.Core.Application.Services;
using MedifoxDan.PizzaOnline.Core.Domain.Interfaces;
using MedifoxDan.PizzaOnline.Persistence.Memory;
using Moq;
using Xunit;

namespace MedifoxDan.PizzaOnline.ApplicationWithMemory.IntegrationTests
{
    public class MenuServiceTests
    {
        [Fact]
        public void Test()
        {
            var pizzaRepository = new PizzaRepository();
            var unitOfWorkFactory = new TestUnitOfWorkFactory(pizzaRepository, new Mock<ICustomerRepository>().Object, new Mock<IOrderRepository>().Object);
            var mapper = new MenuMapper();
            var menuService = new MenuService(mapper, unitOfWorkFactory);

            var menu = menuService.GetMenu();
            menu.Eintraege.Length.Should().BeGreaterThan(0);
        }
    }
}