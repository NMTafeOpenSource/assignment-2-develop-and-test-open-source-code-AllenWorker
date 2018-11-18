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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
namespace CarRentalSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        List<Vehicle> vehicles;

        public MainWindow()
        {
            InitializeComponent();

            vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("Ford", "T812", 2014, "AX12WD", 1000, 2.5, 500));
            vehicles.Add(new Vehicle("BMW", "T49", 2018, "AX12WD", 9000, 5, 3000));
            vehicles.Add(new Vehicle("Ford", "T26E5", 2013, "AX12WD", 1500, 3, 1000));
            vehicles.Add(new Vehicle("Toyota", "T54E3", 2008, "AX12WD", 2500, 1.5, 600));
            vehicles.Add(new Vehicle("Ford", "T34", 2016, "AX12WD", 4000, 3.5, 2500));
            vehicles.Add(new Vehicle("Ford", "T28", 2015, "AX12WD", 800, 4, 100));
            
            VehicleListView.ItemsSource = vehicles;
        }


        private void VehicleListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vehicle ve = (Vehicle)VehicleListView.SelectedItem;
            if (ve != null)
            {
                txtBlockManufacturer.Text = ve.Manufacturer.ToString();
                txtBlockModel.Text = ve.Model.ToString();
                txtBlockMakeYear.Text = ve.MakeYear.ToString();
                txtBlockRegistrationNumber.Text = ve.RegistrationNumber.ToString();
                txtBlockOdometerReading.Text = ve.OdometerReading.ToString();
                txtBlockTankCapacity.Text = ve.TankCapacity.ToString();
            }
        }

        private void addJourneyButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)VehicleListView.SelectedItem;
            AddJourney addJourney = new AddJourney("Add Journey(km)");
            if (addJourney.ShowDialog() == true)
            {
                // TODO Journey add to selected Vehicle
                ve.AddJourney(addJourney.Result);
                txtBlockOdometerReading.Text = ve.OdometerReading.ToString();
            }
        }

        private void addFuelButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)VehicleListView.SelectedItem;
            AddFuel addFuel = new AddFuel("Add Fuel(by Litre) and Price");
            if (addFuel.ShowDialog() == true)
            {
                ve.AddFuel(addFuel.Fuel, addFuel.Price);
            }
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)VehicleListView.SelectedItem;
            CalculatePrice calculatePrice = new CalculatePrice(ve);
            calculatePrice.ShowDialog();
        }

        private void detailButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)VehicleListView.SelectedItem;
            Detail detail = new Detail(ve);
            detail.ShowDialog();
        }
    }
}
