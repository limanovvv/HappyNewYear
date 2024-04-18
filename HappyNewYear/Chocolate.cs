namespace HappyNewYear;


// <summary>
/// класс Мармелад
/// наследуется от Сладости
/// </summary>
public class Chocolate: Sweet
{
    
    /// <summary>
    /// новое уникальное поле процентКакао
    /// </summary>
    public double CacaoPercent;


    /// <summary>
    /// конструтор с наследованием
    /// </summary>
    /// <param name="name"> имя </param>
    /// <param name="weight"> вес </param>
    /// <param name="price"> цена </param>
    /// <param name="flavor"> процентКакао </param>
    public Chocolate(string name, double weight, double price, double cacaoPercent) : base(name, weight, price)
    {
        CacaoPercent = cacaoPercent;
    }

    /// <summary>
    /// реализуем метод вывода для Chocolate
    /// </summary>
    /// <returns></returns>
    public override string GetInfo()
    {
        return $"{Name} -> Вес: {Weight} г, Цена: {Price} руб, Процент какао: {CacaoPercent}";
    }
}