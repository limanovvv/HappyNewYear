namespace HappyNewYear;

/// <summary>
/// базовый класс с общими полями Имя Цена Вес
/// </summary>
public class Sweet
{
    public string Name;
    public double Price;
    public double Weight;

    public Sweet(string name, double weight, double price)
    {
        Name = name;
        Weight = weight;
        Price = price;
    }
    
    // виртуальный метод вывода инфы о сладости 
    // переопределяем в классах-наследниках
    public virtual string GetInfo()
    {
        return $"{Name} -> Вес: {Weight} г, Цена: {Price} руб";
    }
}