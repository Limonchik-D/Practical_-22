using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical__22
{
    internal class Program
    {/// <summary>
     /// Создать объекты класса: с использованием конструктора без параметров и присваивания значений полям объекта; 
     /// с явной инициализацией; с использованием конструктора с двумя параметрами, введенными с клавиатуры.
     /// </summary>
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate(); //конструктор без параметров и присваивание значений полям объекта
            
                calculate.material = 5;
                calculate.material2 = 10;
                Console.WriteLine(calculate);
            Console.WriteLine();

            Calculate calculate1 = new Calculate(4.5, 14.2); //явная инициализация
            
                Console.WriteLine(calculate1);
            Console.WriteLine();

            Console.Write("Введите число: ");
            double material;
            while(!double.TryParse(Console.ReadLine(), out material))
            {
                Console.Write("Ошибка! Введите число: ");
            }

            Console.Write("Введите число: ");
            double material2;
            while (!double.TryParse(Console.ReadLine(), out material2))
            {
                Console.Write("Ошибка! Введите число: ");
            }    
            Calculate calculate2 = new Calculate(material, material2); //в ручную
            Console.WriteLine(calculate2);

            Console.ReadKey();
        }
    }
}
