using System;

namespace Parking
{
    class Program
    {
        //  ***************************************************************
        //  Description: Application can calculate the cost of parking for
        //               a single customer and all customer 
        //  Title:       Parking Cost 
        //  Aurthor:     Andrew Schaub
        //  Date Modified: 4/26/2020
        //  ***************************************************************
        static void Main(string[] args)
        {
            //
            // User input here & varibles 
            //

            int numOfCustomers; 
            double hours; 
            double total = 0.0;

            Console.WriteLine("Enter Number of Customers");
            numOfCustomers = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 1; i <= numOfCustomers; i++) 
            {
                Console.WriteLine("\nEnter the Number of Hours Customer {0} Parked", i);
                hours = Convert.ToDouble(Console.ReadLine()); 
                Customers cust = new Customers(hours); 
                Console.WriteLine("\nCustomer {0} has a total of: {1:C2}", i, cust.CaculateCharges());
                total += cust.CaculateCharges(); 
            }
            //
            // Total of all
            //

            Console.WriteLine("The Total Charges For All Customers are {0:C2}", total);
            Console.ReadLine();
        }
    }
}
