using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_delegates
{
    class Program
    {
        public delegate int Value();
        public delegate int AverageValue(Value[] mass);


        static readonly Random rnd = new Random();
        public static int RandomNumber() => rnd.Next(1, 100);
        public static Value[] Setter(int size)
        {
            Value[] mass = size > 0 ? new Value[size] : new Value[1];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = RandomNumber;
                Console.WriteLine($"delegate № {i + 1} = {mass[i].Invoke()}");
            }
            return mass;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int size);

            Setter(size);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"Сумма значений: {AverageValueMeth(Setter(size))}");

            Console.ReadKey();
        }

        public static int AverageValueMeth(Value[] mass)
        {
            int sum = 0;
            for (int i = 0; i < mass.Length; i++)
                sum += mass[i]();
            return sum / mass.Length;
        }
    }
}   
