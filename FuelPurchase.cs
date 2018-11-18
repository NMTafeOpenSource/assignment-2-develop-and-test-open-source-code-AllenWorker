using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class FuelPurchase
    {
        public double Litres { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Class Constructor
        /// </summary>
        public FuelPurchase()
        {
            Litres = 0;
            Cost = 0;
        }

        public double FuelEconomy
        {
            get { return Cost / Litres; }
        }

        /// <summary>
        /// Add Fuel and Price to the total purchased
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="price"></param>
        public void PurchaseFuel(double amount, double price)
        {
            this.Litres += amount;
            this.Cost += price;
        }
    }
}
