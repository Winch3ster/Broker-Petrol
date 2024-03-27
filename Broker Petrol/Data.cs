using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Petrol
{
    /// <summary>
    /// This Data class is responsible to store the fuel transactions that occured at each pump
    /// </summary>
    public class Data
    {
        public int pumpId { get; set; }
        public int totalFuelDispensed { get; set; }
        public int totalLPGDispensed { get; set; }
        public int totalUnleadedDispensed { get; set; }
        public int totalDieselDispensed { get; set; }
    }
}
