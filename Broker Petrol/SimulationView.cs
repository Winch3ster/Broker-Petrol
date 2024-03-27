using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Broker_Petrol
{
    /// <summary>
    /// 
    /// This form is responsible for the simulation view.
    /// It include the tracking of each vehicles, pumps, assigning pumps and deleting the instances of vehicle
    /// 
    /// </summary>
    public partial class SimulationView : Form
    {

        private static int windowsWidth;
        private static int windowsStartXCoordinate;

        //fuel level in the premise
        public static int fuelDispensed = 0;

        //types of fuel
        public static int dieselDispensed = 0;
        public static int unleadedDispensed = 0;
        public static int lpgDispensed = 0;

        //types of vehicle
        string[] carType = { "car", "van", "HGV" };


        int nextSpawnTime = 2;
        int timeNow;
        int firstStartTime;

        int totalCar = 0;

        //Store the Labels used to display individual pump status
        private static Label[,] pumpStatus = new Label[3, 3];

        private static Pump[,] pumpList = new Pump[3, 3]; //3 rows 3 column
        /* ----- Pump structure -----
             * {
             * 
             *  { pump1, pump2, pump3} --> lane 0
             *  
             *  { pump4, pump5, pump6} --> lane 1
             * 
             *  { pump7, pump8, pump9} --> lane 2
             *  
             *  }
             *  
             */

        bool canCreateNewCar = false;

        //counter variable
        private static int carLeftWithoutRefueling = 0;
        private static int totalServicedCar;

        Random rand = new Random();

        //Waiting lot code
        private int servicingCarLane = 0;

        //Instantiate vehicle
        private int instantiateCarLane = 0;

        //Vehicle queues
        private static List<Vehicle> vehicleQueue1 = new List<Vehicle>();
        private static List<Vehicle> vehicleQueue2 = new List<Vehicle>();
        private static List<Vehicle> vehicleQueue3 = new List<Vehicle>();


        private static List<Vehicle>[] waitingLot = new List<Vehicle>[]
        {
            vehicleQueue1,
            vehicleQueue2,
            vehicleQueue3
        }
        ;

        //List to store individual pump's fuel transaction records
        private static List<Data> dataList = new List<Data>();

        //List of vehicles in the forecourt
        private static List<Vehicle> vehiclesList = new List<Vehicle>();

        private static bool generatedData = false;

        public SimulationView()
        {
            InitializeComponent();

            //Instantiate the pumps and store them in pumpList

            // new pump (id, x - coordinate, y - coordinate)
            pumpList[0, 0] = new Pump(1, 330, 111);
            pumpList[0, 1] = new Pump(2, 455, 111);
            pumpList[0, 2] = new Pump(3, 569, 111);
            pumpList[1, 0] = new Pump(4, 330, 219);
            pumpList[1, 1] = new Pump(5, 455, 219);
            pumpList[1, 2] = new Pump(6, 569, 219);
            pumpList[2, 0] = new Pump(7, 330, 332);
            pumpList[2, 1] = new Pump(8, 455, 332);
            pumpList[2, 2] = new Pump(9, 569, 332);

            nextSpawnTime = 3; //first vehicle will spawn 3 seconds after the application starts
        }

        private void SimulationView_Load(object sender, EventArgs e)
        {

            RenderPumpsToView();
            InstantiateTag();

            firstStartTime = DateTime.Now.Second;
            simulationTimer.Start();

        }    

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            updatePumpTag();
            
            windowsWidth = this.Width;
            windowsStartXCoordinate = this.Location.X;

            timeNow = DateTime.Now.Second;

            //create new car and put it in waiting lot

            if (waitingLot[instantiateCarLane].Count < 5) //if current servicing queue is less than 5
            {
                //and can create car
                if (timeNow == ((firstStartTime + nextSpawnTime) % 60)) //current time equals to time to create new vehicle
                {
                    canCreateNewCar = true;
                    nextSpawnTime = (rand.Next(1, 3) % 60);//set next spawn time for vehicle of random time interval
                }

                if (canCreateNewCar)
                {
                    //set next spawn time for vehicle of random time interval
                    nextSpawnTime = (rand.Next(1, 3) % 60); 
                    canCreateNewCar = false;

                    firstStartTime = timeNow;

                    if (instantiateCarLane == 0 && (vehicleQueue1.Count < 5))
                    {
                        InstantiateVehicle(spawnPoint);

                    }
                    else if (instantiateCarLane == 1 && (vehicleQueue2.Count < 5))
                    {
                        InstantiateVehicle(spawnPoint2);
                    }
                    else if (instantiateCarLane == 2 && (vehicleQueue1.Count < 5))
                    {
                        InstantiateVehicle(spawnPoint3);
                    }

                    instantiateCarLane++;

                    //After instantiating a car, go to the next lane
                    if (instantiateCarLane > waitingLot.GetLength(0) - 1)
                        instantiateCarLane = 0;

                }
                
                //Update the number of cars in each queue
                queue1Count.Text = "Queue 1: " + Convert.ToString(vehicleQueue1.Count) + "   ";//Empty space to add some margin to the right
                queue2Count.Text = "Queue 2: " + Convert.ToString(vehicleQueue2.Count) + "   ";
                queue3Count.Text = "Queue 3: " + Convert.ToString(vehicleQueue3.Count) + "   ";


                foreach (Control c in Controls)
                {
                    if ((string)c.Tag == "car" || (string)c.Tag == "van" || (string)c.Tag == "HGV")
                    {
                        c.BringToFront();
                    }
                }
            }
            else
            {
                //move to the next lane to check for unocupied spot
                instantiateCarLane++;
                if (instantiateCarLane > 2) //if the lane is 3 which does not exist, go back to lane 0
                {
                    instantiateCarLane = 0;
                }

            }

            //grabbing the car from waiting lot
            bool haveFreePump = FindFreePump(servicingCarLane);
            if (haveFreePump)
            {
                //If the waiting lot have car, assign it to the pump
                if (waitingLot[servicingCarLane].Count > 0)
                {
                    //Remove the vehicle from its queue
                    Vehicle vehicle = (Vehicle)waitingLot[servicingCarLane][0];
                    waitingLot[servicingCarLane].RemoveAt(0);

                    if (vehicle.driverLeft == false)
                    {
                        Pump freePump = AssignFreePump(servicingCarLane); //assign free pump to it

                        freePump.Tag = "unavailable"; //set the pump to unavailable
                       

                        //stop driver's temper and move the car to assigned pump
                        vehicle.StartDriverTemper = false;
                        vehicle.assignedPump = freePump;

                        totalServicedCar++;
                        vehiclesList.Add(vehicle);

                        this.Controls.Add(vehicle); //add the vehicle to the view
                    }

                    //Service the next lane 
                    servicingCarLane++;
                    
                    //if the currently servicing lane is the last, go back to the first lane
                    if (servicingCarLane > 2)
                        servicingCarLane = 0;
                }
            }
            else
            {
                servicingCarLane++;
                if (servicingCarLane > 2)
                    servicingCarLane = 0;
            }

            //Loop through the waiting lot, remove any vehicle where its driver runs out of patient
            RemoveVehicleWherePatientIsZero();

            //optimize the program by removing any vehicles that are no longer visible to free the resources
            DisposeVehicles();
        }

        private void InstantiateVehicle(Panel spawnPoint)
        {
         
            //Probability of creating the following vehicles
            // 50% - car, 30% - van, 20% - HGV

            int probability = rand.Next(1, 10);
            int carIndex;
            if (probability <= 5)
            {
                carIndex = 0;
            } else if(probability > 8)
            {
                carIndex = 2;
            }
            else
            {
                carIndex = 1;
            }      

            string carTypeToBeSpawn = carType[carIndex];

            //Based on carTypeToBeSpawn variable instantiate the vehicle
            switch (carTypeToBeSpawn)
            {
                case "car":
                    //spawn car
                    Car myCar = new Car();                
                    myCar.Location = new Point(spawnPoint.Location.X, spawnPoint.Location.Y);
                    myCar.Size = new Size(20, 10);
                    myCar.Tag = "car";

                    myCar.carTimer.Start();

                    waitingLot[instantiateCarLane].Add(myCar);
                    totalCar++;

                    break;

                case "van":
                    //spawn van
                    Van myVan = new Van();
                    myVan.Location = new Point(spawnPoint.Location.X, spawnPoint.Location.Y);
                    myVan.Size = new Size(25, 15);
                    myVan.Tag = "van";

                    myVan.carTimer.Start();

                    waitingLot[instantiateCarLane].Add(myVan);
                    totalCar++;
                    break;

                case "HGV":
                    //spawn HVG
                    HGV myHVG = new HGV();
                    myHVG.Location = new Point(spawnPoint.Location.X, spawnPoint.Location.Y);
                    myHVG.Size = new Size(42, 15);
                    myHVG.Tag = "HGV";

                    myHVG.carTimer.Start();

                    waitingLot[instantiateCarLane].Add(myHVG);
                    totalCar++;

                    break;
            }
        }
        private void RemoveVehicleWherePatientIsZero()
        {
            //Iterate throught the waiting lot
            foreach (List<Vehicle> waitinglane in waitingLot)
            {
                //if the queue contains vehicle, iterate through it
                if (waitinglane.Count > 0)
                {
                    for (int i = 0; i < waitinglane.Count(); i++)
                    {
                       //If the vehicle's waiting period reaches 0 and still not being serviced
                        if (waitinglane[i].driverLeft == true)
                        {
                            //delete the instance of that vehicle
                            carLeftWithoutRefueling++;
                            vehiclesList.Add(waitinglane[i]);
                            waitinglane.RemoveAt(i);
                                       
                        }
                    }
                }
            }
        }


        //find free pump
        public bool FindFreePump(int servicingCarLane)
        {
            //false -> no pump
            //true -> pump available
            bool result = false;

            //if the first pump is available, move the car to the pump
            //and check if there is any unocupied pump infront (will be executed by assignFreePump() method)
            if ((string)pumpList[servicingCarLane, 0].Tag == "available") // available      first pump is available
            {
                result = true;
            }

            return result;
        }

        private Pump AssignFreePump(int lane)
        {
            Pump result = null;

            for (int i = 0; i < pumpList.GetLength(1); i++)
            {

                if ((i < pumpList.GetLength(1) - 1))
                {
                    if ((string)pumpList[lane, i + 1].Tag == "available") //if the front pump is available
                    {
                        continue; //move to forward pump
                    }
                    else
                    {
                        //if the front pump is unavailable, use this pump instead
                        result = pumpList[lane, i];
                        break;
                    }
                }

                //If the vehicle is at the last pump on the lane, use the pump 
                //This is because if the car can travel to the pump, it means the pump is free
                //and there is no more pump in front of the vehicle
                if (i == pumpList.GetLength(1) - 1)
                {
                    result = pumpList[lane, i];
                }
            }

            return result; //return the available pump to be assigned to waiting vehicle
        }
        private void RenderPumpsToView()
        {
            //Iterate through the 2-dimensional pump list
            for (int i = 0; i < pumpList.GetLength(0); i++)
            {
                for (int j = 0; j < pumpList.GetLength(1); j++)
                {
                    this.Controls.Add(pumpList[i, j]);//Add the pump to view
                }
            }
        }

        private void InstantiateTag()
        {
            //Iterate through the 2-dimensional tag list
            for (int i = 0; i < pumpList.GetLength(0); i++)
            {
                for (int j = 0; j < pumpList.GetLength(1); j++)
                {
                    //Set the tag attibutes
                    Label pumpStatusTag = new Label();
                    pumpStatusTag.AutoSize = true;             
                    pumpStatusTag.Text = "available";
                    pumpStatus[i, j] = pumpStatusTag;

                    //The tag is located just below its pump
                    pumpStatusTag.Location = new Point(pumpList[i, j].xCoordinate - 5, pumpList[i, j].yCoordinate + 25);


                    this.Controls.Add(pumpStatus[i, j]);//Add the tag to view
                }
            }
        }

        private void updatePumpTag()
        {
            //Iterate through the 2-dimensional tag list
            for (int i = 0; i < pumpStatus.GetLength(0); i++)
            {
                for (int j = 0; j < pumpStatus.GetLength(1); j++)
                {
                    //Set the tag text to its pump's availability
                    pumpStatus[i, j].Text = (string)pumpList[i, j].Tag;

                    //Change the color of the text based on the pump's availability 
                    if (pumpStatus[i, j].Text == "unavailable")
                    {
                        pumpStatus[i, j].ForeColor = Color.Red; 
                    }
                    else
                    {
                        pumpStatus[i, j].ForeColor = Color.Green;
                    }
                }
            }
        }
        public void DisposeVehicles()
        {
            for (int i = 0; i < vehiclesList.Count(); i++)
            {
                if (vehiclesList[i].driverLeft == true)
                {
                    //delete instance of the vehicle to free up resources
                    vehiclesList[i].Dispose();
                    vehiclesList.RemoveAt(i);                    
                }
            }
        }

        /// <summary>
        ///  The GeneratePumpData() will generate the fuel transactions summary of each pump
        ///  The fuel transactions summary at each pump will be stored in a data object.
        ///  This data object will then be stored in the "dataList"
        ///  
        ///  The structure is similar to JSON
        /// 
        /// </summary>
        public static void GeneratePumpDataSummary()
        {
            // iterate throught the 2-dimensional pump list
            for (int i = 0; i < pumpList.GetLength(0); i++)
            {
                for (int j = 0; j < pumpList.GetLength(1); j++)
                {

                    dataList.Add(
                        
                        //Create a new data object and add it to dataList
                        new Data()
                        {
                        //Get the id of the pump
                        pumpId = pumpList[i, j].Id,

                        //Get the fuel transactions of the pump
                        totalFuelDispensed = pumpList[i, j].TotalFuelDispensedByPump,
                        totalLPGDispensed = pumpList[i, j].LpgDispensedByPump,
                        totalUnleadedDispensed = pumpList[i, j].UnleadedDispensedByPump,
                        totalDieselDispensed = pumpList[i, j].DieselDispensedByPump
                        });
                }
            }

            //Once the generatedData is set to true, Form3 will stop the simulation
            //and open up the shift report page
            generatedData = true;
        }


        //Getters and setters
        public static int FuelDispensed
        {
            get { return fuelDispensed; }
            set { fuelDispensed = value; }
        }

        public static int DieselDispensed
        {
            get { return dieselDispensed; }
            set { dieselDispensed = value; }
        }

        public static int UnleadedDispensed
        {
            get { return unleadedDispensed; }
            set { unleadedDispensed = value; }
        }

        public static int LPGDispensed
        {
            get { return lpgDispensed; }
            set { lpgDispensed = value; }
        }

        public static int CarLeftWithoutRefueling
        {
            get { return carLeftWithoutRefueling; }
            set { carLeftWithoutRefueling = value; }
        }

        //Read only data
        public static int WindowsWidth
        {
            get { return windowsWidth; }
        }

        public static int WindowsStartXCoordinate
        {
            get { return windowsStartXCoordinate; }
        }

        public static int TotalServicedCar
        {
            get { return totalServicedCar; }
        }

        public static bool GeneratedData
        {
            get { return generatedData; }
        }

        public static List<Data> DataList
        {
            get { return dataList; }
        }

    }


 

}






