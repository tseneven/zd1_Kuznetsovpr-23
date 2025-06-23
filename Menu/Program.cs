using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Главное меню ===");
                Console.WriteLine("1. Работа с плейлистом");
                Console.WriteLine("2. Демонстрация модуля 1");
                Console.WriteLine("3. Демонстрация модуля 2");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Program.Main();
                        break;
                    case "2":
                        Module1.Run();
                        break;
                    case "3":
                        Module2.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
