using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace Broker_Petrol
{
    class Vehicle : Panel
    {

        public Random rand = new Random();

        //Attributes of car
        public Pump assignedPump;

        public double fuelInCar;
        public double maximumCapacity;

        public string typeOfFuelInUse;

        //Timer
        public Timer carTimer;
        public Timer pumpTimer;

        public int startPumpingTime;
        public int currentTime;

        //Status of car
        public bool reachedPump = false;
        public bool finishPumping = false;
        public bool assignedPumpingTime = false;
        public bool releasedPump = false;
        public bool tankIsFull = false;

        //Flag to remove from waiting list
        public bool driverLeft = false;

        public string[] fuelType = { "diesel", "LPG", "unleaded" };

        //Driver temper
        public int driverTemper;
        //THis driver temper code will run once the car is instantiated and stop once the car is serviced.
        private bool startDriverTemper;


        private int moveLocationY;


        public Vehicle()
        {
            //Driver temper code
            this.driverTemper = rand.Next(135, 500);
            this.startDriverTemper = true;

            //Timer responsible for movement and driver's agitation
            carTimer = new Timer();
            carTimer.Tick += new EventHandler(carTimer_Tick);
            carTimer.Interval = 20;

            //Timer responsible for pumping timer
            pumpTimer = new Timer();
            pumpTimer.Tick += new EventHandler(pumpTimer_Tick);
            pumpTimer.Interval = 300; //1 second run once;

        }

        private void carTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            //Driver temper code
            if (startDriverTemper)
            {
                driverTemper -= 1;
                //if driver temper is less than 0, remove it from the waiting lot
                if (driverTemper < 0)
                {
                    //remove vehicle from waiting lot
                    driverLeft = true;
                }
            }

            if (StartDriverTemper == false)
            {
                //The entire code below this
                //Instead of starting the timer straight away, use switch to enable the bottom peach of code
                currentTime = DateTime.Now.Second;
                MoveToPump(); //go to pump location

                //Reached pump
                //The x coordinate of the pump matches the x cordinate of the vehicle
                if (this.Left >= assignedPump.Location.X)
                {
                    reachedPump = true;
                }

                //once it reached the pump
                if (reachedPump)
                {
                    //start pumping time
                    if (assignedPumpingTime == false)
                    {
                        startPumpingTime = DateTime.Now.Second;
                        assignedPumpingTime = true; //Start the pumping time
                    }
                    //pump the car
                    if (tankIsFull != true)
                    {
                        pumpTimer.Start();
                    }

                    if (tankIsFull)
                    {
                        //After finish pumping, set finish pumping to true and reached pump false;
                        finishPumping = true;

                        reachedPump = false;
                    }
                }

                //once pumping time finished, free the pump
                //move the car to exit
                if (finishPumping)
                {

                    //A releasedPump variable is needed otherwise the "assignedPump.Tag = "available" will keep running
                    //At first it will set the pump to available, but because it is still in the premise(finish pumping is true) 
                    //it will still assignedPump.Tag = "available"; eventhough the next vehicle has set it to false;
                    if (releasedPump == false)
                    {
                        assignedPump.Tag = "available";
                        releasedPump = true;
                    }

                    exitPremise();
                }

            }

        }


        private void pumpTimer_Tick(object sender, EventArgs e)
        {
            pumpVehicle();

            //If the tank is full, stop pumping
            if (fuelInCar >= maximumCapacity)
            {
                tankIsFull = true;
                pumpTimer.Stop();
            }
        }

        private void pumpVehicle()
        {
            if (fuelInCar < maximumCapacity)
            {
                this.fuelInCar += 5;
                SimulationView.FuelDispensed += 5;
                assignedPump.TotalFuelDispensedByPump += 5;

                //check which fuel it is using then increment the appropriate variable counter
                switch (this.typeOfFuelInUse)
                {
                    case "diesel":
                        SimulationView.DieselDispensed += 5;
                        assignedPump.DieselDispensedByPump += 5; 
                        break;
                    case "LPG":
                        SimulationView.LPGDispensed += 5;
                        assignedPump.LpgDispensedByPump += 5;
                        break;
                    case "unleaded":
                        SimulationView.UnleadedDispensed += 5;
                        assignedPump.UnleadedDispensedByPump += 5;
                        break;
                }

            }
        }

        //Vehicle movement code 
        public void MoveToPump()
        {
            //Move to the right as long as it has'nt reach its assigned pump
            if (this.Left < assignedPump.Location.X)
                this.Left += 2;
        }

        public void exitPremise()
        {
            //Move the vehicle out of the lane (in vertical direction)
            if (this.moveLocationY < 15)//move the vehicle upward by 15 pixels
            {
                this.Top--;    
                this.moveLocationY++;
            }

            //Move the vehicle until it is out of the view
            if (this.Left < (SimulationView.WindowsWidth + SimulationView.WindowsStartXCoordinate + 200))
            {
                this.Left += 2;
                
            }
            else //once the vehicle "exit" the premise, stop its timer and set it to invisible
            {
                carTimer.Stop();
                this.Visible = false;

                //The vehicle object is ready to be deleted to free up resources
                driverLeft = true; 
            }
        }




        //Getter code (Read only)

        //In the Form1.cs set this to true once it is instantiated in the array
        //If the car is being pulled to be serviced set this to false;
        public bool StartDriverTemper
        {
            get { return startDriverTemper; }
            set { startDriverTemper = value; }
        }




    }
}
