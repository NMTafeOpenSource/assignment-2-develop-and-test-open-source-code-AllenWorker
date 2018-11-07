using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class CalculateRentalPrice
    {
        public double Distance { get; private set; }
        public double FuelCost { get; private set; }
        public double PriceByKm { get; set; }

        public CalculateRentalPrice(double distance, double fuelCost)
        {
            Distance = distance;
            FuelCost = fuelCost;
        }

        public double Calculate()
        {
            double result=0;
            result = (Distance * PriceByKm) + FuelCost;
            return result;
        }
    }
}
