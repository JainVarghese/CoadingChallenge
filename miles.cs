using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge;

internal class TotalMilesTravelled
{
    public string PassengerName { get; set; }
    public int Mile { get; set; }

    public TotalMilesTravelled()
    {
        Console.Write("Passenger Name  : ");
        PassengerName = Console.ReadLine();
        Console.Write("Miles Travelled : ");
        Mile = int.Parse(Console.ReadLine());
    }
    public void CalculateFligherPoints()
    {
        var _flyerpoints = 0;
        if (Mile >= 10000 && Mile < 20000)
            _flyerpoints = 10;
        if (Mile >= 20000 && Mile < 50000)
            _flyerpoints = 20;
        if (Mile >= 50000 && Mile < 100000)
            _flyerpoints = 30;
        if (Mile >= 100000)
            _flyerpoints = 50;

        Console.WriteLine(_flyerpoints);
    }

}