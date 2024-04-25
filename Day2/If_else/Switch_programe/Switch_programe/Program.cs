using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_programe
{

    public enum Season
    {
        Spring, 
        Summer,
        Winter
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Summer;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("its beautiful");
                    break;

                case Season.Summer:
                    Console.WriteLine("its perfect time to go to beach");
                    break;

                default:
                    Console.WriteLine("its ok");
                    break;
            }
        }
    }
}
