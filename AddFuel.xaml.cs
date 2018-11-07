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
    /// Interaction logic for AddFuel.xaml
    /// </summary>
    public partial class AddFuel
    {
        public AddFuel(string message)
        {
            InitializeComponent();
            messageTextblock.Text = message;
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
           fuelTextbox.SelectAll();
            fuelTextbox.Focus();
        }

        public double Fuel
        {
            get { return Convert.ToDouble(fuelTextbox.Text); }
        }

        public double Price
        {
            get { return Convert.ToDouble(priceTextbox.Text); }
        }
    }
}
