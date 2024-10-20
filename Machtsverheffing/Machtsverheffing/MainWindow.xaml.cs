using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Machtsverheffing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            long Startnumber;
            bool isValid = long.TryParse(numberTextBox.Text, out Startnumber);
            long number = Startnumber;
            long exponent = 1;
            StringBuilder result = new StringBuilder();
            if (isValid)
            {
                do
                {
                    number *= Startnumber;
                    result.AppendLine($"De macht {exponent} van {numberTextBox.Text} is {number}.");
                    exponent++;
                } while (exponent <= 10);
            }
            else
            {
                MessageBox.Show("Geen geldig getal");
            }

            resultTextBox.Text = result.ToString();
        }

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Clear();
            resultTextBox.Clear();
            numberTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}