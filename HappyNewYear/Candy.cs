namespace HappyNewYear;

/// <summary>
/// класс Конфета
/// наследуется от Сладости 
/// </summary>
public class Candy : Sweet
{
    /// <summary>
    /// новое уникальное поле Тип
    /// </summary>
    public string Type { get; set; }
    
    /// <summary>
    /// конструтор с наследованием
    /// </summary>
    /// <param name="name"> имя </param>
    /// <param name="weight"> вес </param>
    /// <param name="price"> цена </param>
    /// <param name="flavor"> вкус </param>
    public Candy(string name, double weight, double price, string type) : base(name, weight, price)
    {
        Type = type;

    }
    
    /// <summary>
    /// реализуем метод вывода для Candy
    /// </summary>
    /// <returns></returns>
    public override string GetInfo()
    {
        return $"{Name} -> Вес: {Weight} г, Цена: {Price} руб, Тип: {Type}";
    }
    

}