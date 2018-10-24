using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class FuelPurchase
    {
        private double fuelEconomy;
        public double Litres { get; set; }
        public double Cost { get; set; }

        public FuelPurchase()
        {
            Litres = 0;
            Cost = 0;
        }

        public double FuelEconomy
        {
            get { return Cost / Litres; }
        }

        /*  NOT IN USE
        public void SetFuelEconomy(double fuelEconomy)
        {
            this.FuelEconomy = fuelEconomy;
        }
        */

        public void PurchaseFuel(double amount, double price)
        {
            this.Litres += amount;
            this.Cost += price;
        }
    }
}
