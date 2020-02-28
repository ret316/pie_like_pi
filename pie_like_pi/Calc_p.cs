using System;
using System.Collections.Generic;
using System.Text;

namespace pie_like_pi
{
    class Calc_p
    {
        internal double Estimate_pi(double n)
        {
            var pointsInCircle = 0;
            var allPoints = 0;
            Random random = new Random();


            for (int i = 0; i < n; i++)
            {            
                var x = random.NextDouble();
                var y = random.NextDouble();
                var mathVar = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (mathVar >= 1)
                    allPoints++;
                else
                {
                    pointsInCircle++;
                    allPoints++;
                }
                   

            }

            return 4 * (double)pointsInCircle / allPoints;
        }
    }
}
