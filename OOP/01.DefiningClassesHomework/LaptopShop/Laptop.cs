using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        public string model;
        public string manufacturer;
        public string processor;
        public int ram;
        public string graphicsCard;
        public string hdd;
        public string screen;
        public double price;
        public Battery battery;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, double price, Battery battery)
        {
            this.Model = model;
            this.Manufactorer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Price = price;
            this.Battery = battery;
        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, double price, Battery battery)
        {
            this.Model = model;
            this.Manufactorer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.Price = price;
            this.Battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Laptop should have model");
                }

                this.model = value;
            }
        }

        public string Manufactorer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Laptop should have manufactorer");
                }

                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Laptop should have processor");
                }
                this.processor = value;
            }
        }
        public int RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 1 || value > 33)
                {
                    throw new ArgumentException("Laptop RAM should be between 1 and 32 GB");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Laptop should have graphic card");
                }
                this.graphicsCard = value;
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Laptop should have HDD");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Laptop should have screen");
                }
                this.screen = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Laptop price cannot be negative or empty");
                }
                this.price = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            
            
                if (this.Manufactorer != String.Empty)
                {
                    string.Format("Model: {0}\nManufactorer: {1}\n",this.Model,this.Manufactorer);
                    if (this.Processor != String.Empty)
                    {
                        string.Format("Model: {0}\nManufactorer: {1}\nProcessor: {2}",this.Model,this.Manufactorer,this.Processor);
                        if (this.RAM > 0)
                        {
                            string.Format("Model: {0}\nManufactorer: {1}\nProcessor: {2}\nRAM: {3} GB\n", this.Model, this.Manufactorer, this.Processor, this.RAM);
                            if (this.GraphicsCard != String.Empty)
                            {
                                string.Format("Model: {0}\nManufactorer: {1}\nProcessor: {2}\nRAM: {3} GB\nGraphicsCard: {4}\n", this.Model, this.Manufactorer, this.Processor, this.RAM, this.GraphicsCard);
                                if (this.HDD != String.Empty)
                                {
                                    string.Format("Model: {0}\nManufactorer: {1}\nProcessor: {2}\nRAM: {3} GB\nGraphicsCard: {4}\nHDD:{5}\n", this.Model, this.Manufactorer, this.Processor, this.RAM, this.GraphicsCard, this.HDD);
                                    if (this.Screen != String.Empty)
                                    {
                                        string.Format("Model: {0}\nManufactorer: {1}\nProcessor: {2}\nRAM: {3} GB\nGraphicsCard: {4}\nHDD:{5}\nScreen: {6}\n", this.Model, this.Manufactorer, this.Processor, this.RAM, this.GraphicsCard, this.HDD, this.Screen);
                                        if (this.Battery != null)
                                        {
                                            return string.Format("Model: {0}\nManufactorer: {1}\nProcessor: {2}\nRAM: {3} GB\nGraphicsCard: {4}\nHDD:{5}\nScreen: {6}\n{7}\nPrice: {8} lv", this.Model, this.Manufactorer, this.Processor, this.RAM, this.GraphicsCard, this.HDD, this.Screen, this.Battery, this.Price);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            return string.Format("Model: {0} \nPrice: {1} lv", this.Model, this.Price);
        }

    }
}
