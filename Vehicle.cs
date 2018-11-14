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

        /// <summary>
        /// Class constructor specifying name of Manufacturer, Model, MakeYear, RegistrationNumber, OdometerReading,
        /// TankCapacity, lastServiceOdometerKm
        /// </summary>
        /// <param name="Manufacturer"></param>
        /// <param name="Model"></param>
        /// <param name="MakeYear"></param>
        /// <param name="RegistrationNumber"></param>
        /// <param name="OdometerReading"></param>
        /// <param name="TankCapacity"></param>
        /// <param name="lastServiceOdometerKm"></param>
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


        /// <summary>
        /// Add how far the car has driven to Journey and OdoneterReading
        /// </summary>
        /// <param name="km"></param>
        public void AddJourney(double km)
        {
            Journey.AddKilometers(km);
            OdometerReading += km;
        }

        
        /// <summary>
        /// Add Fuel and Price to FuelPurchase class
        /// </summary>
        /// <param name="litres"></param>
        /// <param name="price"></param>
        public void AddFuel(double litres, double price)
        {
            FuelPurchase.PurchaseFuel(litres, price);
        }

        
    }
}
