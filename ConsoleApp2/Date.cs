using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Date
    {
        //Crarte 3 peoperties of type int and name them as Day ,Month,Year
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }




        public Date()
        {
            Day = 1;
            Month = 1;
            Year = 2022;
        }
        public Date(int d, int m, int y)
        {
            this.Day = d; this.Month = m; this.Year = y;
        }

        //to print the propertis of the Date class create 1.Method 2.tostring()

        public override string ToString()
        {
            return "" + Day + "/" + Month + "/" + Year;
        }

        public void DiplayDate()
        {
            Console.WriteLine(Day + " /" + Month + " / " + Year);

        }

        class DateMainCLass
        {
            public static void Main()
            {
                Date obj = new Date(1, 1, 2022);
                obj.ToString();
                Console.WriteLine(obj);
                Console.ReadKey();
            }
        }
    }
}






