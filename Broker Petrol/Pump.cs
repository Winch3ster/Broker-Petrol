using System;
using System.Windows.Forms;

using System.Drawing;


namespace Broker_Petrol
{
    class Pump : Panel
    {
        private int pumpId;

        //Fuel data
        private int totalFuelDispensedByPump;
        private int lpgDispensedByPump;
        private int dieselDispensedByPump;
        private int unleadedDispensedByPump;

        //Location of the pump
        public int xCoordinate;
        public int yCoordinate;

        //Appearance of the pump
        private Color pumpColor;


        public Pump(int id, int pxCoordinate, int pyCoordinate)
        {
            //Set the attributes of the pump
            this.pumpId = id;
            this.BackColor = Color.LightSlateGray;
            this.xCoordinate = pxCoordinate;
            this.yCoordinate = pyCoordinate;
            this.Location = new Point(xCoordinate, yCoordinate);
            this.Size = new Size(30, 20);


            //To indicate that the pump is not in use, set the tag (inherited from Panel class) to available
            //the program will check if there is any vehicle using this pump via its tag
            this.Tag = "available";
        }


        //Getters and setters code
        public int Id
        {
            get { return pumpId; }
        }

        public int TotalFuelDispensedByPump
        {
            get { return totalFuelDispensedByPump; }
            set { totalFuelDispensedByPump = value; }
        }

        public int LpgDispensedByPump
        {
            get { return lpgDispensedByPump; }
            set { lpgDispensedByPump = value; }
        }

        public int DieselDispensedByPump
        {
            get { return dieselDispensedByPump; }
            set { dieselDispensedByPump = value; }
        }

        public int UnleadedDispensedByPump
        {
            get { return unleadedDispensedByPump; }
            set { unleadedDispensedByPump = value; }
        }
    }
}
