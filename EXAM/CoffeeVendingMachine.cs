using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace CoffeeVendingMachine
{
    class CoffeeVendingMachine
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            int n1, n2, n3, n4, n5;
            double A, P;
            double sumM = 0;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            A = double.Parse(Console.ReadLine());
            P = double.Parse(Console.ReadLine());

            sumM = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5 * 1.00;

            if (A > P)
            {
                double change = A - P;

                if (sumM >= change)
                {
                    double yes = sumM - change;
                    Console.WriteLine("Yes {0:F2}", yes);
                }
                else
                {
                    double no = change - sumM;
                    Console.WriteLine("No {0:F2}", no);
                }

            }
            else
            {
                double more = P - A;
                Console.WriteLine("More {0:F2}", more);
            }

        }
    }
}

/*
 		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
	
		// Read the input
        int trayOne = int.Parse(Console.ReadLine());
        int trayTwo = int.Parse(Console.ReadLine());
        int trayThree = int.Parse(Console.ReadLine());
        int trayFour = int.Parse(Console.ReadLine());
        int trayFive = int.Parse(Console.ReadLine());
        decimal givenAmount = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

		// Check the 3 possible cases
        if (givenAmount < drinkPrice)
        {
            decimal difference = drinkPrice - givenAmount;
            Console.WriteLine("More {0:F2}", difference);
        }
        else
        {
            decimal moneyInTrays = 
				0.05m * trayOne + 
				0.10m * trayTwo + 
				0.20m * trayThree + 
				0.50m * trayFour + 
				1.00m * trayFive;
            decimal changeToGive = givenAmount - drinkPrice;
            decimal difference = Math.Abs(moneyInTrays - changeToGive);
            
            if (changeToGive <= moneyInTrays)
            {
                Console.WriteLine("Yes {0:F2}", difference);
            }
            else
            {
                Console.WriteLine("No {0:F2}", difference);
            }*/
