namespace Design_Patterns_Decorator_CSHARP.WorkWithCofee;

// Данный класс является Декоратором
public abstract class CoffeDecorator : Coffee
{
    protected Coffee _component; // переменная для хранения ссылки (Основого абстрактного класса)

    public CoffeDecorator(Coffee component)
    {
        this._component = component; // Присваваем пришедшый к нам объект (матрешка)
    }

    public override string GetDescription()
    {
        return this._component.GetDescription(); // Возвращаем описание пришедшего нам объекта
    }

    public override double Cost()
    {
        return this._component.Cost();          // Возвращаем стоимость пришедшего нам объекта
    }
}