using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Petrol
{
    class Car : Vehicle
    {
        public Car()
        {
            //Render the image of car
            this.BackgroundImage = Broker_Petrol.Properties.Resources.car1_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            //Set the maximum tank capacity for the car
            this.maximumCapacity = 40;

            //instantiating the total fuel in tank before refueling
            this.fuelInCar = rand.Next(1, Convert.ToInt32(0.25 * maximumCapacity));

            this.typeOfFuelInUse = fuelType[rand.Next(0, fuelType.Length)];
        }


    }
}
