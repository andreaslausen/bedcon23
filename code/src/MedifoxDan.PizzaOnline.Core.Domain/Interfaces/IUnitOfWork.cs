using System;
using System.Threading.Tasks;

namespace MedifoxDan.PizzaOnline.Core.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPizzaRepository PizzaRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }

        Task Commit();
        void SetMutualExclusion(string resourceName);
    }
}