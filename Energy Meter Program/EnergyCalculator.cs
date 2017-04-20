using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Meter_Program
{
    public class EnergyCalculator
    {

        public double InitilalState;
        public double FinalState;
        public double PricekWh;
        public double Wear;
        public double FinalPrice;

        public string Message;


        public double Calculate()
        {
            CalculateDifference();
            GetEnergyCost();

            return Wear;
        }
        private void CalculateDifference()
        {
            Wear = FinalState - InitilalState;

        }


        private void GetEnergyCost()
        {
            FinalPrice = Wear * PricekWh;
        }
    }
}
