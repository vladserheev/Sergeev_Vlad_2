using System;


namespace laba2
{
    internal static class Program
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            bool showMenu = true;
            Bus[] busses =
            {
                new Bus("Zaz", "BA4585AK", 40, 20),
                new Bus("Renault", "BA5456HM", 20, 15),
                new Bus("BMW", "BA7777HM", 30, 16)
            };
            BusPark busPark = new BusPark(busses);

            Console.WriteLine("Початсковий список автобусів:");
            busPark.ShowAllBusses();

            while (showMenu)
            {
                showMenu = Menu(busPark);
            }
        }
        private static bool Menu(BusPark busPark)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Оберіть метод:");
            Console.WriteLine("1) Дізнатися кількість автобсів");
            Console.WriteLine("2) Сортувати за кількістю сидячих місць");
            Console.WriteLine("3) Пошук за номерним знаком");
            Console.WriteLine("4) Пошук за параметром споживання пального");
            Console.WriteLine("5) Завершити виконання");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Кількість автобусів: {busPark.GetBussesNum()}");
                    return true;
                case "2":
                    busPark.SortBussesBySeatsNum();
                    return true;
                case "3":
                    Console.WriteLine("Введіть номерний знак:");
                    string a = Console.ReadLine();
                    Bus bus1 = busPark.GetBusByPlate(a);
                    if (bus1 == null)
                    {
                        Console.WriteLine("Автобус не знайденно!");
                    }
                    else
                    {
                        bus1.Show();
                    }
                    return true;
                case "4":
                    Console.WriteLine("Введіть параметр споживання пального:");
                    int b = Int32.Parse(Console.ReadLine());

                    Bus bus2 = busPark.GetBusByFuelParameter(b);
                    if (bus2 == null)
                    {
                        Console.WriteLine("Автобус не знайденно!");
                    }
                    else
                    {
                        bus2.Show();
                    }

                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
    }


}

