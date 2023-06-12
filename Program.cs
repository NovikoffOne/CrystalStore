using System;

namespace CrystalStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 10;

            Console.WriteLine("Добро пожаловть в магазин кристаллов! Курс равен 1:10 ");

            Console.Write("Сколько у вас золота : ");
            int gold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристаллов вы хотите приобрести? : ");
            int crystalCount = Convert.ToInt32(Console.ReadLine());

            gold -= crystalCount * crystalPrice;

            Console.WriteLine($"В вашем инвентаре {crystalCount} кристаллов и {gold}");
        }
    }
}