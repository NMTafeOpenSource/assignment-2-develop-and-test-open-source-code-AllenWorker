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
    /// Interaction logic for Detail.xaml
    /// </summary>
    public partial class Detail
    {
        Vehicle selectedVehicle;
        DateTime defaultDateTime = new DateTime(10, 10, 10);
        public Detail(Vehicle ve)
        {
            InitializeComponent();
            selectedVehicle = ve;
            Initializedata();
        }


        /// <summary>
        ///  Initialize data and show on screen
        /// </summary>
        public void Initializedata()
        {
            textblockMFR.Text = selectedVehicle.Manufacturer;
            textblockRegNum.Text = selectedVehicle.RegistrationNumber;
            textblockModel.Text = selectedVehicle.Model;
            textblockMakeYear.Text = selectedVehicle.MakeYear.ToString();
            textblockTankCap.Text = selectedVehicle.TankCapacity.ToString();
            textblockOdo.Text = selectedVehicle.OdometerReading.ToString();
            textblockDistance.Text = selectedVehicle.Journey.Kilometers.ToString();
            textblockFuelRefilled.Text = selectedVehicle.FuelPurchase.Litres.ToString();
            textblockFuelCost.Text = selectedVehicle.FuelPurchase.Cost.ToString();
            textblockFuelEco.Text = (double.IsNaN(selectedVehicle.FuelPurchase.FuelEconomy))?"0": selectedVehicle.FuelPurchase.FuelEconomy.ToString();


            textblockLastServiceOdo.Text = selectedVehicle.Service.LastServiceOdometerKm.ToString();
            textblockServiceCount.Text = selectedVehicle.Service.ServiceCount.ToString();
            if (selectedVehicle.Service.ServiceRequired())
            {
                textblockServiceStatus.Text = "Service Required!";
                textblockServiceStatus.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                textblockServiceStatus.Text = "All Good!";
                textblockServiceStatus.Foreground = new SolidColorBrush(Colors.LightGreen);
            }
            textblockServiceServiceDate.Text = (selectedVehicle.Service.LastServiceDate == defaultDateTime)?"NOT RECORDED" : selectedVehicle.Service.LastServiceDate.ToShortDateString();
        }

        private void recordServiceButton_Click(object sender, RoutedEventArgs e)
        {
            selectedVehicle.Service.RecordService(selectedVehicle.OdometerReading);
            Initializedata();
        }
    }
}
