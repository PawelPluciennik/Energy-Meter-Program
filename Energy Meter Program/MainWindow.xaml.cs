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

namespace Energy_Meter_Program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            double InitialStane = Double.Parse(tBoxInitialState.Text);
            double FinalStane = Double.Parse(tBoxFinalState.Text);
            double PricekWh = Double.Parse(tBoxPricekWh.Text);
            InitializeComponent();
        }

        private void btnCalculateEverything_Click(object sender, RoutedEventArgs e)
        {
            EnergyCalculator zuzycie = new EnergyCalculator(tBoxInitialState.Text,tBoxFinalState.Text,tBoxPricekWh.Text);
           // zuzycie.
         
        }
    }
}
