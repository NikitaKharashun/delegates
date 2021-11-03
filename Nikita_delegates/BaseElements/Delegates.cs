using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_delegates.BaseElements
{
    class Delegates
    {
        public delegate int Value();
        public delegate int AverageValue(Value[] mass);

        static readonly Random rnd = new Random();
        public static int RandomNumber() => rnd.Next(1, 100);

        public static Value[] Setter(int size)
        {
            Value[] mass = size > 0 ? new Value[size] : new Value[1];

            for (int i = 0; i < mass.Length; i++)
                mass[i] = RandomNumber;

            return mass;
        }

        public static AverageValue averageValue = delegate (Value[] mass)
        {
            int sum = 0;
            foreach (var item in mass)
                sum += item.Invoke();

            Console.WriteLine($"Сумма всех значений: {sum}");
            return sum / mass.Length;
        };
    }
}
