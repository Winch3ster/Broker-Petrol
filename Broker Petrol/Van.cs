using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Broker_Petrol
{
    class Van : Vehicle
    {

        public Van()
        {
            //Render the image of van
            this.BackgroundImage = Broker_Petrol.Properties.Resources.van_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            //Set the maximum tank capacity for the van
            this.maximumCapacity = 80;

            //instantiating the total fuel in tank before refueling
            this.fuelInCar = rand.Next(1, Convert.ToInt32(0.25 * maximumCapacity));

            this.typeOfFuelInUse = fuelType[rand.Next(0, fuelType.Length - 1)];
        }

    }
}
