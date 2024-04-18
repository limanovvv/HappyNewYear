namespace HappyNewYear;

/// <summary>
/// класс Мармелад
/// наследуется от Сладости
/// </summary>
public class Jellybean : Sweet
{
    /// <summary>
    /// новое уникальное поле Вкус
    /// </summary>
    public string Flavor { get; set; }

    /// <summary>
    /// конструтор с наследованием
    /// </summary>
    /// <param name="name"> имя </param>
    /// <param name="weight"> вес </param>
    /// <param name="price"> цена </param>
    /// <param name="flavor"> вкус </param>
    public Jellybean(string name, double weight, double price, string flavor) : base(name, weight, price)
    {
        Flavor = flavor;
    }

    /// <summary>
    /// реализуем метод вывода для Jellybean
    /// </summary>
    /// <returns></returns>
    public override string GetInfo()
    {
        return $"{Name} -> Вес: {Weight} г, Цена: {Price} руб, Вкус: {Flavor}";
    }

}
