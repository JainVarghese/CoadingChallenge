using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge;

internal class Flight
{
    public long FlightFare { get; set; }
    public string Time { get; set; }

    public Flight()
    {
        Console.Write("Flight Fare : ");
        FlightFare = int.Parse(Console.ReadLine());
        Console.Write("Time        : ");
        Time = Console.ReadLine();
    }
    public void GetMethod()
    {
        var t = new string[2];
        t = Time.Split(' ');
        var time = long.Parse(t[0]);
        long fare_incr = 0;
        if (t[1] == "PM")
        {
            time += 12;
        }
        if (time >= 6 && time <= 9)
        {
            fare_incr = (FlightFare * 10) / 100;
            FlightFare += fare_incr;
        }
        if (time >= 9 && time <= 17)
        {
            fare_incr = (FlightFare * 20) / 100;
            FlightFare += fare_incr;
        }
        if (time >= 17 && time <= 23)
        {
            fare_incr = (FlightFare * 7) / 100;
            FlightFare += fare_incr;
        }
        if ((time >= 23 && time <= 24) && (time <= 6))
        {
            fare_incr = (FlightFare * 5) / 100;
            FlightFare += fare_incr;
        }
        Console.WriteLine($"Flight Fare: {FlightFare}");
    }

}