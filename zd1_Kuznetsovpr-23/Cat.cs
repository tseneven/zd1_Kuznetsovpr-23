using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Kuznetsovpr_23
{
    internal class Cat
    {
        private string name;
        private double ves;

        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        // Инкапсуляция поля вес
        public double Ves 
        {
            get 
            {
                return ves;
            }
            set
            {

                if (value > 0.5)
                {
                    ves = value;
                }
                else
                {
                    Console.WriteLine($"Вес не может быть отрицательным или равным нулю у кота {name}");
                }
            }
        }

        //Конструтор
        public Cat(string CatName, double CatVes)
        {
            Name = CatName;
            Ves = CatVes;
        }

        // Метод с печатью "Мяу"
        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯЯУ!!!!");
        }


    }
}
