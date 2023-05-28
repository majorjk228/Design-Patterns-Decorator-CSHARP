using Design_Patterns_Decorator_CSHARP.WorkWithCofee;
using System.Buffers.Text;

namespace Design_Patterns_Decorator_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Latte(); // Заказываем латте без дополнений.
            Console.WriteLine(coffee.GetDescription() + " Цена: " + coffee.Cost());

            Coffee coffee2 = new Latte();
            coffee2 = new DoubleChocolate(coffee2); // записываем в таком виде
            Console.WriteLine(coffee2.GetDescription() + " Цена: " + coffee2.Cost());

            Coffee coffee3 = new Cappuccino();
            coffee3 = new Spices(new Walnut(new DoubleChocolate(coffee3)));
            Console.WriteLine(coffee3.GetDescription() + " Цена: " + coffee3.Cost());

        }
    }
}