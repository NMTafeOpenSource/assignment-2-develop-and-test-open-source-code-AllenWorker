using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarRentalSystem
{
    /// <summary>
    /// Interaction logic for CalculatePrice.xaml
    /// </summary>
    public partial class CalculatePrice
    {
        Vehicle selectedVehicle;
        public CalculatePrice(Vehicle ve)
        {
            InitializeComponent();
            selectedVehicle = ve;
            Initializedata();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            CalculateRentalPrice rentalPrice = new CalculateRentalPrice(selectedVehicle.Journey.Kilometers, selectedVehicle.FuelPurchase.Cost);
            rentalPrice.PriceByKm = 10.5;
            double total = rentalPrice.Calculate();
            textblockTotal.Text = total.ToString();
        }

        public void Initializedata()
        {
            textblockMFR.Text = selectedVehicle.Manufacturer;
            textblockRegNum.Text = selectedVehicle.RegistrationNumber;
            textblockModel.Text = selectedVehicle.Model;
            textblockTankCap.Text = selectedVehicle.TankCapacity.ToString();
            textblockDistance.Text = selectedVehicle.Journey.Kilometers.ToString();
            textblockFuelRefilled.Text = selectedVehicle.FuelPurchase.Litres.ToString();
            textblockFuelCost.Text = selectedVehicle.FuelPurchase.Cost.ToString();
            textblockFuelEco.Text = (double.IsNaN(selectedVehicle.FuelPurchase.FuelEconomy)) ? "0" : selectedVehicle.FuelPurchase.FuelEconomy.ToString();

        }
    }
}
