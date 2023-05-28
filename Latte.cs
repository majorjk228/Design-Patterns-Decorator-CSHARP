namespace Design_Patterns_Decorator_CSHARP;

public class Latte : Coffee
{
    public override string GetDescription()
    {
        return "Latte"; // Устанавлием описание
    }

    public override double Cost()
    {
        return 1.99;           // Устанавлием цену
    }
}