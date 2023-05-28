namespace Design_Patterns_Decorator_CSHARP.WorkWithCofee;

public class Spices : CoffeDecorator
{
    public Spices(Coffee component) : base(component) { } // Содержит в себе ссылку на компонента (самый родитльский класс)


    public override string GetDescription()
    {
        return this._component.GetDescription() + ", Spices"; // Кофе + добавка к нему
    }

    public override double Cost()
    {
        return this._component.Cost() + .10; // Цена кофе + цена добавки
    }
}