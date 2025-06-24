using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zd2_Kuznetsovpr_23;
using zd3_Kuznetsov_pr_23;
using static System.Net.Mime.MediaTypeNames;
using zd1_Kuznetsovpr_23;

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
                Console.WriteLine("1. Работа с классом Cat");
                Console.WriteLine("2. Работа с магазином");
                Console.WriteLine("3. Работа с плейлистом");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Program3.Main();
                        break;
                    case "2":
                        Program2.Main();
                        break;
                    case "3":
                        Program1.Main();
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
