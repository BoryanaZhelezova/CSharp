using System;

class Null_Values_Arithmetic
{
    static void Main()
    {
        /*Нулевите типове се използват за съхраняване на информация, 
         * която не е задължителна. Например, ако искаме да запазим данните за един студент, 
         * като името и фамилията му са задължителни, а възрастта му не е задължителна, можем да използваме 
         * int? за възрастта:*/
        int? number1 = null;
        double? number2 = null;
        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + null;
        number2 = number2 + null;

        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + 100;
        number2 = number2 + 100.5;

        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + 100;
        number2 = number2 + 100.5;

        Console.WriteLine("{0};{1}", number1.GetValueOrDefault(),
            number2.GetValueOrDefault());
    }
}

