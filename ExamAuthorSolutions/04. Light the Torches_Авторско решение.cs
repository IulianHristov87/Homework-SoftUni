using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TeleportPoints
{
    class TeleportPoints
    {
        static void Main(string[] args)
        {
            string[] pointA = Console.ReadLine().Split(' ').ToArray();
            string[] pointB = Console.ReadLine().Split(' ').ToArray();
            string[] pointC = Console.ReadLine().Split(' ').ToArray();
            string[] pointD = Console.ReadLine().Split(' ').ToArray();

            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            double aX = double.Parse(pointA[0]);
            double aY = double.Parse(pointA[1]);
            double bX = double.Parse(pointB[0]);
            double bY = double.Parse(pointB[1]);
            double cX = double.Parse(pointC[0]);
            double cY = double.Parse(pointC[1]);
            double dX = double.Parse(pointD[0]);
            double dY = double.Parse(pointD[1]);

            int pointCounter = 0;

            //Check the right side
            for (double x = 0; x <= radius; x += step)
            {
                //Upper quadrant
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }

                //Lower quadrant
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }

            }

            //Check the left side
            for (double x = -step; x >= -radius; x -= step)
            {
                //Upper quadrant
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }

                //Lower quadrant
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }

            Console.WriteLine(pointCounter);
        }
    }
}
