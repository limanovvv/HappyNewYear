namespace HappyNewYear;

/// <summary>
/// базовый класс Сладость
/// </summary>
public class Sweet
{
    /// <summary>
    /// поля Имя Вес Цена
    /// </summary>
    public string Name;
    public double Weight;
    public int Price;
    

    /// <summary>
    /// конструтор с параметрами 
    /// </summary>
    /// <param name="name"> имя </param>
    /// <param name="weight"> вес </param>
    /// <param name="price"> цена </param>
    public Sweet(string name, double weight, double price)
    {
        Name = name;
        Weight = weight;
        Price = (int)price;
    }

    /// <summary>
    /// метод вывода инфы о сладости
    /// реализуем в классах-наследниках
    /// </summary>
    /// <returns></returns>
    public virtual string GetInfo()
    {
        return " ";
    }
}