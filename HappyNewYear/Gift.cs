namespace HappyNewYear;

/// <summary>
/// используется для сбора подарка из сладостей
/// подсчета общего веса и стоимости подарка
/// также для вывода информации о сладостях в подарке
/// </summary>
public class Gift
{
    private List<Sweet> sweets = new List<Sweet>();

    public void AddSweet(Sweet sweet)
    {
        sweets.Add(sweet);
    }
    
    // метод для подсчета общего веса подарка
    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (Sweet sweet in sweets)
        {
            totalWeight += sweet.Weight;
        }
        return totalWeight;
    }
    
    // // метод для подсчета общей стоимости подарка
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Sweet sweet in sweets)
        {
            totalPrice += sweet.Price;
        }
        return totalPrice;
    }

    // метод для вывода инфы о подарке
    public void PrintSweets()
    {
        foreach (Sweet sweet in sweets)
        {
            Console.WriteLine(sweet.GetInfo());
        }
    }
}
