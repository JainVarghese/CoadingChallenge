using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge;

internal class PassengerAge
{
    public DateOnly DateofBirth;
    public DateOnly Today;

    public void SetData()
    {
        Console.WriteLine("Enter DOB : ");
        DateofBirth = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter Today : ");
        Today = DateOnly.Parse(Console.ReadLine());
    }
    public void GetData()
    {
        Console.WriteLine("DOB : " + DateofBirth);

    }
    public void Details()
    {
        var days = Today.DayNumber - DateofBirth.DayNumber;
        var hours = days * 24;
        Console.WriteLine("No of Days : " + days);
        Console.WriteLine("No of hours : " + hours);
        Console.WriteLine("No of Weeks : " + days / 7);
        Console.WriteLine("No of months : " + days / 30);
        Console.WriteLine("No of Years : " + days / 365);
        var years = DateofBirth.Year;
        if (years % 400 == 0)
        {
            Console.WriteLine($"{DateofBirth} is a leap Year ");
        }
        else if (years % 100 != 0 && years % 400 == 0)
        {
            Console.WriteLine($"{DateofBirth} is a leap Year ");

        }
        else
        {
            Console.WriteLine($"{DateofBirth} is Not a leap Year ");

        }


    }
}


//public void findAge(int current_date,
//                   int current_month,
//                    int current_year,
//                      int birth_date,
//                     int birth_month,
//                      int birth_year)
//{
//    int[] month = { 31, 28, 31, 30, 31, 30,
//                  31, 31, 30, 31, 30, 31 };


//    if (birth_date > current_date)
//    {
//        current_month = current_month - 1;

//        current_date = current_date
//                  + month[birth_month - 1];
//    }


//    if (birth_month > current_month)
//    {
//        current_year = current_year - 1;
//        current_month = current_month + 12;
//    }

//    int calculated_date = current_date
//                             - birth_date;

//    int calculated_month = current_month
//                            - birth_month;

//    int calculated_year = current_year
//                             - birth_year;


//    Console.WriteLine("Present Age");
//    Console.WriteLine("Years: "
//                       + calculated_year +
//            " Months: " + calculated_month
//           + " Days: " + calculated_date);
//}
