using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zd1_Kuznetsovpr_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat = null;
            while (true)
            {
                try
                {
                    Console.WriteLine("1. Создать кота");
                    Console.WriteLine("2. Say Meow");
                    Console.WriteLine("3. Выход");
                    int answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == 1)
                    {
                        Console.WriteLine("Введите имя кота");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите вес кота");
                        double ves = Convert.ToDouble(Console.ReadLine());
                        cat = new Cat(name, ves);
                        Console.WriteLine($"Кот {name} создан");
                    }
                    if (answer == 2)
                    {
                        if (cat != null)
                        {
                            cat.Meow();
                        }
                        else
                        {
                            Console.WriteLine("Кот не выбран");
                        }
                    }
                    if (answer == 3)
                    {
                        break;
                    }
                } 
                catch (Exception)
                {
                    throw new Exception("Ошибка конвертации данных");
                }

            }

        }
    }
}
