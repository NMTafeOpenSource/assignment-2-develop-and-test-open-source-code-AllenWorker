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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddJourney
    {
        public AddJourney(string message)
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
            inputTextbox.SelectAll();
            inputTextbox.Focus();
        }

        public double Result
        {
            get { return Convert.ToDouble(inputTextbox.Text); }
        }
    }
}
