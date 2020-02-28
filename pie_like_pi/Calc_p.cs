using System;
using System.Collections.Generic;
using System.Text;

namespace pie_like_pi
{
    class Calc_p
    {
        internal int Estimate_pi(double n)
        {
            var pointsInCircle = 0;
            var allPoints = 0;
            Random random = new Random();
            var x = random.Next(0, 1);
            var y = random.Next(0, 1);

            for (int i = 0; i < n; i++)
            {
                var mathVar = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (mathVar >= 1)
                    allPoints++;
                else
                {
                    pointsInCircle++;
                    allPoints++;
                }
                   

            }
            return 4 * pointsInCircle / allPoints;
        }
    }
}
