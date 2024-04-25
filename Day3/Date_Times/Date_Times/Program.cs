using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var date_time = new DateTime(2024, 1, 1);
            //var now = DateTime.Now; 
            //var today = DateTime.Today;

            ////Console.WriteLine("Hour :" + now.Hour);
            ////Console.WriteLine("Minute :" + today.Minute);

            ////var tomarrow = now.AddDays(1);  
            ////var yesterday = now.AddDays(-1);

            ////Console.WriteLine(tomarrow);
            ////Console.WriteLine(yesterday);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString());



            //creating time span object

            var timespan = new TimeSpan(1, 2, 3);
            //Console.WriteLine(timespan);
            //Console.WriteLine(timespan.ToString());

            //var start = DateTime.Now;
            //var end = DateTime.Now.AddMinutes(5);
            //var duration  = start - end;
            //Console.WriteLine(duration.ToString());


            //Properties
            Console.WriteLine(timespan.Minutes);
            Console.WriteLine(timespan.TotalMinutes);
        }
    }
}
