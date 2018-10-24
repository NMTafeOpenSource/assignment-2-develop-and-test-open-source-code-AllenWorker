using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int MakeYear { get; set; }
        public string RegistrationNumber { get; set; }
        public double OdometerReading { get; set; }
        public double TankCapacity { get; set; }

        private FuelPurchase fuelPurchase;
        private Journey journey;

        /**
	     * Class constructor specifying name of make (manufacturer), model and year
	     * of make.
	     * @param manufacturer
	     * @param model
	     * @param makeYear
	     */
        public Vehicle(string Manufacturer, string Model, int MakeYear, string RegistrationNumber, double OdometerReading, double TankCapacity)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.MakeYear = MakeYear;
            this.RegistrationNumber = RegistrationNumber;
            this.OdometerReading = OdometerReading;
            this.TankCapacity = TankCapacity;
            fuelPurchase = new FuelPurchase();
            journey = new Journey();
        }

        // TODO Add missing getter and setter methods

        /**
         * Prints details for {@link Vehicle}
         */
        public void PrintDetails()
        {
            Console.WriteLine("Vehicle: " + MakeYear + " " + Manufacturer + " " + Model);
            // TODO Display additional information about this vehicle
        }


        // TODO Create an addKilometers method which takes a parameter for distance travelled 
        // and adds it to the odometer reading. 


        // adds fuel to the car
        // check tank cap

        public void AddFuel(double litres, double price)
        {
            fuelPurchase.PurchaseFuel(litres, price);
        }

        
    }
}
