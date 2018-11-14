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
using MahApps.Metro.Controls.Dialogs;

namespace CarRentalSystem
{
    /// <summary>
    /// Interaction logic for AddFuel.xaml
    /// </summary>
    public partial class AddFuel
    {
        public double Fuel { get; set; }
        public double Price { get; set; }

        public AddFuel(string message)
        {
            InitializeComponent();
            messageTextblock.Text = message;
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fuel = Convert.ToDouble(fuelTextbox.Text);
                Price = Convert.ToDouble(priceTextbox.Text);
                this.DialogResult = true;
            }
            catch (FormatException)
            {
                this.ShowMessageAsync("Alert!", "Only Numbers are allowed!");
            }
            
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
           fuelTextbox.SelectAll();
            fuelTextbox.Focus();
        }

    }
}
