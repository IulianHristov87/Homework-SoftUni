using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShopMain
    {
        static void Main(string[] args)
        {
            Battery sampleBat = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Laptop sampleInfo = new Laptop("Lenovo Yoga 2 Pro", 2259.00);
            Laptop middleInfo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", 2259.00, sampleBat);
            Laptop fullInfo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8,  "Intel HD Graphics 4400", "128GB SSD", "13.3 inch (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display ", 2259.00, sampleBat);

            Console.WriteLine("If you want to see  info only for model and price press 1 and then enter");
            Console.WriteLine("If you want see full info press 2 and then enter");
            Console.WriteLine("If you want see info without hdd and screen press 3 and then enter");

            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine(sampleInfo.ToString());
                    break;
                case "2":
                    Console.WriteLine(fullInfo.ToString());
                    break;
                case "3":
                    Console.WriteLine(middleInfo.ToString());
                    break;
                default:
                    Console.WriteLine("you cannot choice other variants");
                    break;
            }
        }
    }
}
