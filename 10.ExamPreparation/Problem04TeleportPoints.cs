using System;
using System.Linq;


class TeleportPoints
{
    static void Main()
    {
        double[] a = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] b = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] c = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] d = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        //x(x)^ 2 + (y) ^ 2 < radius ^ 2
        int count = 0;
        //right side
        for (double x = 0; x <= radius; x+=step)
        {
            for (double y = 0; y <= radius; y+=step)
            {
                if (x * x + y * y <= radius * radius)
                {
                    if (x > a[0] && x < b[0] && y > a[1] && y < c[1])
                    {
                        count++;
                    }
                }
            }

            for (double y = -step; y >= -radius; y -= step)
            {
                if (x * x + y * y <= radius * radius)
                {
                    if (x > a[0] && x < b[0] && y > a[1] && y < c[1])
                    {
                        count++;
                    }
                }
            }
        }

        //left side
        for (double x = -step; x >= -radius; x -= step)
        {
            for (double y = 0; y <= radius; y += step)
            {
                if (x * x + y * y <= radius * radius)
                {
                    if (x > a[0] && x < b[0] && y > a[1] && y < c[1])
                    {
                        count++;
                    }
                }
            }

            for (double y = -step; y >= -radius; y -= step)
            {
                if (x * x + y * y <= radius * radius)
                {
                    if (x > a[0] && x < b[0] && y > a[1] && y < c[1])
                    {
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}

