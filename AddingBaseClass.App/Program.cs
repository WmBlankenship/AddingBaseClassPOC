using AddingBaseClass.Core.Interfaces;
using AddingBaseClass.Services.New.Services;
//using AddingBaseClass.Services.Old.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AddingBaseClass.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureDependencies();

            var service = serviceProvider.GetService<IInterfaceWithTooManyMethods>();
            service.MethodOne();
        }

        static ServiceProvider ConfigureDependencies()
        {
            var serviceBuilder = new ServiceCollection()
                .AddTransient<IInterfaceWithTooManyMethods, ImplementationOne>()
                //.AddTransient<IInterfaceWithTooManyMethods, ImplementationTwo>()
                .BuildServiceProvider();

            return serviceBuilder;
        }
    }
}
