using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int MakeYear { get; set; }
        public string RegistrationNumber { get; set; }
        public double OdometerReading { get; set; }
        public double TankCapacity { get; set; }

        public FuelPurchase FuelPurchase { get; set; }
        public Journey Journey { get; set; }
        public Service Service { get; set; }

        /**
	     * Class constructor specifying name of make (manufacturer), model and year
	     * of make.
	     * @param manufacturer
	     * @param model
	     * @param makeYear
	     */
        public Vehicle(string Manufacturer, string Model, int MakeYear, string RegistrationNumber, double OdometerReading, double TankCapacity, double lastServiceOdometerKm)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.MakeYear = MakeYear;
            this.RegistrationNumber = RegistrationNumber;
            this.OdometerReading = OdometerReading;
            this.TankCapacity = TankCapacity;
            FuelPurchase = new FuelPurchase();
            Journey = new Journey();
            Service = new Service(lastServiceOdometerKm);
        }


        // TODO Create an addKilometers method which takes a parameter for distance travelled 
        // and adds it to the odometer reading. 
        public void AddJourney(double km)
        {
            Journey.AddKilometers(km);
            OdometerReading += km;
        }

        // adds fuel to the car
        // check tank cap

        public void AddFuel(double litres, double price)
        {
            FuelPurchase.PurchaseFuel(litres, price);
        }

        
    }
}
