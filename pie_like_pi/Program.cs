using System;

namespace pie_like_pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number of points: ");
            double pi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new Calc_p().Estimate_pi(pi));
            Console.ReadKey();
        }
    }
}
