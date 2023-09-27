using System;
using MedifoxDan.PizzaOnline.Core.Application.Contracts.Adapters;

namespace MedifoxDan.PizzaOnline.Core.Application
{
    public class SystemDateTimeProvider : IDateTimeProvider
    {
        public DateTime CurrentDateTime => DateTime.Now;
        public DateTime CurrentDate => DateTime.Today;
    }
}