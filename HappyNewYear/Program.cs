namespace HappyNewYear;

class Program
{
    static void Main()
    {
        Gift gift = new Gift();

        Candy candy1 = new Candy("Конфета", 100, 50, "Горькая");
        Candy candy2 = new Candy("Леденец", 20, 10, "Фруктовый");
        Jellybean jellybean = new Jellybean("Мармелад", 50, 30, "Вишневый");
        Chocolate chocolate = new Chocolate("Шоколад", 150, 100, 27.5);

        gift.AddSweet(candy1);
        gift.AddSweet(candy2);
        gift.AddSweet(jellybean);

        Console.WriteLine("Информация о сладостях в подарке:");
        
        gift.PrintSweets();

        Console.WriteLine($"Общий вес подарка: {gift.GetTotalWeight()} г");
        Console.WriteLine($"Общая стоимость подарка: {gift.GetTotalPrice()} руб");
    }
}