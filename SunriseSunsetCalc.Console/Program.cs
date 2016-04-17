using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseSunsetCalc
{
    class Program
    {
        static double JD = 0;
        static int zone = 8; // Los Angeles time Zone
        static double latitude = 34.14; // Los Angeles lat
        static double longitude = 118.452; // Los Angeles lon 
        static bool dst = true; // Day Light Savings 
        static DateTime date = DateTime.Today;

        //Tested against these modules for accuracy
        //http://www.timeanddate.com/sun/usa/seattle
        //http://www.esrl.noaa.gov/gmd/grad/solcalc/


        static void Main(string[] args)
        {
            JD = Util.calcJD(date);  //OR   JD = Util.calcJD(2014, 6, 1);
            double sunRise = Util.calcSunRiseUTC(JD, latitude, longitude);
            double sunSet = Util.calcSunSetUTC(JD, latitude, longitude);
            System.Console.WriteLine(Util.getTimeString(sunRise, zone, JD, dst));
            System.Console.WriteLine(Util.getTimeString(sunSet, zone, JD, dst));
            System.Console.WriteLine("");
            System.Console.WriteLine(Util.getDateTime(sunRise, zone, date, dst).Value.ToString());
            System.Console.WriteLine(Util.getDateTime(sunSet, zone, date, dst).Value.ToString());
            Console.ReadLine();
        }
    }
}
