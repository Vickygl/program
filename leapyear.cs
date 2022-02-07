using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class leapYear
    {
        public static void leap_year()
        {
            Console.WriteLine(" enter the year in digits");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
            {
                Console.WriteLine("The Entered Year is a Leap Year" + a);
            }
            else
            {
                Console.WriteLine("The Entered Year is not a Leap Year" + a);
            }
        }
        static void Main(string[] args)
        {
            leap_year();
        }
    }
}

