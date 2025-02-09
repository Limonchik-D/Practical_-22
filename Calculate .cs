using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical__22
{/// <summary>
/// Создать класс Calculate с указанными двумя полями (Поле 1: вещественное число, Поле 2: вещественное число) и методами: 
/// конструкторы для инициализации объекта(без параметров, с одним параметром, с двумя параметрами); 
/// функция формирования строки с информацией об объекте; функция обработки значений полей: вычислить корень квадратный из произведения чисел.
/// </summary>
    internal class Calculate
    {
        public double material;
        public double material2;

        public Calculate() //без параметров
        {
            material = 0;
            material2 = 0;
        }
        public Calculate(double mtl) //С одним параметром
        {
            material = mtl;
            material2 = 0;
        }
        public Calculate(double mtl, double mtl2)//С двумя параметрами
        {
            material = mtl;
            material2 = mtl2;
        }
        public double Function()
        {
            double result = Math.Sqrt(material * material2);
            return result >= 0 ? Math.Sqrt(result): double.NaN;
        }
        public override string ToString()
        {
            return $"Число 1: {material}, Число 2: {material2}, Корень произведения {Function()}";
        }
    }
}
