using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CoffeeMachine
    {
        private readonly IMilk _milk;
        private readonly ISugar _sugar;
        public CoffeeMachine(IMilk milk, ISugar sugar)
        {
            _milk = milk;
            _sugar = sugar;
        }
        public void MakeCoffee()
        {
            Console.WriteLine( $"Coffee with {_milk.GetMilk()} and {_sugar.GetSugar()}");
        }
    }
}
