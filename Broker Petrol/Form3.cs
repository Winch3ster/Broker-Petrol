using System;
using System.Windows.Forms;

namespace Broker_Petrol
{
    public partial class Form3 : Form
    {
        //Label to display the fuel transactions
        private static Label vTotalFuelDispensedText;
        private static Label vCarServicedText;
        private static Label vCarLeftText;

        //Type of fuel dispensed counter
        private static int LPGDispensed;
        private static int dieselDispensed;
        private static int unleadedDispensed;
        private static int totalFuelDispensed;


        //Prices according to fuel type per litre
        private const double dieselPerLitre = 1.82;
        private const double LPGPerLitre = 0.86;
        private const double unleadedPerLitre = 1.58;


        private static double commission;
        private static double income;

        private static bool shiftEnded = false;

        public Form3()
        {
            InitializeComponent();
            startSimulation(); //Start the simulation once the page loads
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            timer1.Start();

            vTotalFuelDispensedText = this.totalFuelDispensedText;
            vCarServicedText = this.vehicleServicedText;
            vCarLeftText = this.vehicleLeftText;
            
            //Display today's date 
            date.Text = "Today's date: " + DateTime.Now.Day + " /" + DateTime.Now.Month + " /" + DateTime.Now.Year;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            timePlaceHolder.Text = DateTime.Now.ToLongTimeString(); //Display current time

            //if the current time is between 7 a.m. to 7 p.m.
            if (currentTime.Hour > 6 && currentTime.Hour < 20)
            {
                //Set the day icon to sunny
                timeIcon.BackgroundImage = Properties.Resources.sunny;
                timeIcon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else //if the current time is between 7 a.m. to 7 a.m.
            {
                //Set the day icon to crescent 
                timeIcon.BackgroundImage = Properties.Resources.night_mode;
                timeIcon.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //update UI text element
            vTotalFuelDispensedText.Text = "Total fuel dispensed: " + SimulationView.fuelDispensed + " litre";
            vCarLeftText.Text = "Vehicles left without refueling: " + SimulationView.CarLeftWithoutRefueling;
            vCarServicedText.Text = "Number of vehicles serviced: " + SimulationView.TotalServicedCar;

            
            totalFuelDispensed = SimulationView.FuelDispensed;
            LPGDispensed = SimulationView.LPGDispensed;
            unleadedDispensed = SimulationView.DieselDispensed;
            dieselDispensed = SimulationView.UnleadedDispensed;


            lpgDispensedPlaceHolder.Text = LPGDispensed + " litre";
            unleadedDispensedPlacceHolder.Text = unleadedDispensed + " litre";
            dieselDispensedPlaceHolder.Text = dieselDispensed + " litre";


            //calculate and update the income earned in real life
            calculateCommission();

        }
        private void endShiftBtn_Click(object sender, EventArgs e)
        {
            //If the user clicks on end shift, set shiftEnded to true 
            shiftEnded = true;
                
            //Generate a summary of fuel transaction that occurs at each pump
            SimulationView.GeneratePumpDataSummary();

            if (SimulationView.GeneratedData) //Once the data is generated 
            {
                // "Close this form"
                this.timer1.Stop();
                this.Hide();

                // Open the shift report page 
                ShiftReport shiftReportPage = new ShiftReport();
                shiftReportPage.Show();
            }
        }

        
        private void startSimulation()
        {
            //Create the simulation view (another windows form)
            SimulationView simulationView = new SimulationView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            //Add the simulation view into this form
            this.simulationViewPanel.Controls.Add(simulationView);
            simulationView.Show();
        }


       public void calculateCommission()
        {
            //calculate the sales of each type of fuel
            double salesOfDiesel = dieselDispensed * dieselPerLitre;
            double salesOfLPG = LPGDispensed * LPGPerLitre;
            double salesOfUnleaded = unleadedDispensed * unleadedPerLitre;

            //Total sales of the fuel
            double totalFuelSales = salesOfDiesel + salesOfLPG + salesOfUnleaded;

            commission = totalFuelSales * 0.01;

            //Assuming that the user have worked 8 hours when the shift ends
            //income = 8 hours * 2.49 GBP per hour + commission earned during the shift
            income = (8 * 2.49) + commission;

            //Display the commission earned
            commissionPlaceHolder.Text = Math.Round(commission, 2) + " $"; 

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //Getters code
        public static bool ShiftEnded
        {
            get { return shiftEnded; }
        }
        public static double Income
        {
            get { return income; }
        }
        public static double Commission
        {
            get { return commission; }
        }
    }
}
