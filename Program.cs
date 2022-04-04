using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenty_try_catch_04._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i1, i2;
                int[] arr = { 2, 5, 8, 4, 6, 3, 1, 7, 10, 9 };
                Console.Write("Введите первый индекс: ");
                i1 = int.Parse(Console.ReadLine());
                Console.Write("Введите первый индекс: ");
                i2 = int.Parse(Console.ReadLine());

                int sum = arr[i1] + arr[i2];
                Console.WriteLine(sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не верный ввод данных");
                Console.WriteLine("индексы больше чем размерность массива...." + ex);
            }
            Console.ReadKey();
        }
    }
}
