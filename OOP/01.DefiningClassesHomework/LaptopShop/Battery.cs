using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        public string batteryModel;
        public double batteryLife;

        public Battery(string batteryModel, double batteryLife)
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Battery should have a model");
                }
                this.batteryModel = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            } 
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Battery life cannot be negative, empty or 0");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Battery Model: {0} \nBattery Life: {1} hours",this.BatteryModel,this.BatteryLife);
        }
    }
}
