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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddJourney
    {
        public double Result { get; set; }
        public AddJourney(string message)
        {
            InitializeComponent();
            messageTextblock.Text = message;
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result = Convert.ToDouble(inputTextbox.Text);
                this.DialogResult = true;
            }
            catch (FormatException)
            {
                this.ShowMessageAsync("Alert!", "Only Number are allowed!");
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            inputTextbox.SelectAll();
            inputTextbox.Focus();
        }
    }
}
