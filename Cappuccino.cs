namespace Design_Patterns_Decorator_CSHARP;

public class Cappuccino : Coffee
{
    public override string GetDescription()
    {
        return "Cappuccino"; // Устанавлием описание
    }

    public override double Cost()
    {
        return 2.99;           // Устанавлием цену
    }
}