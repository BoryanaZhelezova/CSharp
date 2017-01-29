using System;

class Employee_Data
{
    static void Main()
    {
        string firstName;
        string lastName;
        byte Age;
        char gender;
        long personalIDN;
        int uniqueEmployeeN;

        firstName = "Boryana";
        lastName = "Zhelezova";
        Age = 25;
        gender = 'f';
        personalIDN = 8112312891;
        uniqueEmployeeN = 27560001;

        Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}\n", firstName,
            lastName, Age, gender, personalIDN, uniqueEmployeeN);
    }
}

