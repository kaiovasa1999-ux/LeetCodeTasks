
namespace LeetCode.PointsInTheArea
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PiCalculation
    {
        public decimal EstimitePi(long points)
        {
            var totalPoilPoints = 0;
            var posintsInCircle = 0;
            Random r = new Random();
            for (int i = 0; i < points; i++)
            {
               
                double yInt = r.NextDouble();
                double xInt = r.NextDouble();
                var distance = Math.Pow(yInt, 2.0) + Math.Pow(xInt, 2.0);

                if (distance <= 1)
                {
                    posintsInCircle++;
                }
                totalPoilPoints++;
               
            }
            decimal pi = 4 * ((decimal)posintsInCircle / totalPoilPoints);
            return pi;


        }
    }
}
