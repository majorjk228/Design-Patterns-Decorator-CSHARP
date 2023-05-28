namespace Design_Patterns_Decorator_CSHARP;

// Абстрактный класс компонента(Кофе)
public abstract class Coffee
{
    public string description = "Unknown Coffee"; // У всех классов будет собственное описание (если его нет, то будет unkown)

    public abstract string GetDescription(); // Метод который позволяет поулчить описание

    public abstract double Cost(); // Стоимость каждого объекта
}