using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Broker_Petrol
{
    public partial class ShiftReport : Form
    {
        private List<Data> dataList;

        public ShiftReport()
        {
            dataList = SimulationView.DataList;
            InitializeComponent();
            generateSummary();
            generateDataGridView();
        }

        private void generateSummary()
        {
            ///Display the data
            date.Text = "Date: " + DateTime.Now.Day +  " /" + DateTime.Now.Month + " /" + DateTime.Now.Year;

            totalFuel.Text = "Total fuel dispensed: " + SimulationView.fuelDispensed + " litre";
            lpg.Text = "Total LPG dispensed: " + SimulationView.LPGDispensed + " litre";
            unleaded.Text = "Total unleaded dispensed: " + SimulationView.UnleadedDispensed + " litre";
            diesel.Text = "Total diesel dispensed: " + SimulationView.DieselDispensed + " litre";

            vehicleLeft.Text = "Vehicle left without refueling: " + SimulationView.CarLeftWithoutRefueling;
            vehicleServiced.Text = "Number of serviced vehicle: " + SimulationView.TotalServicedCar;

            commission.Text = "Commission earned: " + Math.Round(Form3.Commission, 2) + " $";
            income.Text = "Income earned: " + Math.Round(Form3.Income, 2) + " $";
            
        }

        private void generateDataGridView()
        {
            //Update the data grid with new row of data
            foreach ( Data data in dataList)
            {
                dataGridView1.Rows.Add(data.pumpId, data.totalFuelDispensed, data.totalLPGDispensed, data.totalUnleadedDispensed, data.totalDieselDispensed);
            }
        }

        private void ShiftReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
