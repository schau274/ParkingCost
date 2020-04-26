using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    internal class Customers
    {
        //
        //  Parking cost varibles
        // 

        const double minimunCharge = 2.0; 
        const double serviceCharge = 0.5; 
        const int basicHours = 3;
        private double _hours;

        
        public Customers(double hours) 
        {
            Hours = hours; 
        }

        public double Hours 
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 168)
                {
                    Console.WriteLine("Customer can only park for 24 hours");
                }
                   
                else
                {
                    _hours = value;
                }
                   
            }
        }

        public double CaculateCharges()
        {
            double totalCharge;
            
            if (Hours <= 3)
                totalCharge = Hours * minimunCharge; 

            else
                totalCharge = (minimunCharge * basicHours) + ((Hours - basicHours) * (minimunCharge + serviceCharge)); 

            return totalCharge; 
        }
    }
}
