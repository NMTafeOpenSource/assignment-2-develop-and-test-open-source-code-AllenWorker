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
        DataTable vehicleDataTable = new DataTable("Vehicles");
        DataView vehicleDataView;
        public MainWindow()
        {
            InitializeComponent();
            CreateDataTable();
            vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("Ford", "T812", 2014, "AX12WD", 1000, 2.5));
            vehicles.Add(new Vehicle("BMW", "T49", 2018, "AX12WD", 9000, 5));
            vehicles.Add(new Vehicle("Ford", "T26E5", 2013, "AX12WD", 1500, 3));
            vehicles.Add(new Vehicle("Toyota", "T54E3", 2008, "AX12WD", 2500, 1.5));
            vehicles.Add(new Vehicle("Ford", "T34", 2016, "AX12WD", 4000, 3.5));
            vehicles.Add(new Vehicle("Ford", "T28", 2015, "AX12WD", 800, 4));

            foreach (Vehicle vehicle in vehicles)
            {
                DataRow row;
                row = vehicleDataTable.NewRow();
                row["Manufacturer"] = vehicle.Manufacturer;
                row["Model"] = vehicle.Model;
                row["MakeYear"] = vehicle.MakeYear;
                row["RegistrationNumber"] = vehicle.RegistrationNumber;
                row["OdometerReading"] = vehicle.OdometerReading;
                row["TankCapacity"] = vehicle.TankCapacity;

                vehicleDataTable.Rows.Add(row);
            }
            // Vehicle sample distance

            /* NOT IN USE
            v.AddFuel(new Random().NextDouble() * 10, 1.3);

            v.PrintDetails();
            Console.WriteLine("\n\n");
            Console.ReadLine();
            */
            vehicleDataView = new DataView(vehicleDataTable);
            VehicleDataGrid.DataContext = vehicleDataView;
        }
        public void CreateDataTable()
        {
            vehicleDataTable.Columns.Add("Manufacturer", typeof(String));
            vehicleDataTable.Columns.Add("Model", typeof(String));
            vehicleDataTable.Columns.Add("MakeYear", typeof(Int32));
            vehicleDataTable.Columns.Add("RegistrationNumber", typeof(String));
            vehicleDataTable.Columns.Add("OdometerReading", typeof(Double));
            vehicleDataTable.Columns.Add("TankCapacity", typeof(Double));

            /*
            vehicleDataTable.Columns["Manufacturer"].MaxLength = 10;
            vehicleDataTable.Columns["Manufacturer"].AllowDBNull = false;
            vehicleDataTable.Columns["Manufacturer"].Unique = false;
            */
        }

        private void VehicleDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView drv = dg.SelectedItem as DataRowView;
            if (drv != null)
            {
                txtBlockManufacturer.Text = drv["Manufacturer"].ToString();
                txtBlockModel.Text = drv["Model"].ToString();
                txtBlockMakeYear.Text = drv["MakeYear"].ToString();
                txtBlockRegistrationNumber.Text = drv["RegistrationNumber"].ToString();
                txtBlockOdometerReading.Text = drv["OdometerReading"].ToString();
                txtBlockTankCapacity.Text = drv["TankCapacity"].ToString();
            }
        }
    }
}
