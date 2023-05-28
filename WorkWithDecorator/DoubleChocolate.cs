namespace Design_Patterns_Decorator_CSHARP.WorkWithCofee;

public class DoubleChocolate : CoffeDecorator
{
    public DoubleChocolate(Coffee component) : base(component){} // Содержит в себе ссылку на компонента (самый родитльский класс)


    public override string GetDescription()
    {
        return this._component.GetDescription() + " + Double Chocolate"; // Кофе + добавка к нему
    }

    public override double Cost()
    {
        return this._component.Cost() + .20; // Цена кофе + цена добавки
    }
}