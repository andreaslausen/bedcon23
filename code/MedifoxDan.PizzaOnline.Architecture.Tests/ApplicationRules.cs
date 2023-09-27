using System.Linq;
using ArchUnitNET.Domain.Dependencies;
using ArchUnitNET.Domain.Extensions;
using Xunit;

namespace MedifoxDan.PizzaOnline.Architecture.Tests;

public class ApplicationRules : ArchitectureTest
{
    [Fact]
    public void ServicesShouldNotUseOtherServices()
    {
        var services =
            Architecture.Classes.Where(s => s.Namespace.NameContains("Core.Application") && s.NameEndsWith("Service"));

        Assert.All(services, s =>
            Assert.True(
                s.Dependencies.FirstOrDefault(d => d is not ImplementsInterfaceDependency &&
                                                   d.Origin.FullName != d.Target.FullName &&
                                                   d.Target.NameEndsWith("Service")) == null));
    }
}