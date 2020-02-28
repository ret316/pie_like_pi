using System;

namespace pie_like_pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number of points: ");
            double nPoints = Convert.ToDouble(Console.ReadLine());
            double pi = new Calc_p().Estimate_pi(nPoints);
            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}
