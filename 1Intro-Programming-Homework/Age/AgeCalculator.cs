using System;

class AgeCalculator
{
    public static void Main()
    {
        DateTime todayDate = DateTime.Today;
        DateTime userBirthdate = DateTime.MinValue;

        //Validate the input and set as a variable
        bool inputValid = false;
        while (inputValid != true)
        {
            userBirthdate = DateTime.Parse(Console.ReadLine());

            if (userBirthdate > todayDate)
            {
                Console.Write("Invalid Date. Please enter your date of birth (dd/mm/yy):  ");
            }
            else
            {
                inputValid = true;
            }
        }

        //Calcute user age 
        int userAge = todayDate.Year - userBirthdate.Year;
        if (userBirthdate > todayDate.AddYears(-userAge))
            userAge--;

        //Calculate user age after 10 years
        int userAgeTen = userAge + 10;

        Console.WriteLine("{0}\n{1}", userAge, userAgeTen);
        Console.ReadLine();
    }
}


/* string line;

 Console.WriteLine("Enter one or more lines of text (press CTRL+Z to exit): ");
 Console.WriteLine();

 do
 {
     Console.Write(" ");
     line = Console.ReadLine();
     if (line != null)
         Console.WriteLine("    " + line);
 } while (line != null);

 */
/*   Console.Clear();

   DateTime date = DateTime.Now;

   Console.WriteLine("Today is {0:d} at {0:T}.", date);

   //Console.ReadLine();
   */





//Error with 7 Month
/*
 * using System;

namespace AgePlusTen
{
class Program
{
    static void Main()
    {

        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        int age = (int)((DateTime.Now.AddMonths(-7) - BirthDay).TotalDays / 365.242199);
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}
}
 */
