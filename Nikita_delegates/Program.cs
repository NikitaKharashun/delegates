using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_delegates.BaseElements;

namespace Nikita_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int size);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"Среднее значение: {Delegates.averageValue(Delegates.Setter(size))}");

            Console.ReadKey();
        }
    }
}   
