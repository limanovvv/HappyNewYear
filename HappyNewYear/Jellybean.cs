namespace HappyNewYear;

/// <summary>
/// класс Мармелад наследуется от Сладости
/// </summary>
public class Jellybean : Sweet
{
    // новое уникальное поле Вкус
    public string Flavor { get; set; }

    public Jellybean(string name, double weight, double price, string flavor) : base(name, weight, price)
    {
        Flavor = flavor;
    }

    // переопределенный метод вывода для Jellybean
    // добавляем вкус
    public override string GetInfo()
    {
        return base.GetInfo() + $", Вкус: {Flavor}";
    }

}
