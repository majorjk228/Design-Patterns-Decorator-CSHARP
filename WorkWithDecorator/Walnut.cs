namespace Design_Patterns_Decorator_CSHARP.WorkWithCofee;

public class Walnut : CoffeDecorator
{
    public Walnut(Coffee component) : base(component) { } // Содержит в себе ссылку на компонента (самый родитльский класс)

    public override string GetDescription()
    {
        return this._component.GetDescription() + ", Walnut"; // Кофе + добавка к нему
    }

    public override double Cost()
    {
        return this._component.Cost() + .40; // Цена кофе + цена добавки
    }
}