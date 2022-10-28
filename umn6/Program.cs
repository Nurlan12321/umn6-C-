using System;

namespace umn6
{
    class Program
    {
        static void Main(string[] args)
        {
           Double A, B,C;
            C = 0;
            B = 0;
            A = 0;
            try
            {
                Console.WriteLine("Введите первое число:");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите воторое число:");
                B = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите число:");
                Console.ReadKey();
            }
            for (int i=0;  i<B; i++ )
            {
              C += A;

            }
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
