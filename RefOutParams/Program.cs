using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Золотое сечение = {MathEx.Fi}\nCеребряное сечение ={MathEx.S}\nПостоянная Каталана = {MathEx.K}" );
            double result;

            double first = -5;
            double second = 0;

            Console.WriteLine(MathEx.Divide(first, second, out result));
            Console.WriteLine(MathEx.Pow(ref first));
            Console.WriteLine(MathEx.Sum(5, 6, 7, 8));

            Console.ReadKey();
        }
    }
}
