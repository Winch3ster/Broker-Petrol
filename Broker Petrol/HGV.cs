using System;
namespace Broker_Petrol
{
    class HGV : Vehicle
    {

        public HGV()
        {
            //Render the image of HGV
            this.BackgroundImage = Broker_Petrol.Properties.Resources.HGV1_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            //Set the maximum tank capacity for the HGV
            this.maximumCapacity = 150;

            //instantiating the total fuel in tank before refueling
            this.fuelInCar = rand.Next(1, Convert.ToInt32(0.25 * maximumCapacity));

            this.typeOfFuelInUse = "diesel"; //HGVs can only run on diesel
        }
    }
}
