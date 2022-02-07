using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class RealNumbers
    {
        static void Main(string[] args)
        {
            int PosSum = 0;
            int NegSum = 0;
            int PosCount = 0;
            int NegCount = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter The Numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    PosCount += 1;
                    PosSum += n;
                }
                else
                {
                    NegCount += 1;
                    NegSum += n;
                }
            }
            try
            {
                Console.WriteLine($"The Average of the Positive numbers is: {PosSum / PosCount} and Average of Negative Numbers is: {NegSum / NegCount}");
            }
            catch (Exception)
            {

                throw new Exception("Please add Some Negative values to Process");
            }
        }

    }
}
