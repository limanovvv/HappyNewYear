namespace HappyNewYear;

using Newtonsoft.Json;


/// <summary>
/// класс расширение для класса Gift
/// реализует методы работы с json файлами
/// </summary>
public static class GiftExtensions
{
    /// <summary>
    /// сохраняет в файл данные в формате json
    /// сериализованные из объекта Gift
    /// </summary>
    /// <param name="gift"> объект класса Gift </param>
    /// <param name="fileName"> имя файла, куда сохраняем подарок </param>
    public static void SaveToJson(this Gift gift, string fileName)
    {
        string json = JsonConvert.SerializeObject(gift, Formatting.Indented);
        File.WriteAllText(fileName, json);
        
        Console.WriteLine($"Подарок сохранен в файл: {fileName}");
    }

    /// <summary>
    /// загружает из json файла данные
    /// десериализует их в объект Gift
    /// </summary>
    /// <param name="fileName"> имя файла, </param>
    /// <returns></returns>
    public static Gift LoadFromJson(string fileName)
    {
        string json = File.ReadAllText(fileName);
        Gift gift = JsonConvert.DeserializeObject<Gift>(json);
        
        Console.WriteLine($"Подарок загружен из файла: {fileName}");
        return gift;
    }
}