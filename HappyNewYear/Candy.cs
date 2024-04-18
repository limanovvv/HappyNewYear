namespace HappyNewYear;

/// <summary>
/// класс Конфета наследуется от Сладости 
/// </summary>
public class Candy : Sweet
{
    // новое уникальное поле Тип
    public string Type { get; set; }
    
    public Candy(string name, double weight, double price, string type) : base(name, weight, price)
    {
        Type = type;

    }
    
    // переопределенный метод вывода для Candy
    // добавляем тип
    public override string GetInfo()
    {
        return base.GetInfo() + $", Тип: {Type}";
    }
    

}