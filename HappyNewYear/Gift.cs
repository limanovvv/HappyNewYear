namespace HappyNewYear;

/// <summary>
/// класс Gift
/// используется для сбора подарка из сладостей
/// подсчета общего веса и стоимости подарка
/// также для вывода информации о сладостях в подарке
/// </summary>
public class Gift
{
    /// <summary>
    /// лист для хранения сладостей
    /// </summary>
    public List<Sweet> sweets = new List<Sweet>();

    /// <summary>
    /// метод добавления сладости в лист
    /// </summary>
    /// <param name="sweet"> сладости </param>
    public void AddSweet(Sweet sweet)
    {
        sweets.Add(sweet);
    }

    /// <summary>
    /// метод для подсчета общего веса подарка
    /// внутри лямбда
    /// </summary>
    /// <returns> суммарный вес подарка </returns>

    public double GetTotalWeight()
    {
        
        return sweets.Sum(x => x.Weight);
        
    }




    /// <summary>
    /// метод для подсчета общей стоимости подарка
    /// внутри лямбда
    /// </summary>
    /// <returns> суммарная стоимость подарка </returns>
    public double GetTotalPrice()
    {
        
        return sweets.Sum(x => x.Price);
        
    }
    
    /// <summary>
    /// метод для вывода инфы о подарке с помощью лямбд
    /// сначала сортируем по алфавиту для имен сладостей
    /// только потом вывод
    /// </summary>
   
    
    public List<string> GetSweetsInfo()
    {
        return sweets.Select(e => e.GetInfo()).ToList();
    }
    
}
    
    
