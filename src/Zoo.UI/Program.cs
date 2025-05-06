using System;
using Zoo.Core.Abstractions;
using Zoo.Core.Abstractions.Interfaces;
using Zoo.Core.Enclosers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zoo.UI
{
    internal class Program
    {
        private static long EnclosureId = 1;
        static void GetEnclosure(EnclosureBase enclosure)
        {
            Console.Clear();
            Console.WriteLine("Введите название вольера: ");
            enclosure.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Введите температуру вольера (°С): ");
                if (int.TryParse(Console.ReadLine(), out int temperature))
                {
                    enclosure.Temperature = temperature;
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод температуры.");
                }
            }
            while (true)
            {
                Console.WriteLine("Установите влажность воздуха (%): ");
                if (int.TryParse(Console.ReadLine(), out int humidity))
                {
                    enclosure.Humidity = humidity;
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод вместимости.");
                }
            }
            while (true)
            {
                Console.WriteLine("Укажите вместительность вольера: ");
                if (int.TryParse(Console.ReadLine(), out int capacity))
                {
                    enclosure.Capacity = capacity;
                    break;
                }
                else
                {
                    Console.WriteLine("введите корректное число ");
                }
            }

            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            enclosure.Id = EnclosureId++;
            Console.WriteLine($"Вы успешно создали вольер! ID = {enclosure.Id} ");
            Console.ForegroundColor = originalColor;
        }
        static EnclosureBase CreateEnclosure() {
            Console.WriteLine("\nВыберите тип Вольера : ");
            Console.WriteLine("Aquarium: = 1\nСoldEnclosure: = 2\nWarmEnclosure: = 3\n ");
            Console.Write("Введите число: ");
            string number = Console.ReadLine();
            switch (number)
                {
                   case "1":
                    return new Aquarium();
                        break;
                   case "2":
                    return new СoldEnclosure();
                        break;
                   case "3":
                    return new WarmEnclosure();
                         break;
                   default:
                        Console.WriteLine("Неверный ввод ,по умолчанию (теплый)");
                    return new WarmEnclosure();
                    break;                 
                 }
        }

        static void Main(string[] args)
        {   
            List<EnclosureBase> enclosures = new List<EnclosureBase>();
            while (true)
            {
                Console.WriteLine("   Меню : ");
                Console.WriteLine("1. Добавить новый вольер ");
                Console.WriteLine("2. Посмотреть все доступные вольеры ");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите пункт меню: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnclosureBase Enclosure = CreateEnclosure();
                        GetEnclosure(Enclosure);
                        enclosures.Add(Enclosure);    
                        break;
                    case "2":
                        InfoEnclosure();
                        break;
                    case "3":
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
                Console.WriteLine();
            }         
            void InfoEnclosure()
            {
                Console.Clear();
                if (enclosures.Count == 0)
                {
                    Console.WriteLine("Нет доступных вольеров.");
                }
                else
                {
                    Console.WriteLine("Список вольеров:");
                    foreach (var enclos in enclosures)
                    {
                        Console.WriteLine($"Id: {enclos.Id}");                       
                        Console.WriteLine($"Name: {enclos.Name}");
                        Console.WriteLine($"Temperature: {enclos.Temperature}");
                        Console.WriteLine($"Humidity: {enclos.Humidity}");
                        Console.WriteLine($"Capacity: {enclos.Capacity}");
                        Console.WriteLine(new string('-', 20));
                    }
                   
                }
            }
        }
    }


}