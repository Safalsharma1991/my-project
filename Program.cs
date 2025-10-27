using MgmDIDemo;
using Microsoft.Extensions.DependencyInjection;
class Program
{
    static void Main(string[] args)
    {
        // Setup DI
        var serviceProvider = new ServiceCollection()
            .AddTransient<IMilk, CowMilk>()
            .AddTransient<ISugar, WhiteSugar>()
            .AddTransient<CoffeeMachine>()
            .BuildServiceProvider();
        
        // Resolve CoffeeMachine
        var coffeeMachine = serviceProvider.GetService<CoffeeMachine>();
        // Make coffee
        if (coffeeMachine != null)
        {
            coffeeMachine.MakeCoffee();
        }
        else
        {
            Console.WriteLine("Failed to resolve CoffeeMachine from DI container.");
        }
    }
}