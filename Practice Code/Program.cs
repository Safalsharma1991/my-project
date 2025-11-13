using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddTransient<IMilk, CowMilk>();
        services.AddTransient<ISugar, BrownSugar>();
        services.AddTransient<CoffeeMachine>();
        var serviceProvider = services.BuildServiceProvider();
        var coffeeMachine = serviceProvider.GetRequiredService<CoffeeMachine>();
        coffeeMachine.MakeCoffee();


    }
}