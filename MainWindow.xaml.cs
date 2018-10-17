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

namespace CarRentalSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Vehicle v = new Vehicle("Ford", "T812", 2014);

            // Vehicle sample distance
            v.AddFuel(new Random().NextDouble() * 10, 1.3);

            v.PrintDetails();
            Console.WriteLine("\n\n");
            Console.ReadLine();
        }
    }
}
