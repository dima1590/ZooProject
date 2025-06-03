using System;
using Zoo.Core.Abstractions;
using Zoo.Core.Abstractions.Interfaces;
using Zoo.Core.Enclosers;
using System.Threading;
namespace Zoo.UI
{
    internal class Program
    {
        private static long EnclosureId = 1;
        static void GetEnclosure(List<EnclosureBase> enclosures)
        {

            EnclosureBase enclosure = CreateEnclosure();
            Console.Write("Введите название вольера: ");
            enclosure.Name = Console.ReadLine();

            Console.Write("Введите температуру вольера (°С): ");
            int.TryParse(Console.ReadLine(), out int temperature);
            enclosure.Temperature = temperature;

            Console.Write("Установите влажность воздуха (%): ");
            int.TryParse(Console.ReadLine(), out int humidity);
            enclosure.Humidity = humidity;

            Console.Write("Укажите вместительность вольера: ");
            int.TryParse(Console.ReadLine(), out int capacity);
            enclosure.Capacity = capacity;

            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            enclosure.Id = EnclosureId++;
            Console.WriteLine($"Вы успешно создали вольер! ID = {enclosure.Id} ");
            Console.ForegroundColor = originalColor;

            Console.Write("Для возврата нажмите 0:  ");
            enclosures.Add(enclosure);

            string choise = Console.ReadLine() ?? string.Empty;
            if (choise == "0")
            {
                ShowMainMenu(enclosures);
                return;
            }
            Console.Clear();
        }
        static EnclosureBase CreateEnclosure()
        {
            Console.WriteLine();
            Console.Write("> Вы выбрaли создание вольера < ");
            Console.WriteLine("\nВыберите тип Вольера : ");
            Console.WriteLine("1. Aквариум  \n2. Холодный вольер\n3.Теплый вольер \n ");
            Console.Write("Введите число: ");
            string number = Console.ReadLine();
            string name;
            switch (number)
            {
                case "1":
                    name = "Aквариум";
                    return new Aquarium();
                    break;
                case "2":
                    name = "Холодный вольер";
                    return new СoldEnclosure();
                    break;
                case "3":
                    name = "Теплый вольер";
                    return new WarmEnclosure();
                    break;
                default:
                    Console.WriteLine("Неверный ввод ,по умолчанию установлен (теплый)");
                    return new WarmEnclosure();
                    break;
            }
        }

        static void Main(string[] args)
        {

            var enclosures = new List<EnclosureBase>();
            ShowMainMenu(enclosures);
        }

        static void ShowMainMenu(List<EnclosureBase> enclosures)
        {
            Console.Clear();
            Console.WriteLine("*** Cистема управления зоопарком  *** ");
            Console.WriteLine();
            Console.WriteLine("1. Посмотреть все доступные вольеры ");
            Console.WriteLine("2. Добавить новый вольер ");
            Console.WriteLine("3. Выход");
            Console.WriteLine();
            Console.Write("> Выберите пункт меню: ");

            string choice = Console.ReadLine() ?? string.Empty;
            switch (choice)
            {
                case "1":
                    // InfoEnclosure(enclosures);
                    ShowAllEnclosures(enclosures);
                    break;
                case "2":
                    GetEnclosure(enclosures);
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

        static void ShowAllEnclosures(List<EnclosureBase> enclosures)
        {
            Console.Clear();
            Console.WriteLine("*** Cистема управления зоопарком  1*** ");
            Console.WriteLine();
            if (enclosures.Count == 0)
            {
                Console.WriteLine("Нет доступных вольеров.");
            }
            else
            {
                Console.WriteLine("> Вы выбрали просмотор всех вольеров <");
                foreach (var enclos in enclosures)
                {
                    Console.WriteLine($" Id: {enclos.Id}, Имя: {enclos.Name}, Температура: {enclos.Temperature}" +
                        $", Влажность: {enclos.Humidity}, Вместимость: 0 из {enclos.Capacity}");
                }
                Console.WriteLine("> Для выбора вольера введите его номер (id):");
            }
            Console.WriteLine("> Для возврата нажмите: 0");
            Console.Write("> Введите действие : ");
            string choise = Console.ReadLine() ?? string.Empty;
            if (choise == "0")
            {
                ShowMainMenu(enclosures);
                return;
            }
            Console.Clear();
           
        }
    }
}


