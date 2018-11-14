using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class CalculateRentalPrice
    {
        public double Distance { get; private set; }
        public double FuelCost { get; private set; }
        public double PriceByKm { get; set; }

        /// <summary>
        /// Class Constructor
        /// </summary>
        public CalculateRentalPrice(double distance, double fuelCost)
        {
            Distance = distance;
            FuelCost = fuelCost;
        }

        /// <summary>
        /// Calculate the total rental price
        /// </summary>
        /// <returns>Total price</returns>
        public double Calculate()
        {
            double result=0;
            result = (Distance * PriceByKm) + FuelCost;
            return result;
        }
    }
}
