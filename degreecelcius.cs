using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Conversion
    {
        static void converting()
        {
            Console.WriteLine("Enter the Degree Celsius");
            double cel = Convert.ToDouble(Console.ReadLine());
            double kel = cel + 273;
            double fah = cel * 18 / 10 + 32;
            Console.WriteLine(fah);
        }
        static void Main(string[] args)
        {
            converting();
        }
    }
}
