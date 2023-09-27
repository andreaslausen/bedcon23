using MedifoxDan.PizzaOnline.Core.Domain.Interfaces;

namespace MedifoxDan.PizzaOnline.Persistence.Memory
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private InMemoryUnitOfWork _unitOfWork;

        public IUnitOfWork CreateUnitOfWork()
        {
            return _unitOfWork ?? (_unitOfWork = new InMemoryUnitOfWork(new PizzaRepository(), new CustomerRepository(), new OrderRepository()));
        }
    }
}